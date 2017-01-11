using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneSystemInventoryManager
{
    public partial class CreatePhoneToOfficeJackForm : Form
    {
        public CreatePhoneToOfficeJackForm(MainForm mainForm)
        {
            mf = mainForm;
            InitializeComponent();
        }

        private void PPPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public class FormSelection
        {
            public Venue ven;
            public VenueSpace vs;
            public IDF idf;
            public List<PatchPanel> ppFilteredList = new List<PatchPanel>();
            public PatchPanel pp;
            public List<PatchPanelPort> pppFilteredList = new List<PatchPanelPort>();
            public PatchPanelPort ppp;
            public string mac;
        }

        public class Venue
        {
            public int venueID;
            public string venueName;
        }

        public class VenueSpace
        {
            public int venueSpaceID;
            public string venueSpaceName;
            public int venueID;
        }

        public class IDF
        {
            public int idfID;
            public int venueSpaceID;
            public string idfName;
        }

        public class Phone
        {
            public int phoneID;
            public string mac;
            public string type;
            public string isRegistered;
        }

        public class PatchPanel
        {
            public int patchPanelID;
            public string patchPanelName;
            public int idfID;
            public List<int> patchPanelPortsOpen = new List<int>();
        }

        public class PatchPanelPort
        {
            public int patchPanelPortID;
            public int patchPanelPortNum;
            public int patchPanelID;
        }

        private MainForm mf;
        public FormSelection fs = new FormSelection();
        private int timeLeft = 100;

        List<Venue> venueList = new List<Venue>();
        List<VenueSpace> venueSpaceList = new List<VenueSpace>();
        List<IDF> idfList = new List<IDF>();
        List<PatchPanel> PPList = new List<PatchPanel>();
        List<PatchPanelPort> PPPList = new List<PatchPanelPort>();
        List<Phone> phoneList = new List<Phone>();

        private void CreatePhoneToOfficeJackForm_Load(object sender, EventArgs e) //load venues into combobox
        {
            string venueQuery = "SELECT Venue.VenueID, Venue.VenueName FROM [Venue];";
            string venueSpaceQuery = "SELECT VenueSpace.VenueSpaceID, VenueSpace.VenueSpaceName, VenueSpace.VenueID FROM [VenueSpace];";
            string idfQuery = "SELECT IDF.IDFID, IDF.IDFName, IDF.VenueSpaceID FROM [IDF];";
            string ppQuery = "SELECT PatchPanel.PatchPanelID, PatchPanel.PatchPanelName, PatchPanel.IDFID FROM [PatchPanel];";
            string ppPortQuery = "SELECT PatchPanelPort.PatchPanelPortID, PatchPanelPort.PatchPanelPortNum, PatchPanelPort.PatchPanelID FROM [PatchPanelPort] WHERE PatchPanelPort.SwitchPortID IS NULL;";
            string phoneQuery = "SELECT Phone.MAC, Phone.Type, Phone.Registered FROM [Phone];";

            DataSet venDS = getDataSet(venueQuery);
            DataSet vsDS = getDataSet(venueSpaceQuery);
            DataSet idfDS = getDataSet(idfQuery);
            DataSet ppDS = getDataSet(ppQuery);
            DataSet pppDS = getDataSet(ppPortQuery);
            DataSet phoneDS = getDataSet(phoneQuery);

            try
            {
                foreach (DataRow dr in venDS.Tables[0].Rows)
                {
                    Venue venue = new Venue();
                    venue.venueID = (int)dr.ItemArray.GetValue(0);
                    venue.venueName = dr.ItemArray.GetValue(1).ToString();
                    venueList.Add(venue);
                }
                foreach (DataRow dr in vsDS.Tables[0].Rows)
                {
                    VenueSpace venueSpace = new VenueSpace();
                    venueSpace.venueSpaceID = (int)dr.ItemArray.GetValue(0);
                    venueSpace.venueSpaceName = dr.ItemArray.GetValue(1).ToString();
                    venueSpace.venueID = (int)dr.ItemArray.GetValue(2);
                    venueSpaceList.Add(venueSpace);
                }
                foreach (DataRow dr in idfDS.Tables[0].Rows)
                {
                    IDF idf = new IDF();
                    idf.idfID = (int)dr.ItemArray.GetValue(0);
                    idf.idfName = dr.ItemArray.GetValue(1).ToString();
                    idf.venueSpaceID = (int)dr.ItemArray.GetValue(2);
                    idfList.Add(idf);
                }

                foreach (DataRow dr in ppDS.Tables[0].Rows)
                {
                    PatchPanel pp = new PatchPanel();
                    pp.patchPanelID = (int)dr.ItemArray.GetValue(0);
                    pp.patchPanelName = dr.ItemArray.GetValue(1).ToString();
                    pp.idfID = (int)dr.ItemArray.GetValue(2);
                    PPList.Add(pp);
                }

                foreach (DataRow dr in pppDS.Tables[0].Rows)
                {
                    PatchPanelPort ppp = new PatchPanelPort();
                    ppp.patchPanelPortID = (int)dr.ItemArray.GetValue(0);
                    ppp.patchPanelPortNum = (int)dr.ItemArray.GetValue(1);
                    ppp.patchPanelID = (int)dr.ItemArray.GetValue(2);
                    PPPList.Add(ppp);
                }

                foreach (DataRow dr in phoneDS.Tables[0].Rows)
                {
                    Phone ph = new Phone();
                    ph.phoneID = (int)dr.ItemArray.GetValue(0);
                    ph.mac = dr.ItemArray.GetValue(1).ToString();
                    ph.isRegistered = dr.ItemArray.GetValue(2).ToString();
                    phoneList.Add(ph);
                }

            }
            catch (OleDbException exp)
            {
                MessageBox.Show("Database Error:" + exp.Message.ToString());
            }

            updateVenueBoxList(venueList);
            updateDataGridView();
        }

        public DataSet getDataSet(string query)
        {
            mf.dbConnect();

            OleDbDataAdapter da = new OleDbDataAdapter(query, MainForm.dbConnection.conn);
            DataSet ds = new DataSet();

            if (MainForm.connected)
            {
                try
                {
                    da.Fill(ds);
                }
                catch (OleDbException exp)
                {
                    MessageBox.Show("Database Error:" + exp.Message.ToString());
                }
            }
            mf.dbClose();

            return ds;
        }

        private void venueBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<VenueSpace> vsFilteredList = new List<VenueSpace>();

            foreach (Venue v in venueList)
            {
                if (v.venueName == venueBox.SelectedValue.ToString())
                {
                    fs.ven = v; //add to FormSelection object
                }
            }

            if (venueBox.SelectedValue.ToString() != "")
            {
                venueSpaceBox.Enabled = true;

                foreach (VenueSpace vs in venueSpaceList)
                {
                    if (vs.venueID == fs.ven.venueID)
                    {
                        vsFilteredList.Add(vs); //relevant list of venue spaces
                    }
                }

                updateVenueSpaceBoxList(vsFilteredList);

                updateFormControls("venue");
            }
            else
            {
                venueSpaceBox.Enabled = false;
            }
        }

        private void venueSpaceBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<IDF> idfFilteredList = new List<IDF>();

            foreach (VenueSpace vs in venueSpaceList)
            {
                if (vs.venueSpaceName == venueSpaceBox.SelectedValue.ToString())
                {
                    fs.vs = vs; //add to FormSelection object
                }
            }

            if (venueSpaceBox.SelectedValue.ToString() != "")
            {
                foreach (IDF idf in idfList)
                {
                    if (idf.venueSpaceID == fs.vs.venueSpaceID)
                    {
                        idfFilteredList.Add(idf); //relevant list of venue spaces
                    }
                }

                updateIDFBoxList(idfFilteredList);

                updateFormControls("venueSpace");

                idfBox.Enabled = true;
            }
            else
            {
                idfBox.Enabled = false;
            }
        }

        private void idfBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<PatchPanel> patchPanelFilteredList = new List<PatchPanel>();

            foreach (IDF idf in idfList)
            {
                if (idf.idfName == idfBox.SelectedValue.ToString())
                {
                    fs.idf = idf; //add to FormSelection object
                }
            }

            if (idfBox.SelectedValue.ToString() != "")
            {
                foreach (PatchPanel pp in PPList)
                {
                    if (pp.idfID == fs.idf.idfID)
                    {
                        patchPanelFilteredList.Add(pp); //relevant list of venue spaces
                    }
                }
                updateppComboBoxList(patchPanelFilteredList);

                updateFormControls("idf");

                ppComboBox.Enabled = true;
            }
            else
            {
                ppComboBox.Enabled = false;
                PPPortComboBox.Enabled = false;
            }
        }        

        private void ppComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<PatchPanelPort> patchPanelPortFilteredList = new List<PatchPanelPort>();

            foreach (PatchPanel pp in PPList)
            {
                if (pp.patchPanelName == ppComboBox.SelectedValue.ToString())
                {
                    fs.pp = pp; //add to FormSelection object
                }
            }

            if (ppComboBox.SelectedValue.ToString() != "")
            {
                foreach (PatchPanelPort ppp in PPPList)
                {
                    if (ppp.patchPanelID == fs.pp.patchPanelID)
                    {
                        patchPanelPortFilteredList.Add(ppp); //relevant list of venue spaces
                    }
                }

                updatePatchPanelPortBoxList(patchPanelPortFilteredList);
                //HERE add selected port object to fs.

                PPPortComboBox.Enabled = true;
            }
            else
            {
                PPPortComboBox.Enabled = false;
            }
        }

        public void updateFormControls(string cbUpdated)
        {
            List<string> emptyList = new List<string>();

            switch (cbUpdated)
            {
                case "ALL":
                    {
                        venueBox.SelectedIndex = 0;
                        venueSpaceBox.DataSource = emptyList;
                        idfBox.DataSource = emptyList;
                        ppComboBox.DataSource = emptyList;
                        PPPortComboBox.DataSource = emptyList;

                        venueSpaceBox.Enabled = false;
                        idfBox.Enabled = false;
                        ppComboBox.Enabled = false;
                        PPPortComboBox.Enabled = false;
                        break;
                    }

                case "venue":
                    {
                        idfBox.DataSource = emptyList;
                        ppComboBox.DataSource = emptyList;
                        PPPortComboBox.DataSource = emptyList;

                        idfBox.Enabled = false;
                        ppComboBox.Enabled = false;
                        PPPortComboBox.Enabled = false;
                    }
                    break;

                case "venueSpace":
                    {
                        ppComboBox.DataSource = emptyList;
                        PPPortComboBox.DataSource = emptyList;

                        ppComboBox.Enabled = false;
                        PPPortComboBox.Enabled = false;
                    }
                    break;

                case "idf":
                    {
                        PPPortComboBox.DataSource = emptyList;

                        PPPortComboBox.Enabled = false;
                    }
                    break;

                default:
                    break;
            }
        }

        public void updateVenueBoxList(List<Venue> v)
        {
            List<string> venueNameList = new List<string>();
            venueNameList.Add("");

            foreach (Venue ven in venueList)
            {
                venueNameList.Add(ven.venueName);
            }
            venueBox.DataSource = venueNameList;
        }

        public void updateVenueSpaceBoxList(List<VenueSpace> vsFilteredList)
        {
            List<string> vsNameList = new List<string>();
            vsNameList.Add("");

            foreach (VenueSpace vs in vsFilteredList)
            {
                vsNameList.Add(vs.venueSpaceName);
            }
            venueSpaceBox.DataSource = vsNameList;
        }

        public void updateIDFBoxList(List<IDF> idfFilteredList)
        {
            List<string> idfNameList = new List<string>();
            idfNameList.Add("");

            foreach (IDF idf in idfFilteredList)
            {
                idfNameList.Add(idf.idfName);
            }
            idfBox.DataSource = idfNameList;
        }
              
        public void updateppComboBoxList(List<PatchPanel> patchPanelFilteredList)
        {
            List<string> patchPanelNameList = new List<string>();
            patchPanelNameList.Add("");

            foreach (PatchPanel pp in patchPanelFilteredList)
            {
                patchPanelNameList.Add(pp.patchPanelName);
            }
            ppComboBox.DataSource = patchPanelNameList;
        }
              
        public void updatePatchPanelPortBoxList(List<PatchPanelPort> patchPanelPortFilteredList)
        {
            List<string> patchPanelPortNumList = new List<string>();
            List<int> patchPanelPortNumListToInt = new List<int>();

            fs.pppFilteredList = patchPanelPortFilteredList;

            foreach (PatchPanelPort ppp in patchPanelPortFilteredList)
            {
                patchPanelPortNumListToInt.Add(ppp.patchPanelPortNum);
            }

            patchPanelPortNumListToInt.Sort();
            patchPanelPortNumList = patchPanelPortNumListToInt.ConvertAll<string>(x => x.ToString());

            PPPortComboBox.DataSource = patchPanelPortNumList;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            updateFormControls("ALL");
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (selMacComboBox.SelectedValue.ToString() != "" && selJackBox.Text != "")
            {
                // get phoneID from MAC
                // get jackID from patchPanelPortID in OfficeJack Table
                string insertQuery = "INSERT INTO [PhoneOfficeJack] (PhoneOfficeJackID, JackID, PhoneID) VALUES ();";


                OleDbCommand updateSwitchPortDA = new OleDbCommand(updateSwitchPortQuery, MainForm.dbConnection.conn);
                OleDbCommand updatePatchPanelPortDA = new OleDbCommand(updatePatchPanelPortQuery, MainForm.dbConnection.conn);

                if (MainForm.connected)
                {
                    try
                    {
                        var x = updateSwitchPortDA.ExecuteNonQuery();
                        var y = updatePatchPanelPortDA.ExecuteNonQuery();

                        ppComboBox.SelectedIndex = 0;

                        connectedLabel.Visible = true;
                        timer1.Start();
                    }
                    catch (OleDbException exp)
                    {
                        MessageBox.Show("Database Error:" + exp.Message.ToString());
                    }
                }

                refreshPortLists();
                updateDataGridView();
            }
        }

        private void switchPortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (SwitchPort swp in fs.swpFilteredList)
            {
                if (swp.switchPortNum.ToString() == switchPortBox.SelectedValue.ToString())
                {
                    fs.swp = swp; //add to FormSelection object
                }
            }
        }

        private void PPPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (PatchPanelPort ppp in fs.pppFilteredList)
            {
                if (ppp.patchPanelPortNum.ToString() == PPPortComboBox.SelectedValue.ToString())
                {
                    fs.ppp = ppp; //add to FormSelection object
                }
            }
        }

        private void refreshPortLists()
        {
            string ppPortQuery = "SELECT PatchPanelPort.PatchPanelPortID, PatchPanelPort.PatchPanelPortNum, PatchPanelPort.PatchPanelID FROM [PatchPanelPort] WHERE PatchPanelPort.SwitchPortID IS NULL;";
            string switchPortQuery = "SELECT SwitchPort.SwitchPortID, SwitchPort.SwitchPortNum, SwitchPort.SwitchID FROM [SwitchPort] WHERE SwitchPort.PatchPanelPortID IS NULL;";
            DataSet swpDS = getDataSet(switchPortQuery);
            DataSet pppDS = getDataSet(ppPortQuery);

            List<SwitchPort> newSwitchPortList = new List<SwitchPort>();
            List<PatchPanelPort> newPatchPanelPortList = new List<PatchPanelPort>();

            try
            {
                foreach (DataRow dr in swpDS.Tables[0].Rows)
                {
                    SwitchPort swp = new SwitchPort();
                    swp.switchPortID = (int)dr.ItemArray.GetValue(0);
                    swp.switchPortNum = (int)dr.ItemArray.GetValue(1);
                    swp.switchID = (int)dr.ItemArray.GetValue(2);
                    newSwitchPortList.Add(swp);
                }
                foreach (DataRow dr in pppDS.Tables[0].Rows)
                {
                    PatchPanelPort ppp = new PatchPanelPort();
                    ppp.patchPanelPortID = (int)dr.ItemArray.GetValue(0);
                    ppp.patchPanelPortNum = (int)dr.ItemArray.GetValue(1);
                    ppp.patchPanelID = (int)dr.ItemArray.GetValue(2);
                    newPatchPanelPortList.Add(ppp);
                }

                switchPortList = newSwitchPortList;
                PPPList = newPatchPanelPortList;
            }
            catch (OleDbException exp)
            {
                MessageBox.Show("Database Error:" + exp.Message.ToString());
            }
        }

        private void updateDataGridView()
        {
            string query = "SELECT Switch.DNSName, SwitchPort.SwitchPortNum, PatchPanelPort.PatchPanelPortNum, PatchPanel.PatchPanelName FROM [Switch], [SwitchPort], [PatchPanel], [PatchPanelPort] WHERE Switch.IDFID = PatchPanel.IDFID AND Switch.SwitchID = SwitchPort.SwitchID AND PatchPanel.PatchPanelID = PatchPanelPort.PatchPanelID AND SwitchPort.SwitchPortID = PatchPanelPort.SwitchPortID AND PatchPanelPort.PatchPanelPortID = SwitchPort.PatchPanelPortID AND SwitchPort.SwitchPortID IS NOT NULL AND PatchPanelPort.PatchPanelPortID IS NOT NULL;";

            DataSet ds = getDataSet(query);

            PatchToSwitchDataGridView.DataSource = ds.Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            connectLabel.Visible = false;

            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                timer1.Stop();
                connectedLabel.Visible = false;
                connectLabel.Visible = true;
            }
        }

        private void PatchToSwitchDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contextMenuStrip1.Items.Clear();

            string switchDNSName = PatchToSwitchDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string query = "SELECT Venue.VenueName, VenueSpace.VenueSpaceName, IDF.IDFName FROM [Venue], [VenueSpace], [IDF], [Switch] WHERE IDF.VenueSpaceID = VenueSpace.VenueSpaceID AND VenueSpace.VenueID = Venue.VenueID AND Switch.DNSName = " + "'" + switchDNSName + "'" + " AND Switch.IDFID = IDF.IDFID;";
            string venueName = "", venueSpaceName = "", idfName = "";

            DataSet ds = getDataSet(query);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                venueName = dr.ItemArray.GetValue(0).ToString();
                venueSpaceName = dr.ItemArray.GetValue(1).ToString();
                idfName = dr.ItemArray.GetValue(2).ToString();
            }

            contextMenuStrip1.Items.Add(venueName);
            contextMenuStrip1.Items.Add(venueSpaceName);
            contextMenuStrip1.Items.Add(idfName);

            contextMenuStrip1.Show(Cursor.Position);
        }
    }




}

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
    public partial class PatchToSwitchForm : Form
    {        
        public class FormSelection
        {
            public Venue ven;
            public VenueSpace vs;
            public IDF idf;
            public Switch sw;
            public int switchPort;
            public PatchPanel pp;
            public int patchPanelPort;
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

        public class Switch
        {
            public int switchID;
            public string switchNameDNS;
            public int idfID;
            public List<int> switchPortsOpen = new List<int>();
        }

        public class PatchPanel
        {
            public int patchPanelID;
            public string patchPanelName;
            public int idfID;
            public List<int> patchPanelPortsOpen = new List<int>();
        }

        public class SwitchPort
        {
            public int switchPortID;
            public int switchPortNum;
            public int switchID;
        }

        public class PatchPanelPort
        {
            public int patchPanelPortID;
            public int patchPanelPortNum;
            public int patchPanelID;
        }

        private MainForm mf;
        public FormSelection fs = new FormSelection();

        List<Venue> venueList = new List<Venue>();
        List<VenueSpace> venueSpaceList = new List<VenueSpace>();
        List<IDF> idfList = new List<IDF>();
        List<PatchPanel> PPList = new List<PatchPanel>();
        List<Switch> switchList = new List<Switch>();
        List<SwitchPort> switchPortList = new List<SwitchPort>();
        List<PatchPanelPort> PPPList = new List<PatchPanelPort>();

        public PatchToSwitchForm(MainForm mainForm)
        {            
            InitializeComponent();
            mf = mainForm;
        }

        private void Form2_Load(object sender, EventArgs e) //load venues into combobox
        {
            string venueQuery = "SELECT Venue.VenueID, Venue.VenueName FROM [Venue];";
            string venueSpaceQuery = "SELECT VenueSpace.VenueSpaceID, VenueSpace.VenueSpaceName, VenueSpace.VenueID FROM [VenueSpace];";
            string idfQuery = "SELECT IDF.IDFID, IDF.IDFName, IDF.VenueSpaceID FROM [IDF];";
            string ppQuery = "SELECT PatchPanel.PatchPanelID, PatchPanel.PatchPanelName, PatchPanel.IDFID FROM [PatchPanel];";
            string switchQuery = "SELECT Switch.SwitchID, Switch.DNSName, Switch.IDFID FROM [Switch];";
            string ppPortQuery = "SELECT PatchPanelPort.PatchPanelPortID, PatchPanelPort.PatchPanelPortNum, PatchPanelPort.PatchPanelID FROM [PatchPanelPort];";
            string switchPortQuery = "SELECT SwitchPort.SwitchPortID, SwitchPort.SwitchPortNum, SwitchPort.SwitchID FROM [SwitchPort];";

            DataSet venDS = getDataSet(venueQuery);
            DataSet vsDS = getDataSet(venueSpaceQuery);
            DataSet idfDS = getDataSet(idfQuery);
            DataSet swDS = getDataSet(switchQuery);
            DataSet ppDS = getDataSet(ppQuery);
            DataSet swpDS = getDataSet(switchPortQuery);
            DataSet pppDS = getDataSet(ppPortQuery);

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
                foreach (DataRow dr in swDS.Tables[0].Rows)
                {
                    Switch sw = new Switch();
                    sw.switchID = (int)dr.ItemArray.GetValue(0);
                    sw.switchNameDNS = dr.ItemArray.GetValue(1).ToString();
                    sw.idfID = (int)dr.ItemArray.GetValue(2);                    
                    switchList.Add(sw);
                }
                foreach (DataRow dr in ppDS.Tables[0].Rows)
                {
                    PatchPanel pp = new PatchPanel();
                    pp.patchPanelID = (int)dr.ItemArray.GetValue(0);
                    pp.patchPanelName = dr.ItemArray.GetValue(1).ToString();
                    pp.idfID = (int)dr.ItemArray.GetValue(2);
                    PPList.Add(pp);
                }
                foreach (DataRow dr in swpDS.Tables[0].Rows)
                {
                    SwitchPort swp = new SwitchPort();
                    swp.switchPortID = (int)dr.ItemArray.GetValue(0);
                    swp.switchPortNum = (int)dr.ItemArray.GetValue(1);
                    swp.switchID = (int)dr.ItemArray.GetValue(2);
                    switchPortList.Add(swp);
                }
                foreach (DataRow dr in pppDS.Tables[0].Rows)
                {
                    PatchPanelPort ppp = new PatchPanelPort();
                    ppp.patchPanelPortID = (int)dr.ItemArray.GetValue(0);
                    ppp.patchPanelPortNum = (int)dr.ItemArray.GetValue(1);
                    ppp.patchPanelID = (int)dr.ItemArray.GetValue(2);
                    PPPList.Add(ppp);
                }

            }
            catch (OleDbException exp)
            {
                MessageBox.Show("Database Error:" + exp.Message.ToString());
            }

            updateVenueBoxList(venueList);
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
            List<Switch> switchFilteredList = new List<Switch>();
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
                foreach (Switch sw in switchList)
                {
                    if (sw.idfID == fs.idf.idfID)
                    {
                        switchFilteredList.Add(sw); //relevant list of venue spaces
                    }
                }

                foreach (PatchPanel pp in PPList)
                {
                    if (pp.idfID == fs.idf.idfID)
                    {
                        patchPanelFilteredList.Add(pp); //relevant list of venue spaces
                    }
                }
                updateSwitchBoxList(switchFilteredList);
                updatePatchPanelBoxList(patchPanelFilteredList);

                updateFormControls("idf");

                switchBox.Enabled = true;
                patchPanelBox.Enabled = true;
            }
            else
            {
                switchBox.Enabled = false;
                patchPanelBox.Enabled = false;
                switchPortBox.Enabled = false;
                PPPortBox.Enabled = false;
            }
        }

        private void switchBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<SwitchPort> switchPortFilteredList = new List<SwitchPort>();

            foreach (Switch sw in switchList)
            {
                if (sw.switchNameDNS == switchBox.SelectedValue.ToString())
                {
                    fs.sw = sw; //add to FormSelection object
                }
            }

            foreach (SwitchPort swp in switchPortList)
            {
                if (swp.switchID == fs.sw.switchID)
                {
                    switchPortFilteredList.Add(swp); //relevant list of venue spaces
                }
            }

            updateSwitchPortBoxList(switchPortFilteredList);

            switchPortBox.Enabled = true;

            //if (switchBox.SelectedValue.ToString() != "")
            //{

            //}
            //else
            //{
            //    switchBox.Enabled = false;
            //    patchPanelBox.Enabled = false;
            //    switchPortBox.Enabled = false;
            //    PPPortBox.Enabled = false;
            //}
        }

        private void patchPanelBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<PatchPanelPort> patchPanelPortFilteredList = new List<PatchPanelPort>();

            foreach (PatchPanel pp in PPList)
            {
                if (pp.patchPanelName == patchPanelBox.SelectedValue.ToString())
                {
                    fs.pp = pp; //add to FormSelection object
                }
            }

            foreach (PatchPanelPort ppp in PPPList)
            {
                if (ppp.patchPanelID == fs.pp.patchPanelID)
                {
                    patchPanelPortFilteredList.Add(ppp); //relevant list of venue spaces
                }
            }

            updatePatchPanelPortBoxList(patchPanelPortFilteredList);

            PPPortBox.Enabled = true;

            //if (patchPanelBox.SelectedValue.ToString() != "")
            //{

            //}
            //else
            //{
            //    switchBox.Enabled = false;
            //    patchPanelBox.Enabled = false;
            //    switchPortBox.Enabled = false;
            //    PPPortBox.Enabled = false;
            //}
        }

        public void updateFormControls(string cbUpdated)
        {
            List<string> emptyList = new List<string>();

            switch (cbUpdated)
            {
                case "venue":
                    {
                        idfBox.DataSource = emptyList;
                        switchBox.DataSource = emptyList;
                        patchPanelBox.DataSource = emptyList;
                        switchPortBox.DataSource = emptyList;
                        PPPortBox.DataSource = emptyList;

                        idfBox.Enabled = false;
                        switchBox.Enabled = false;
                        patchPanelBox.Enabled = false;
                        switchPortBox.Enabled = false;
                        PPPortBox.Enabled = false;
                    }
                    break;

                case "venueSpace":
                    {
                        switchBox.DataSource = emptyList;
                        patchPanelBox.DataSource = emptyList;
                        switchPortBox.DataSource = emptyList;
                        PPPortBox.DataSource = emptyList;

                        switchBox.Enabled = false;
                        patchPanelBox.Enabled = false;
                        switchPortBox.Enabled = false;
                        PPPortBox.Enabled = false;
                    }
                    break;

                case "idf":
                    {
                        switchPortBox.DataSource = emptyList;
                        PPPortBox.DataSource = emptyList;

                        switchPortBox.Enabled = false;
                        PPPortBox.Enabled = false;
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

        public void updateSwitchBoxList(List<Switch> switchFilteredList)
        {
            List<string> switchNameList = new List<string>();

            foreach (Switch sw in switchFilteredList)
            {
                switchNameList.Add(sw.switchNameDNS);
            }
            switchBox.DataSource = switchNameList;
        }

        public void updatePatchPanelBoxList(List<PatchPanel> patchPanelFilteredList)
        {
            List<string> patchPanelNameList = new List<string>();

            foreach (PatchPanel pp in patchPanelFilteredList)
            {
                patchPanelNameList.Add(pp.patchPanelName);
            }
            patchPanelBox.DataSource = patchPanelNameList;
        }

        public void updateSwitchPortBoxList(List<SwitchPort> switchPortFilteredList)
        {
            List<string> switchPortNumList = new List<string>();

            foreach (SwitchPort swp in switchPortFilteredList)
            {
                switchPortNumList.Add(swp.switchPortNum.ToString());
            }
            switchPortBox.DataSource = switchPortNumList;
        }

        public void updatePatchPanelPortBoxList(List<PatchPanelPort> patchPanelPortFilteredList)
        {
            List<string> patchPanelPortNumList = new List<string>();

            foreach (PatchPanelPort ppp in patchPanelPortFilteredList)
            {
                patchPanelPortNumList.Add(ppp.patchPanelPortNum.ToString());
            }
            PPPortBox.DataSource = patchPanelPortNumList;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
        }

        
    }    
}

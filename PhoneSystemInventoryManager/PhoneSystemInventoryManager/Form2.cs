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
            List<int> switchPortsOpen = new List<int>();
        }

        public class PatchPanel
        {
            public int patchPanelID;
            public string patchPanelName;
            List<int> patchPanelPortsOpen = new List<int>();
        }

        private MainForm mf;
        public FormSelection fs = new FormSelection();

        
        List<string> PPBoxList = new List<string>();
        List<string> switchBoxList = new List<string>();

        List<Venue> venueList = new List<Venue>();
        List<VenueSpace> venueSpaceList = new List<VenueSpace>();
        List<IDF> idfList = new List<IDF>();
        List<PatchPanel> PPList = new List<PatchPanel>();
        List<Switch> switchList = new List<Switch>();

        string venueQuery = "SELECT Venue.VenueID, Venue.VenueName FROM [Venue];";
        string venueSpaceQuery = "SELECT VenueSpace.VenueSpaceID, VenueSpace.VenueSpaceName, VenueSpace.VenueID FROM [VenueSpace];";
        string idfQuery = "SELECT IDF.IDFID, IDF.IDFName, IDF.VenueSpaceID FROM [IDF];";
        string ppQuery;
        string switchQuery;
        string ppPortQuery;
        string switchPortQuery;

        public PatchToSwitchForm(MainForm mainForm)
        {            
            InitializeComponent();
            mf = mainForm;
        }

        private void Form2_Load(object sender, EventArgs e) //load venues into combobox
        {
            loadForm();
        }

        private void loadForm()
        {
            mf.dbConnect();

            if (MainForm.connected)
            {
                List<string> venueBoxList = new List<string>();

                OleDbDataAdapter VenDA = new OleDbDataAdapter(venueQuery, MainForm.dbConnection.conn);
                DataSet VenDS = new DataSet();

                try
                {
                    venueBoxList.Add("");
                    VenDA.Fill(VenDS);
                    foreach (DataRow dr in VenDS.Tables[0].Rows)
                    {
                        Venue venue = new Venue();
                        venue.venueID = (int)dr.ItemArray.GetValue(0);
                        venue.venueName = dr.ItemArray.GetValue(1).ToString();
                        venueList.Add(venue);
                        venueBoxList.Add(venue.venueName);
                    }

                    venueBox.DataSource = venueBoxList;      

                    mf.dbClose();
                }
                catch (OleDbException exp)
                {
                    MessageBox.Show("Database Error:" + exp.Message.ToString());
                }
            }
        }

        private void venueBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter VenSpaceDA = new OleDbDataAdapter(venueSpaceQuery, MainForm.dbConnection.conn);
            DataSet VenSpaDS = new DataSet();

            VenSpaceDA.Fill(VenSpaDS);
            foreach (DataRow dr in VenSpaDS.Tables[0].Rows)
            {
                VenueSpace venueSpace = new VenueSpace();
                venueSpace.venueSpaceID = (int)dr.ItemArray.GetValue(0);
                venueSpace.venueSpaceName = dr.ItemArray.GetValue(1).ToString();
                venueSpace.venueID = (int)dr.ItemArray.GetValue(2);
                venueSpaceList.Add(venueSpace);
            }

            List<VenueSpace> vsList = new List<VenueSpace>();
            List<string> venueSpaceBoxList = new List<string>();

            if (venueBox.SelectedValue.ToString() != "")
            {
                venueSpaceBox.Enabled = true;

                foreach (Venue v in venueList)
                {
                    if (v.venueName == venueBox.SelectedValue.ToString())
                    {
                        fs.ven = v; //add to FormSelection object
                    }
                }

                mf.dbConnect();

                if (MainForm.connected)
                {
                    venueSpaceBoxList.Add("");

                    foreach (VenueSpace vs in venueSpaceList)
                    {
                        if (vs.venueID == fs.ven.venueID)
                        {
                            vsList.Add(vs); //relevant list of venue spaces
                            venueSpaceBoxList.Add(vs.venueSpaceName); //create list for combobox
                        }
                    }

                    venueSpaceList = vsList;
                    venueSpaceBox.DataSource = venueSpaceBoxList; //bind to combobox
                }

                mf.dbClose();
            }
            else
            {
                venueSpaceBox.Enabled = false;
            }
        }

        private void venueSpaceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter IDFDA = new OleDbDataAdapter(idfQuery, MainForm.dbConnection.conn);
            DataSet IDFDS = new DataSet();

            IDFDA.Fill(IDFDS);
            foreach (DataRow dr in IDFDS.Tables[0].Rows)
            {
                IDF idf = new IDF();
                idf.idfID = (int)dr.ItemArray.GetValue(0);
                idf.idfName = dr.ItemArray.GetValue(1).ToString();
                idf.venueSpaceID = (int)dr.ItemArray.GetValue(2);
                idfList.Add(idf);
            }

            List<IDF> _idfList = new List<IDF>();
            List<string> idfBoxList = new List<string>();

            if (venueSpaceBox.SelectedValue.ToString() != "")
            {
                idfBox.Enabled = true;

                foreach (VenueSpace vs in venueSpaceList)
                {
                    if (vs.venueSpaceName == venueSpaceBox.SelectedValue.ToString())
                    {
                        fs.vs = vs; //add to FormSelection object
                    }
                }

                mf.dbConnect();

                if (MainForm.connected)
                {
                    idfBoxList.Add("");

                    foreach (IDF idf in idfList)
                    {
                        if (idf.venueSpaceID == fs.vs.venueSpaceID)
                        {
                            _idfList.Add(idf); //relevant list of venue spaces
                            idfBoxList.Add(idf.idfName); //create list for combobox
                        }
                    }

                    idfList = _idfList;
                    idfBox.DataSource = idfBoxList; //bind to combobox
                }

                mf.dbClose();
            }
            else
            {
                idfBox.Enabled = false;
            }
        }
    }    
}

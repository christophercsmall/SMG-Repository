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

        List<Venue> venueList = new List<Venue>();
        List<VenueSpace> venueSpaceList = new List<VenueSpace>();
        List<IDF> idfList = new List<IDF>();
        List<PatchPanel> PPList = new List<PatchPanel>();
        List<Switch> switchList = new List<Switch>();

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
            string ppQuery;
            string switchQuery;
            string ppPortQuery;
            string switchPortQuery;

            DataSet venDS = getDataSet(venueQuery);
            DataSet vsDS = getDataSet(venueSpaceQuery);
            DataSet idfDS = getDataSet(idfQuery);

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

        private void venueBox_SelectedIndexChanged(object sender, EventArgs e)
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
            }
            else
            {                
                venueSpaceBox.Enabled = false;
            }
        }
        
        private void venueSpaceBox_SelectedIndexChanged(object sender, EventArgs e)
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
                idfBox.Enabled = true;

                foreach (IDF idf in idfList)
                {
                    if (idf.venueSpaceID == fs.vs.venueSpaceID)
                    {
                        idfFilteredList.Add(idf); //relevant list of venue spaces
                    }
                }

                updateIDFBoxList(idfFilteredList);
            }
            else
            {
                idfBox.Enabled = false;
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
    }    
}

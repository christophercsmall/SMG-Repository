using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneSystemInventoryManager
{
    public partial class CreateForm : Form
    {
        private MainForm mf;
        private object sndr;
        private int currentTabIndex;
        private bool errorsPending = true;

        public CreateForm(MainForm mainform, object sender)
        {
            InitializeComponent();
            mf = mainform;
            sndr = sender;            

            switch (sndr.ToString())
            {
                case "User":
                    {                        
                        createTabControl.SelectTab(0);
                        currentTabIndex = 0;                 
                        break;
                    }
                case "Phone":
                    {
                        createTabControl.SelectTab(1);
                        currentTabIndex = 1;
                        break;
                    }
                case "OfficeJack":
                    {
                        createTabControl.SelectTab(2);
                        currentTabIndex = 2;
                        break;
                    }
                default:
                    {                       
                        break;
                    }
            }

            openTab(currentTabIndex);
        }

        private void createTabControl_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void createTabControl_Selected(object sender, TabControlEventArgs e)
        {
            currentTabIndex = createTabControl.SelectedIndex;
            openTab(currentTabIndex);
        }


        private void openTab(int tabIndex)
        {
            //clearTabs();

            switch (tabIndex)
            {
                case 0:
                    loadUserTab();
                    break;
                case 1:
                    loadPhoneTab();
                    break;
                case 2:
                    loadOfficeJackTab();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                default:
                    break;
            }
        }

        private int getUnusedID(string idQuery)
        {
            int newID = 0, i = 0;
            List<int> idList = new List<int>();

            DataSet ds = getDataSet(idQuery);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                idList.Add((int)dr.ItemArray.GetValue(0));
            }
            idList.Sort();

            while (idList.Contains(i))
            {
                i++;
            }
            newID = i;

            return newID;
        }

        public static string removeSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
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

        private void executeDbComm(string query)
        {
            mf.dbConnect();

            OleDbCommand executeDbComm = new OleDbCommand(query, MainForm.dbConnection.conn);

            if (MainForm.connected)
            {
                try
                {
                    var x = executeDbComm.ExecuteNonQuery();                   
                }
                catch (OleDbException exp)
                {
                    MessageBox.Show("Database Error:" + exp.Message.ToString());
                }
            }
            mf.dbClose();
        }

        

//startUserTab
        private void loadUserTab() 
        {
            List<string> extNums = new List<string>();

            string userQuery = "SELECT User.LName, User.FName, User.Company, User.Department, User.ExtensionNum FROM [User];";

            DataSet ds = getDataSet(userQuery);

            createDataGridView.DataSource = ds.Tables[0];

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                extNums.Add(dr.ItemArray.GetValue(4).ToString());
            }
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            string userIdQuery = "SELECT User.UserID FROM [User];";
            int newUserID = getUnusedID(userIdQuery);
            string insertQuery = "INSERT INTO [User] (UserID, FName, LName, Company, Department, ExtensionNum) VALUES (" + newUserID + ", '" + fNameBox.Text + "'" + ", '" + lNameBox.Text + "'" + ", '" + compBox.Text + "'" + ", '" + depBox.Text + "'" + ", " + extBox.Text + ");";
            
            if (extBox.Text == "")
            {
                errorProvider1.SetError(extBox, "User records require valid Extension Number");
                errorsPending = true;
            }
            else
            {
                if (errorsPending)
                {
                    MessageBox.Show("Pending errors must be resolved.");
                }
                else
                {
                    executeDbComm(insertQuery);
                    loadUserTab();
                }
            }
        }

        private void extBox_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(extBox, string.Empty);
            errorsPending = false;

            if (extentionExists(extBox.Text))
            {
                errorProvider1.SetError(extBox, "Extenion already assigned.");
                errorsPending = true;
            }

            if (!extBox.Text.All(Char.IsDigit))
            {
                errorProvider1.SetError(extBox, "Extension must be 4 digit number.");
                errorsPending = true;
            }

        }

        private bool extentionExists(string ext)
        {
            bool isValid = false;

            List<string> extNums = new List<string>();

            string extQuery = "SELECT User.ExtensionNum FROM [User];";

            DataSet ds = getDataSet(extQuery);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                extNums.Add(dr.ItemArray.GetValue(0).ToString());
            }

            foreach (string n in extNums)
            {
                if (n.ToString() == ext)
                {
                    isValid = true;
                }
            }

            return isValid;
        }
        //endUserTab

//beginPhoneTab
        private void loadPhoneTab()
        {
            List<string> users = new List<string>();
            List<string> phoneTypes = new List<string>();
            List<string> distinctTypes = new List<string>();

            string phoneQuery = "SELECT Phone.MAC, Phone.Type, Phone.Registered, Phone.JackInfo FROM [Phone];";

            DataSet phoneDS = getDataSet(phoneQuery);

            createDataGridView.DataSource = phoneDS.Tables[0];

            foreach (DataRow dr in phoneDS.Tables[0].Rows)
            {
                phoneTypes.Add(dr.ItemArray.GetValue(1).ToString());
            }

            //foreach (DataRow dr in UserDS.Tables[0].Rows)
            //{
            //    users.Add(dr.ItemArray.GetValue(0).ToString() + ", " + dr.ItemArray.GetValue(1).ToString() + " - " + dr.ItemArray.GetValue(2).ToString());
            //}

            distinctTypes.AddRange(phoneTypes.Distinct());
            distinctTypes.Sort();
            distinctTypes.Insert(0, "");
            typeComboBox.DataSource = distinctTypes;
        }

        private void macBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(macBox, string.Empty);

            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void createPhoneBtn_Click(object sender, EventArgs e)
        {
            string mac = macBox.Text;
            string type = typeComboBox.Text;
            string registered = regComboBox.Text;
            string jackInfo = jackBox.Text;
            bool reg = false;

            string phoneIdQuery = "SELECT Phone.PhoneID FROM [Phone];";
            int newphoneID = getUnusedID(phoneIdQuery);
            string insertQuery = "INSERT INTO [Phone] (PhoneID, MAC, Type, Registered, JackInfo) VALUES (" + newphoneID + ", '" + mac + "'" + ", '" + type + "'" + ", '" + reg + "'" + ", '" + jackInfo + "'" + ");";

            bool isValid = phoneTabValid(mac, registered, type);
            jackInfo = removeSpecialCharacters(jackInfo);          

            if (isValid && !errorsPending)
            {
                executeDbComm(insertQuery);
            }
            else
            {
                MessageBox.Show("Pending errors must be resolved.");
            }           
        }

        private void regComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(regComboBox, string.Empty);

        }

        private bool phoneTabValid(string mac, string registered, string type)
        {
            errorsPending = false;
            bool macValid, regValid, typeValid, isValid = false;

            mac = removeSpecialCharacters(mac);
            type = removeSpecialCharacters(type);

            if (mac == "" || mac.Length < 12)
            {
                macValid = false;
                errorProvider1.SetError(macBox, "MAC must contain 12 alphanumeric characters.");
                errorsPending = true;
            }
            else
            {                
                macValid = true;
            }

            if (registered != "YES" && registered != "NO")
            {
                regValid = false;
                errorProvider1.SetError(regComboBox, "Registered field must be YES or NO.");
                errorsPending = true;
            }
            else
            {
                regValid = true;
            }

            if (type == "")
            {
                typeValid = false;
                errorProvider1.SetError(typeComboBox, "Phone Type field cannot be empty.");
                errorsPending = true;
            }
            else
            {
                typeValid = true;
            }           

            if (macValid && regValid && typeValid && !errorsPending)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(typeComboBox, string.Empty);
        }

        //endPhoneTab

//beginOfficeJackTab

        public class OfficeJack
        {
            public string mac;
            public string patchPanelPort;
            public string patchPanelName;
            public string idfName;
            public string venueName;
        }

        public class PatchPanel
        {
            public int patchPanelID;
            public string patchPanelName;
            public List<int> openPorts;
            public int idfID;
            public string idfName;
            public int venueSpaceID;
            public string venueSpaceName;
            public int venueID;
            public string venueName;
        }

        private void loadOfficeJackTab()
        {
            List<OfficeJack> officeJacks = new List<OfficeJack>();
            List<string> availablePatchPanelList = new List<string>();
            List<string> macs = new List<string>();

            //find list of availiable patchpanels with available patchpanelports
            
            string unassignedPhonesQuery = "SELECT Phone.MAC FROM [Phone] WHERE Phone.PhoneID NOT IN(SELECT OfficeJack.PhoneID FROM [OfficeJack]);";
            string assignedPhonesQuery = "SELECT Phone.MAC, IDF.IDFName, Venue.VenueName, VenueSpace.VenueSpaceName, PatchPanelPort.PatchPanelPortNum, PatchPanel.PatchPanelName FROM [Phone], [IDF], [Venue], [VenueSpace], [PatchPanel], [PatchPanelPort], [OfficeJack] WHERE OfficeJack.PatchPanelPortID = PatchPanelPort.PatchPanelPortID AND Phone.PhoneID = OfficeJack.PhoneID AND PatchPanel.PatchPanelID = PatchPanelPort.PatchPanelID AND IDF.IDFID = PatchPanel.IDFID AND IDF.VenueSpaceID = VenueSpace.VenueSpaceID AND VenueSpace.VenueID = Venue.VenueID;";
            DataSet unassignedPhonesDS = getDataSet(unassignedPhonesQuery);
            DataSet assignedPhonesDS = getDataSet(assignedPhonesQuery);

            string patchPanelsQuery = "SELECT PatchPanel.PatchPanelName, IDF.IDFName, VenueSpace.VenueSpaceName, Venue.VenueName FROM [PatchPanel], [IDF], [VenueSpace], [Venue] WHERE PatchPanel.IDFID = IDF.IDFID AND IDF.VenueSpaceID = VenueSpace.VenueSpaceID AND VenueSpace.VenueID = Venue.VenueID;";
            DataSet patchPanelsDS = getDataSet(patchPanelsQuery);

            createDataGridView.DataSource = assignedPhonesDS.Tables[0];

            foreach (DataRow dr in unassignedPhonesDS.Tables[0].Rows)
            {
                macs.Add(dr.ItemArray.GetValue(0).ToString());
            }

            foreach (DataRow dr in patchPanelsDS.Tables[0].Rows)
            {
                var patchPaenel
            }
            //foreach (DataRow dr in assignedPhonesDS.Tables[0].Rows)
            //{
            //    OfficeJack oj = new OfficeJack();
            //    oj.mac = dr.ItemArray.GetValue(0).ToString();
            //    oj.patchPanelPort = dr.ItemArray.GetValue(1).ToString();
            //    oj.patchPanelName = dr.ItemArray.GetValue(2).ToString();
            //    oj.idfName = dr.ItemArray.GetValue(3).ToString();
            //    oj.venueName = dr.ItemArray.GetValue(4).ToString();
            //}

            macs.Sort();

            //foreach (OfficeJack oj in officeJacks)
            //{
            //    availablePatchPanelList.Add(oj.venueName + ", " + oj.idfName + " - " + oj.patchPanelName);
            //}

            //distinctTypes.AddRange(phoneTypes.Distinct());
            //distinctTypes.Sort();
            //distinctTypes.Insert(0, "");
            macComboBox.DataSource = macs;

        }

        

        private void patchPanelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mac = patchPanelComboBox.SelectedValue;



        }

//beginOfficeJackTab
    }
}

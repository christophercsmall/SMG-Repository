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

        //public static List<PatchPanel> availablePatchPanelList = new List<PatchPanel>();
        public class IDF
        {
            public int id;
            public string name;
            public string venueSpaceName;
            public string venueName;
            public string idfString;
        }

        public class PatchPanel
        {
            public string portTotal;
            public int patchPanelID;
            public string patchPanelName;
            public List<int> openPorts;
            public int idfID;
            public string idfName;
            public int venueSpaceID;
            public string venueSpaceName;
            public int venueID;
            public string venueName;
            public string patchPanelRecord;
        }

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
                case "Office Jack":
                    {
                        createTabControl.SelectTab(2);
                        currentTabIndex = 2;
                        break;
                    }
                case "Switch":
                    {
                        createTabControl.SelectTab(3);
                        currentTabIndex = 3;
                        break;
                    }
                case "Patch Panel":
                    {
                        createTabControl.SelectTab(4);
                        currentTabIndex = 4;
                        break;
                    }
                case "IDF":
                    {
                        createTabControl.SelectTab(5);
                        currentTabIndex = 5;
                        break;
                    }
                case "Venue Space":
                    {
                        createTabControl.SelectTab(6);
                        currentTabIndex = 6;
                        break;
                    }
                case "Venue":
                    {
                        createTabControl.SelectTab(7);
                        currentTabIndex = 7;
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
                    loadSwitchTab();
                    break;
                case 4:
                    loadPatchPanelTab();
                    break;
                case 5:
                    loadIDFTab();
                    break;
                case 6:
                    loadVenueSpaceTab();
                    break;
                case 7:
                    loadVenueTab();
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

        private List<IDF> getIDFList()
        {
            List<IDF> idfs = new List<IDF>();

            string idfQuery = "SELECT IDF.IDFID, IDF.IDFName, VenueSpace.VenueSpaceName, Venue.VenueName FROM [IDF], [VenueSpace], [Venue] WHERE IDF.VenueSpaceID = VenueSpace.VenueSpaceID AND VenueSpace.VenueID = Venue.VenueID;";
            DataSet idfDS = getDataSet(idfQuery);

            foreach (DataRow dr in idfDS.Tables[0].Rows)
            {
                IDF idf = new IDF();
                idf.id = (int)dr.ItemArray.GetValue(0);
                idf.name = dr.ItemArray.GetValue(1).ToString();
                idf.venueSpaceName = dr.ItemArray.GetValue(2).ToString();
                idf.venueName = dr.ItemArray.GetValue(3).ToString();
                idf.idfString = idf.name + ", " + idf.venueSpaceName + ", " + idf.venueName;
                idfs.Add(idf);
            }
            idfs.OrderBy(i => i.venueName);

            return idfs;
        }

        private List<PatchPanel> getPatchPanelList()
        {
            List<PatchPanel> patchPanels = new List<PatchPanel>();

            string patchPanelsQuery = "SELECT PatchPanel.PatchPanelID, PatchPanel.PatchPanelName, IDF.IDFID, IDF.IDFName, VenueSpace.VenueSpaceID, VenueSpace.VenueSpaceName, Venue.VenueID, Venue.VenueName FROM [PatchPanel], [IDF], [VenueSpace], [Venue] WHERE PatchPanel.IDFID = IDF.IDFID AND IDF.VenueSpaceID = VenueSpace.VenueSpaceID AND VenueSpace.VenueID = Venue.VenueID;";
            DataSet patchPanelsDS = getDataSet(patchPanelsQuery);

            foreach (DataRow dr in patchPanelsDS.Tables[0].Rows)
            {
                PatchPanel pp = new PatchPanel();
                pp.patchPanelID = (int)dr.ItemArray.GetValue(0);
                pp.patchPanelName = dr.ItemArray.GetValue(1).ToString();
                pp.idfID = (int)dr.ItemArray.GetValue(2);
                pp.idfName = dr.ItemArray.GetValue(3).ToString();
                pp.venueSpaceID = (int)dr.ItemArray.GetValue(4);
                pp.venueSpaceName = dr.ItemArray.GetValue(5).ToString();
                pp.venueID = (int)dr.ItemArray.GetValue(6);
                pp.venueName = dr.ItemArray.GetValue(7).ToString();
                pp.patchPanelRecord = pp.patchPanelName + ", " + pp.idfName + ", " + pp.venueSpaceName + ", " + pp.venueName;

                string portCountQuery = "SELECT COUNT(PatchPanelPort.PatchPanelID) FROM [PatchPanelPort] WHERE PatchPanelPort.PatchPanelID = " + pp.patchPanelID + ";";
                DataSet portCountDS = getDataSet(portCountQuery);

                pp.portTotal = portCountDS.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

                patchPanels.Add(pp);
            }

            patchPanels.OrderBy(p => p.venueName);

            return patchPanels;
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



        //startUserTab*************************************************************************************************
        private void loadUserTab() 
        {
            errorProvider1.Clear();
            lNameBox.Clear();
            fNameBox.Clear();
            compBox.Clear();
            depBox.Clear();
            extBox.Clear();

            string userQuery = "SELECT User.LName, User.FName, User.Company, User.Department, User.ExtensionNum FROM [User];";

            DataSet ds = getDataSet(userQuery);

            createDataGridView.DataSource = ds.Tables[0];            
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            string lname = removeSpecialCharacters(lNameBox.Text);
            string fname = removeSpecialCharacters(fNameBox.Text);
            string comp = removeSpecialCharacters(compBox.Text);
            string dep = removeSpecialCharacters(depBox.Text);
            string ext = removeSpecialCharacters(extBox.Text);

            string userIdQuery = "SELECT User.UserID FROM [User];";
            int newUserID = getUnusedID(userIdQuery);
            string insertQuery = "INSERT INTO [User] (UserID, FName, LName, Company, Department, ExtensionNum) VALUES (" + newUserID + ", '" + fname + "'" + ", '" + lname + "'" + ", '" + comp + "'" + ", '" + dep + "'" + ", " + ext + ");";
            
            if (extBox.Text == "")
            {
                errorProvider1.SetError(extBox, "User record require Extension Number");
                errorsPending = true;
                MessageBox.Show("Pending errors must be resolved.");
            }
            else
            {
                if (extentionExists(ext))
                {
                    errorProvider1.SetError(extBox, "User record require unique Extension Number");
                    errorsPending = true;
                    MessageBox.Show("Extension number already assigned.");
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


        //endUserTab

        //beginPhoneTab*************************************************************************************************
        private void loadPhoneTab()
        {
            errorProvider1.Clear();
            macBox.Clear();
            jackBox.Clear();
            regComboBox.SelectedIndex = 0;

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

            if (registered == "YES")
            {
                reg = true;
            }

            string phoneIdQuery = "SELECT Phone.PhoneID FROM [Phone];";
            int newphoneID = getUnusedID(phoneIdQuery);
            string insertQuery = "INSERT INTO [Phone] (PhoneID, MAC, Type, Registered, JackInfo) VALUES (" + newphoneID + ", '" + mac + "'" + ", '" + type + "'" + ", '" + reg + "'" + ", '" + jackInfo + "'" + ");";

            bool isValid = phoneTabValid(mac, registered, type);
            jackInfo = removeSpecialCharacters(jackInfo);          

            if (isValid && !errorsPending)
            {
                executeDbComm(insertQuery);
                loadPhoneTab();
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

        //beginOfficeJackTab*************************************************************************************************

        private void loadOfficeJackTab()
        {
            errorProvider1.Clear();
            List<string> patchPanelRecords = new List<string>();
            List<string> macs = new List<string>();
            List<PatchPanel> patchPanelList = getPatchPanelList();
            officeJackDetailsBox.Clear();

            string unassignedPhonesQuery = "SELECT Phone.MAC FROM [Phone] WHERE Phone.PhoneID NOT IN(SELECT OfficeJack.PhoneID FROM [OfficeJack]);";
            string assignedPhonesQuery = "SELECT Phone.MAC, IDF.IDFName, Venue.VenueName, VenueSpace.VenueSpaceName, PatchPanelPort.PatchPanelPortNum, PatchPanel.PatchPanelName FROM [Phone], [IDF], [Venue], [VenueSpace], [PatchPanel], [PatchPanelPort], [OfficeJack] WHERE OfficeJack.PatchPanelPortID = PatchPanelPort.PatchPanelPortID AND Phone.PhoneID = OfficeJack.PhoneID AND PatchPanel.PatchPanelID = PatchPanelPort.PatchPanelID AND IDF.IDFID = PatchPanel.IDFID AND IDF.VenueSpaceID = VenueSpace.VenueSpaceID AND VenueSpace.VenueID = Venue.VenueID;";
            DataSet unassignedPhonesDS = getDataSet(unassignedPhonesQuery);
            DataSet assignedPhonesDS = getDataSet(assignedPhonesQuery);

            createDataGridView.DataSource = assignedPhonesDS.Tables[0];

            foreach (DataRow dr in unassignedPhonesDS.Tables[0].Rows)
            {
                macs.Add(dr.ItemArray.GetValue(0).ToString());
            }

            macs.Sort();
            macs.Insert(0, "");

            foreach (PatchPanel pp in patchPanelList)
            {
                patchPanelRecords.Add(pp.patchPanelRecord);
            }
            patchPanelRecords.Insert(0, "");

            macComboBox.DataSource = macs;            
            patchPanelComboBox.DataSource = patchPanelRecords;
        }
        
        private void patchPanelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(patchPanelComboBox, string.Empty);

            string patchPanelString = patchPanelComboBox.SelectedValue.ToString();
            List<string> openPortsList = new List<string>();
            List<PatchPanel> patchPanelList = getPatchPanelList();

            foreach (PatchPanel pp in patchPanelList)
            {
                if (pp.patchPanelRecord == patchPanelString)
                {
                    DataSet openPortsDataSet =  getPatchPanelOpenPortsDataSet(pp.patchPanelID);
                    foreach(DataRow dr in openPortsDataSet.Tables[0].Rows)
                    {                        
                        openPortsList.Add(dr.ItemArray.GetValue(1).ToString());
                    }
                }
            }
            openPortsList.OrderBy(p => p).ToList();
            openPortsList.Insert(0, "");
            patchPanelPortComboBox.DataSource = openPortsList;
        }

        private DataSet getPatchPanelOpenPortsDataSet(int ppID)
        {
            string openPatchPanelPortsQuery = "SELECT PatchPanelPort.PatchPanelPortID, PatchPanelPort.PatchPanelPortNum FROM [PatchPanelPort] WHERE PatchPanelPort.PatchPanelID = " + ppID + " AND PatchPanelPort.PatchPanelPortID NOT IN (SELECT OfficeJack.PatchPanelPortID FROM [OfficeJack]);";
            DataSet openPatchPanelPortsDS = getDataSet(openPatchPanelPortsQuery);            

            return openPatchPanelPortsDS;
        }

        private void createOfficeJackBtn_Click(object sender, EventArgs e)
        {
            List<PatchPanel> patchPanelList = getPatchPanelList();
            string mac = macComboBox.SelectedValue.ToString();
            string patchPanelString = patchPanelComboBox.SelectedValue.ToString();
            string openPatchPanelPortNum = patchPanelPortComboBox.SelectedValue.ToString();
            bool isValid = officeJackTabValid(mac, patchPanelString, openPatchPanelPortNum);
           
            if (isValid && !errorsPending)
            {
                int jackID = -1;
                int phoneID = -1;
                int ppPortID = -1;
                int ppID = -1;
                string officeJackDetails = removeSpecialCharacters(officeJackDetailsBox.Text);

                string officeJackIDQuery = "SELECT OfficeJack.JackID FROM [OfficeJack];";
                jackID = getUnusedID(officeJackIDQuery);

                string phoneIDQuery = "SELECT Phone.PhoneID FROM [Phone] WHERE Phone.MAC = '" + mac + "';";
                DataSet phoneIDDS = getDataSet(phoneIDQuery);
                phoneID = (int)phoneIDDS.Tables[0].Rows[0].ItemArray.GetValue(0);

                foreach (PatchPanel pp in patchPanelList)
                {
                    if (pp.patchPanelRecord == patchPanelString)
                    {
                        ppID = pp.patchPanelID;
                    }
                }

                string ppPortIDQuery = "SELECT PatchPanelPort.PatchPanelPortID FROM [PatchPanelPort] WHERE PatchPanelPort.PatchPanelPortNum = " + openPatchPanelPortNum + " AND PatchPanelPort.PatchPanelID = " + ppID + ";";
                DataSet ppPortIDDS = getDataSet(ppPortIDQuery);
                ppPortID = (int)ppPortIDDS.Tables[0].Rows[0].ItemArray.GetValue(0);

                string insertQuery = "INSERT INTO [OfficeJack] (JackID, PhoneID, PatchPanelPortID, Details) VALUES (" + jackID + ", " + phoneID + ", " + ppPortID + ", '" + officeJackDetails + "');";
                
                executeDbComm(insertQuery);
                loadOfficeJackTab();
            }
            else
            {
                MessageBox.Show("Pending errors must be resolved.");
            }            
        }

        private bool officeJackTabValid(string mac, string pp, string ppPort)
        {
            errorsPending = false;
            bool macValid, ppValid, ppPortValid, isValid = false;

            if (macComboBox.SelectedValue.ToString() == "")
            {
                macValid = false;
                errorProvider1.SetError(macComboBox, "Phone MAC must be selected.");
                errorsPending = true;
            }
            else
            {
                macValid = true;
            }

            if (patchPanelComboBox.SelectedValue.ToString() == "")
            {
                ppValid = false;
                errorProvider1.SetError(patchPanelComboBox, "Patch Panel must be selected.");
                errorsPending = true;
            }
            else
            {
                ppValid = true;
            }

            if (patchPanelPortComboBox.SelectedValue.ToString() == "")
            {
                ppPortValid = false;
                errorProvider1.SetError(patchPanelPortComboBox, "Port must be selected.");
                errorsPending = true;
            }
            else
            {
                ppPortValid = true;
            }

            if (macValid && ppValid && ppPortValid && !errorsPending)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        private void macComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(macComboBox, string.Empty);
        }

        private void patchPanelPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(patchPanelPortComboBox, string.Empty);
        }

        //endOfficeJackTab

        //beginSwitchTab*************************************************************************************************

        private void loadSwitchTab()
        {
            errorProvider1.Clear();
            dnsNameBox.Clear(); 
            ipBox0.Clear(); ipBox1.Clear(); ipBox2.Clear(); ipBox3.Clear();
            portCountComboBox.SelectedIndex = 0;

            List<string> idfStringList = new List<string>();
            
            string switchQuery = "SELECT Switch.DNSName, Switch.IP, IDF.IDFName, VenueSpace.VenueSpaceName, Venue.VenueName FROM [Switch], [IDF], [VenueSpace], [Venue] WHERE Switch.IDFID = IDF.IDFID AND IDF.VenueSpaceID = VenueSpace.VenueSpaceID AND VenueSpace.VenueID = Venue.VenueID;";
            DataSet switchDS = getDataSet(switchQuery);

            List<IDF> idfList = getIDFList();            

            foreach(IDF idf in idfList)
            {
                idfStringList.Add(idf.idfString);
            }
            idfStringList.Insert(0, "");

            idfComboBox.DataSource = idfStringList;

            createDataGridView.DataSource = switchDS.Tables[0];
        }

        private void createSwitchBtn_Click(object sender, EventArgs e)
        {
            int idfID = -1;
            int portCount = -1;
            string dnsName = removeSpecialCharacters(dnsNameBox.Text);
            string ip = ipBox0.Text + "." + ipBox1.Text + "." + ipBox2.Text + "." + ipBox3.Text;            
            string switchIDQuery = "SELECT Switch.SwitchID FROM [Switch];";
            int id = getUnusedID(switchIDQuery);
            string switchPortIDQuery = "SELECT SwitchPort.SwitchPortID FROM [SwitchPort];";
            int switchPortID; int switchPortNum;
            string insertSwitchPortQuery;

            if (portCountComboBox.Text != "")
            {
                portCount = Convert.ToInt32(portCountComboBox.Text);
            }
            
            bool isValid = switchTabValid(dnsName, ipBox0.Text, ipBox1.Text, ipBox2.Text, ipBox3.Text, portCount);

            if(isValid && !errorsPending)
            {                
                List<IDF> idfList = getIDFList();
                foreach (IDF idf in idfList)
                {
                    if (idf.idfString == idfComboBox.Text)
                    {
                        idfID = idf.id;
                    }
                }

                string insertQuery = "INSERT INTO [Switch] (SwitchID, DNSName, IP, IDFID) VALUES (" + id + ", '" + dnsName + "', '" + ip + "', '" + idfID + "');";
                executeDbComm(insertQuery);

                for (int i = 0; i < portCount; i++)
                {
                    switchPortID = getUnusedID(switchPortIDQuery);
                    switchPortNum = i + 1;

                    insertSwitchPortQuery = "INSERT INTO [SwitchPort] (SwitchPortID, SwitchPortNum, SwitchID, PatchPanelPortID) VALUES (" + switchPortID + ", " + switchPortNum + ", " + id + ", NULL );";
                    executeDbComm(insertSwitchPortQuery);
                }

                loadSwitchTab();
            }
            else
            {
                MessageBox.Show("Pending errors must be resolved.");
            }
        }

        private bool switchTabValid(string dnsName, string ip0, string ip1, string ip2, string ip3, int portCount)
        {
            bool dnsValid = false;
            bool ipValid = false;
            bool portCountValid = false;
            bool idfValid = false;
            bool dnsNameExists = false;
            bool isValid = false;

            string dnsNameBoolQuery = "SELECT Switch.DNSName FROM [Switch];";
            DataSet dnsNameDS = getDataSet(dnsNameBoolQuery);

            foreach(DataRow dr in dnsNameDS.Tables[0].Rows)
            {
                if(dr.ItemArray.GetValue(0).ToString() == dnsName)
                {
                    dnsNameExists = true;
                }
            }

            if (dnsName == "" || dnsNameExists)
            {
                dnsValid = false;
                errorProvider1.SetError(dnsNameBox, "Switch must have a Valid and Unique DNS Name.");
                errorsPending = true;
            }
            else
            {
                dnsValid = true;
            }

            if (ip0 == "" || ip1 == "" || ip2 == "" || ip3 == "")
            {
                ipValid = false;
                errorProvider1.SetError(ipBox3, "Switch must have valid IP Address.");
                errorsPending = true;
            }
            else
            {
                ipValid = true;
            }

            if (portCount <= 0)
            {
                portCountValid = false;
                errorProvider1.SetError(portCountComboBox, "Number of Ports must be selected.");
                errorsPending = true;
            }
            else
            {
                portCountValid = true;
            }

            if (idfComboBox.SelectedItem.ToString() == "")
            {
                idfValid = false;
                errorProvider1.SetError(idfComboBox, "IDF must be selected.");
                errorsPending = true;
            }
            else
            {
                idfValid = true;
            }

            if (dnsValid && ipValid && portCountValid && idfValid && !errorsPending)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        private void portCountComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void dnsNameBox_TextChanged(object sender, EventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(dnsNameBox, string.Empty);
        }

        private void portCountComboBox_TextChanged(object sender, EventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(portCountComboBox, string.Empty);
        }

        private void idfComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(idfComboBox, string.Empty);
        }

        private void ipBox0_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(ipBox3, string.Empty);

            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

            switch (e.KeyChar)
            {
                case (char)48: case (char)49: case (char)50: case (char)51: case (char)52: case (char)53: case (char)54: case (char)55: case (char)56: case (char)57:
                    if (ipBox0.TextLength == 2)
                    {
                        ipBox1.Select();
                    }
                    break;

                case (char)8:
                    break;
            }            
        }

        private void ipBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(ipBox3, string.Empty);

            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

            switch (e.KeyChar)
            {
                case (char)48: case (char)49: case (char)50: case (char)51: case (char)52: case (char)53: case (char)54: case (char)55: case (char)56: case (char)57:
                    if (ipBox1.TextLength == 2)
                    {
                        ipBox2.Select();
                    }
                    break;

                case (char)8:
                    if (ipBox1.TextLength <= 1)
                    {
                        ipBox0.Select();
                    }
                    break;
            }
        }

        private void ipBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(ipBox3, string.Empty);

            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

            switch (e.KeyChar)
            {
                case (char)48: case (char)49: case (char)50: case (char)51: case (char)52: case (char)53: case (char)54: case (char)55: case (char)56: case (char)57:
                    if (ipBox2.TextLength == 2)
                    {
                        ipBox3.Select();
                    }
                    break;

                case (char)8:
                    if (ipBox2.TextLength <= 1)
                    {
                        ipBox1.Select();
                    }
                    break;
            }
        }

        private void ipBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(ipBox3, string.Empty);

            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

            switch (e.KeyChar)
            {
                case (char)48: case (char)49: case (char)50: case (char)51: case (char)52: case (char)53: case (char)54: case (char)55: case (char)56: case (char)57:                    
                    break;

                case (char)8:
                    if (ipBox3.TextLength <= 1)
                    {
                        ipBox2.Select();
                    }
                    break;
            }
        }

        //endSwitchTab

        //beginPatchPanelTab*************************************************************************************************
        private void loadPatchPanelTab()
        {
            errorProvider1.Clear();
            ppNameBox.Clear();
            ppPortCountComboBox.SelectedIndex = 0;
                        
            List<IDF> idfList = getIDFList();
            List<string> idfStringList = new List<string>();
            string ppQuery = "SELECT PatchPanel.PatchPanelName, IDF.IDFName, VenueSpace.VenueSpaceName, Venue.VenueName FROM [PatchPanel], [IDF], [VenueSpace], [Venue] WHERE PatchPanel.IDFID = IDF.IDFID AND IDF.VenueSpaceID = VenueSpace.VenueSpaceID AND VenueSpace.VenueID = Venue.VenueID;";

            foreach (IDF idf in idfList)
            {
                idfStringList.Add(idf.idfString);
            }
            idfStringList.Insert(0, "");
            ppIDFComboBox.DataSource = idfStringList;

            DataSet ppDS = getDataSet(ppQuery);
            createDataGridView.DataSource = ppDS.Tables[0];
        }

        private void createPatchPanelBtn_Click(object sender, EventArgs e)
        {
            string ppIDQuery = "SELECT PatchPanel.PatchPanelID from [PatchPanel];";
            int newPPID = getUnusedID(ppIDQuery);
            string newPPName = removeSpecialCharacters(ppNameBox.Text);
            string idfString = ppIDFComboBox.SelectedValue.ToString();
            int idfID = -1;
            int portCount = -1;

            List<IDF> idfList = getIDFList();
            foreach (IDF idf in idfList)
            {
                if (idf.idfString == idfString)
                {
                    idfID = idf.id;
                }
            }

            if (ppPortCountComboBox.Text != "")
            {
                portCount = Convert.ToInt32(ppPortCountComboBox.Text);
            }

            bool isValid = patchPanelTabValid(newPPName, idfID, portCount);

            if (isValid)
            {
                string insertQuery = "INSERT INTO [PatchPanel] (PatchPanelID, PatchPanelName, IDFID) VALUES (" + newPPID + ", '" + newPPName + "' " + idfID + ");";
                executeDbComm(insertQuery);

                //add new records for each patchPanelPort

                loadPatchPanelTab();
            }
            else
            {
                MessageBox.Show("Pending errors must be resolved.");
            }
        }

        private bool patchPanelTabValid(string ppName, int idfID, int portCount)
        {
            bool isValid = false;
            bool ppNameValid = false;
            bool idfValid = false;
            bool portCountValid = false;

            if (ppName == "")
            {
                ppNameValid = false;
                errorProvider1.SetError(ppNameBox, "Patch Panel name cannot be empty.");
                errorsPending = true;
            }
            else
            {
                ppNameValid = true;
            }

            if (idfID < 0)
            {
                idfValid = false;
                errorProvider1.SetError(ppIDFComboBox, "IDF must be selected.");
                errorsPending = true;
            }
            else
            {
                idfValid = true;
            }

            if (portCount <= 0)
            {
                portCountValid = false;
                errorProvider1.SetError(ppPortCountComboBox, "Port count number must be selected and larger than 0.");
                errorsPending = true;
            }
            else
            {
                portCountValid = true;
            }


            if (ppNameValid && idfValid && portCountValid && !errorsPending)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        private void ppPortCountComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void ppPortCountComboBox_TextChanged(object sender, EventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(portCountComboBox, string.Empty);
        }

        private void ppNameBox_TextChanged(object sender, EventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(ppNameBox, string.Empty);
        }

        private void ppIDFComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorsPending = false;
            errorProvider1.SetError(ppIDFComboBox, string.Empty);
        }

        //endPatchPanelTab

        //beginIDFTab******************************************************************************************************

        private void loadIDFTab()
        {
            idfNameBox.Clear();

            List<IDF> idfList = getIDFList();
            List<string> idfStringList = new List<string>();

            foreach (IDF idf in idfList)
            {
                idfStringList.Add(idf.idfString);
            }
            idfStringList.Insert(0, "");

            idfLocComboBox.DataSource = idfStringList;
        }

        private void createIdfBtn_Click(object sender, EventArgs e)
        {
            bool isValid = IDFTabValid();
        }

        private bool IDFTabValid()
        {
            bool isValid = false;

            return isValid;
        }

        private void idfNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idfLocComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //endIDFTab

        //beginVenueSpaceTab*************************************************************************************************

        private void loadVenueSpaceTab()
        {
            
        }

        

        private bool venueSpaceTabValid()
        {
            bool isValid = false;

            return isValid;
        }

        



        //endVenueSpaceTab

        //beginVenueTab*************************************************************************************************

        private void loadVenueTab()
        {

        }

        private bool venueTabValid()
        {
            bool isValid = false;

            return isValid;
        }







        //endVenueTab*************************************************************************************************
    }
}

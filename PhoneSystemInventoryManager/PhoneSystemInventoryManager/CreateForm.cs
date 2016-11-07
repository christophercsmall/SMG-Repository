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
                        currentTabIndex = createTabControl.SelectedIndex;
                        loadUserTab();
                        break;
                    }
                case "Phone":
                    {
                        createTabControl.SelectTab(1);
                        currentTabIndex = createTabControl.SelectedIndex;
                        break;
                    }
                default:
                    {
                        break;
                    }
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

        private void createTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTabIndex = createTabControl.SelectedIndex;
            //clearTabs();

            switch (currentTabIndex)
            {
                case 0:
                    loadUserTab();
                    break;
                case 1:
                    loadPhoneTab();
                    break;
                case 2:
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

//startUserTab
        private void loadUserTab() 
        {
            List<string> extNums = new List<string>();

            string userQuery = "SELECT User.LName, User.FName, User.Company, User.Department, User.ExtensionNum FROM [User];";

            DataSet ds = getDataSet(userQuery);

            createDdataGridView.DataSource = ds.Tables[0];

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
                MessageBox.Show("User records require valid Extension Number");
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

            string userQuery = "SELECT User.LName, User.FName, User.ExtensionNum FROM [User];";
            string phoneQuery = "SELECT Phone.MAC, Phone.Type, Phone.Registered, Phone.JackInfo FROM [Phone];";

            DataSet phoneDS = getDataSet(phoneQuery);
            DataSet UserDS = getDataSet(userQuery);

            createDdataGridView.DataSource = phoneDS.Tables[0];

            foreach (DataRow dr in phoneDS.Tables[0].Rows)
            {
                phoneTypes.Add(dr.ItemArray.GetValue(1).ToString());
            }

            foreach (DataRow dr in UserDS.Tables[0].Rows)
            {
                users.Add(dr.ItemArray.GetValue(0).ToString() + " ," + dr.ItemArray.GetValue(1).ToString() + " - " + dr.ItemArray.GetValue(2).ToString());
            }

            distinctTypes.AddRange(phoneTypes.Distinct());
            distinctTypes.Sort();
            users.Sort();
            distinctTypes.Insert(0, "");
            users.Insert(0, "");
            typeComboBox.DataSource = distinctTypes;
            userComboBox.DataSource = users;
        }

        //endPhoneTab


    }
}

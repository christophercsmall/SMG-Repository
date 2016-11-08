using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;
using System.Globalization;

namespace PhoneSystemInventoryManager
{
    public partial class MainForm : Form
    {
        public static class dbConnection
        {
            public static string dbFilePath { get; set; }
            public static string  dbFileName { get; set; }
            public static string  connectionString { get; set; }
            public static OleDbConnection conn { get; set; }
        }

        public static bool connected = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Access Files | *.accdb;";
            ofd.FilterIndex = 1;            

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dbConnection.dbFilePath = ofd.FileName;
                dbConnection.dbFileName = ofd.SafeFileName;
                dbConnection.connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data" + " Source=" + dbConnection.dbFilePath + ";";
                dbConnection.conn = new OleDbConnection(dbConnection.connectionString);
                createNewToolStripMenuItem1.Enabled = true;
                assignToolStripMenuItem.Enabled = true;
                dbConnect();
                dbClose();
            }
            else
            {
                dbConnection.dbFilePath = null;
                dbConnection.dbFileName = null;
            }
        }

        public void dbConnect()
        {
            try
            {
                //Open Database Connection
                dbConnection.conn.Open();
                connected = true;
                connectedLabelUpdate();        
            }
            catch (OleDbException exp)
            {
                connected = false;
                connectedLabelUpdate();                
                MessageBox.Show("Database Error:" + exp.Message.ToString());
            }
        }     

        public void dbClose()
        {
            dbConnection.conn.Close();
        }

        private void connectedLabelUpdate()
        {
            if (connected)
            {
                connectedLabel.BackColor = Color.Green;
                connectedLabel.Text = "Connected";
                dbLabel.Text = dbConnection.dbFileName;
            }
            else
            {
                connectedLabel.BackColor = Color.Red;
                connectedLabel.Text = "No Connection";
                dbLabel.Text = "";
            }
        }
        
        private void dataGridUpdate(string query)
        {
            dbConnect();

            if (connected)
            {
                OleDbDataAdapter da = new OleDbDataAdapter(query, dbConnection.conn);
                DataSet ds = new DataSet();

                try
                {
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    recordsCountLabel.Text = dataGridView1.Rows.Count.ToString();
                }
                catch (OleDbException exp)
                {
                    MessageBox.Show("Database Error:" + exp.Message.ToString());
                }
            }

            dbClose();
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "";
            string filter = searchBox.Text;

            if(comboBox1.SelectedItem != null && connected)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "ALL":
                        {
                            query = "SELECT User.FName, User.LName, User.Company, User.ExtensionNum, Phone.MAC, Phone.Type, IDF.IDFName, Switch.DNSName, SwitchPort.SwitchPortNum, PatchPanel.PatchPanelName, PatchPanelPort.PatchPanelPortNum FROM [User], [Phone], [UserPhone], [IDF], [Switch], [SwitchPort], [PatchPanel], [PatchPanelPort], [PatchToSwitch], [OfficeJack] WHERE User.ExtensionNum = UserPhone.ExtensionNum AND Phone.PhoneID = UserPhone.PhoneID AND Switch.SwitchID = SwitchPort.SwitchID AND PatchPanel.PatchPanelID = PatchPanelPort.PatchPanelID AND IDF.IDFID = Switch.IDFID AND IDF.IDFID = PatchPanel.IDFID AND UserPhone.PhoneID = OfficeJack.PhoneID AND SwitchPort.SwitchPortID = PatchToSwitch.SwitchPortID AND PatchPanelPort.PatchPanelPortID = PatchToSwitch.PatchPanelPortID AND Switch.SwitchID = SwitchPort.SwitchID;";
                            break;
                        }
                    case "Phone MAC":
                        {
                            query = "SELECT Phone.MAC, Phone.Type, Phone.Registered, Phone.JackInfo FROM [Phone], [UserPhone], [OfficeJack] WHERE Phone.PhoneID = UserPhone.PhoneID AND Phone.PhoneID = OfficeJack.PhoneID";

                            if (searchBox.Text != "")
                            {
                                query += " AND Phone.MAC = " + "'" + filter + "'" + ";";
                            }
                            break;
                        }
                    default:
                        {
                            query = "";
                            break;
                        }
                }
            }            

            if (query != "")
            {
                dataGridUpdate(query);
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm newForm = new CreateForm(this, sender);
            newForm.ShowDialog();
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm newForm = new CreateForm(this, sender);
            newForm.ShowDialog();
        }

        private void patchToSwitchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePatchToSwitchForm newForm = new CreatePatchToSwitchForm(this);
            newForm.ShowDialog();
        }

       
    }
}

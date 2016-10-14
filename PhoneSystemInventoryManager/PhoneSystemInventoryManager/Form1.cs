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
    public partial class Form1 : Form
    {
        public static string dbFilePath;
        public static string dbFileName;
        public static bool connected = false;

        public Form1()
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
                dbFilePath = ofd.FileName;
                dbFileName = ofd.SafeFileName;
                
                var conn = dbConnect();
                MessageBox.Show("Connected to " + dbFileName);
                dbClose(conn);
            }
            else
            {
                dbFilePath = null;
                dbFileName = null;
            }
        }

        private OleDbConnection dbConnect()
        {

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data" + " Source=" + dbFilePath + ";";
            OleDbConnection conn = new OleDbConnection(connectionString);

            try
            {
                //Open Database Connection
                conn.Open();
                connected = true;
                connectedLabelUpdate();        
            }
            catch (OleDbException exp)
            {
                connected = false;
                connectedLabelUpdate();                
                MessageBox.Show("Database Error:" + exp.Message.ToString());
            }

            return conn;           
        }     

        private void dbClose(OleDbConnection conn)
        {
            conn.Close();
        }

        private void connectedLabelUpdate()
        {
            if (connected)
            {
                connectedLabel.BackColor = Color.Green;
                connectedLabel.Text = "Connected";
            }
            else
            {
                connectedLabel.BackColor = Color.Red;
                connectedLabel.Text = "No Connection";
            }
        }
        
        private void dataGridUpdate(string query)
        {
            var conn = dbConnect();

            if (connected)
            {
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                DataSet ds = new DataSet();
                //var dsList = ds.Tables[0].AsEnumerable();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("(" + dataGridView1.Rows.Count.ToString() + ") " + "Record(s) Found");
            }

            dbClose(conn);
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "";

            if(comboBox1.SelectedItem != null && connected)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "ALL":
                        {
                            query = "SELECT User.FName, User.LName, User.Company, User.ExtensionNum, Phone.MAC, Phone.Type, IDF.IDFName, Switch.DNSName, SwitchPort.SwitchPortNum, PatchPanel.PatchPanelName, PatchPanelPort.PatchPanelPortNum FROM [User], [Phone], [UserPhone], [IDF], [Switch], [SwitchPort], [PatchPanel], [PatchPanelPort], [PatchToSwitch], [OfficeJack] WHERE User.ExtensionNum = UserPhone.ExtensionNum AND Phone.PhoneID = UserPhone.PhoneID AND Switch.SwitchID = SwitchPort.SwitchID AND PatchPanel.PatchPanelID = PatchPanelPort.PatchPanelID AND IDF.IDFID = Switch.IDFID AND IDF.IDFID = PatchPanel.IDFID AND UserPhone.PhoneID = OfficeJack.PhoneID AND SwitchPort.SwitchPortID = PatchToSwitch.SwitchPortID AND PatchPanelPort.PatchPanelPortID = PatchToSwitch.PatchPanelPortID AND Switch.SwitchID = SwitchPort.SwitchID;";
                            break;
                        }
                    case "Switch Name (DNS)":
                        {
                            query = "SELECT Phone.MAC, Phone.Type, Phone.Registered, Phone.JackInfo FROM [Phone], [UserPhone], [OfficeJack] WHERE Phone.PhoneID = UserPhone.PhoneID AND Phone.PhoneID = OfficeJack.PhoneID;";
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

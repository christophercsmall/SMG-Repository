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
        public static string searchParam;

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
            string dbFilePath;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Access Files | *.accdb;";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dbFilePath = ofd.FileName;
            }
            else
            {
                dbFilePath = "";
            }


            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data" + " Source=" + dbFilePath + ";";
            OleDbConnection conn = new OleDbConnection(connectionString);


            try
            {
                //Open Database Connection
                conn.Open();
                string query = "SELECT User.FName, User.LName, User.Company, User.ExtensionNum, Phone.MAC, Phone.Type, IDF.IDFName, Switch.DNSName, SwitchPort.SwitchPortNum, PatchPanel.PatchPanelName, PatchPanelPort.PatchPanelPortNum FROM [User], [Phone], [UserPhone], [IDF], [Switch], [SwitchPort], [PatchPanel], [PatchPanelPort], [PatchToSwitch], [OfficeJack] WHERE User.ExtensionNum = UserPhone.ExtensionNum AND Phone.PhoneID = UserPhone.PhoneID AND Switch.SwitchID = SwitchPort.SwitchID AND PatchPanel.PatchPanelID = PatchPanelPort.PatchPanelID AND IDF.IDFID = Switch.IDFID AND IDF.IDFID = PatchPanel.IDFID AND UserPhone.PhoneID = OfficeJack.PhoneID AND SwitchPort.SwitchPortID = PatchToSwitch.SwitchPortID AND PatchPanelPort.PatchPanelPortID = PatchToSwitch.PatchPanelPortID AND Switch.SwitchID = SwitchPort.SwitchID;";
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                var dsList = ds.Tables[0].AsEnumerable();

                MessageBox.Show(dsList.FirstOrDefault().ItemArray[0].ToString());
            }
            catch (OleDbException exp)
            {
                MessageBox.Show("Database Error:" + exp.Message.ToString());
            }


        }           

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchParam = comboBox1.SelectedItem.ToString();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (searchParam)
            {
                case "ALL":
                    {
                        this.query2TableAdapter.Fill(this.ciscoPhoneSystemDBDataSet.Query2);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

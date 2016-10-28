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

        private void loadUserTab()
        {
            string query = "SELECT User.LName, User.FName, User. FROM [User];";

            DataSet ds = getDataSet(query);

            createDdataGridView.DataSource = ds.Tables[0];

            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{

            //}
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

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(extBox, "Extenion already assigned.");
        }
    }
}

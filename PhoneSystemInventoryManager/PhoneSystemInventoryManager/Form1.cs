using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'ciscoPhoneSystemDBDataSet.Query2' table. You can move, or remove it, as needed.
            

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";

            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
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

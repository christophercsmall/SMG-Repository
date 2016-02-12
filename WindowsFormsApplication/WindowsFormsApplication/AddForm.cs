using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace WindowsFormsApplication
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String inv = invComboBox.Text;
            String loc = locComboBox.Text;
            String sn = serialNumBox.Text;
            String brand = brandComboBox.Text;
            String model = modelComboBox.Text;
            String id = idBox.Text;
            String user = userNameBox.Text;
            String notes = notesBox.Text;
            String query = "INSERT INTO [ALL$] ([INVENTORY], [LOCATION], [SERIAL_NUMBER], [BRAND], [MODEL_NUMBER], [SMG_ID], [USER_NAME], [NOTES], [LAST_UPDATE]) VALUES('" + inv + "', '"+loc+"', '"+sn+"', '"+brand+"', '"+model+"', '"+id+"', '"+user+"', '"+notes+"', '"+DateTime.Now+"')";

            //String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Form1.filePath + ";Extended Properties=\"Excel 12.0;ReadOnly=False;HDR=Yes;\"";
            String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Form1.filePath + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=0;MAXSCANROWS=10;READONLY=FALSE;\""; //IMEX=0;MAXSCANROWS=10;

            OleDbConnection conn = new OleDbConnection(connString);
            //checking that connection state is closed or not if closed the     
            //open the connection    
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //create command object    
            OleDbCommand cmd = new OleDbCommand(query, conn);

            int n = cmd.ExecuteNonQuery();
            
            conn.Close();

            if (addAnotherCheckBox.Checked)
            {
                clearForm();
            }
            else
            {                
                Close();
            }
        }

        private void clearForm()
        {
            invComboBox.Text = string.Empty;
            locComboBox.Text = string.Empty;
            serialNumBox.Text = string.Empty;
            brandComboBox.Text = string.Empty;
            modelComboBox.Text = string.Empty;
            idBox.Text = string.Empty;
            userNameBox.Text = string.Empty;
            notesBox.Text = string.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {                     
            Close();
        }

        private void serialNumBox_TextChanged(object sender, EventArgs e)
        {            
            int result = isUnique(serialNumBox.Text);

            if (result == 0)
            {
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled = false;
            }

            if (serialNumBox.Text == "")
            {
                addButton.Enabled = false;
            }
        }

        private int isUnique(string sn)
        {            
            string query = "SELECT COUNT(*) FROM [ALL$] WHERE [SERIAL_NUMBER] = '"+sn+"'";

            //String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Form1.filePath + ";Extended Properties=\"Excel 12.0;ReadOnly=False;HDR=Yes;\"";
            String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Form1.filePath + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=0;MAXSCANROWS=10;READONLY=FALSE;\""; //IMEX=0;MAXSCANROWS=10;

            OleDbConnection conn = new OleDbConnection(connString);
            //checking that connection state is closed or not if closed the     
            //open the connection    
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //create command object    
            OleDbCommand cmd = new OleDbCommand(query, conn);
            int n = (int) cmd.ExecuteScalar();

            conn.Close();

            return n;
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = (Form1)this.Owner;
            form.Enabled = true;
            form.refreshData();   
        }
    }
}

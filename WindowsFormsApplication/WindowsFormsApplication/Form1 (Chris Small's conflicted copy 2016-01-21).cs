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
    public partial class Form1 : Form
    {
        public static string filePath;
        public string query = "SELECT * FROM [ALL$] WHERE [SERIAL_NUMBER] <> '';";
        public static string inv, loc, sn, brand, model, id, user, notes;
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filePath = openFileDialog1.FileName;
            filePathLabel.Text = filePath;
            filePathLabel.Visible = true;
        }

        private void loadInventoryButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tabControl1.SelectTab(0);
            if (filePath != null) load(query);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //make case on selected index number, then load from [sheet$]
            if (filePath != null)
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        query = "SELECT * FROM [ALL$] WHERE [LOCATION] <> ''";
                        break;
                    case 1:
                        query = "SELECT * FROM [ALL$] WHERE [LOCATION] = 'STADIUM'";
                        break;
                    case 2:
                        query = "SELECT * FROM [ALL$] WHERE [LOCATION] = 'ARENA'";
                        break;
                    case 3:
                        query = "SELECT * FROM [ALL$] WHERE [LOCATION] = 'TUCPA'";
                        break;
                    case 4:
                        query = "SELECT * FROM [ALL$] WHERE [LOCATION] = 'POCC'";
                        break;
                    case 5:
                        query = "SELECT * FROM [ALL$] WHERE [LOCATION] = 'RITZ'";
                        break;
                    case 6:
                        query = "SELECT * FROM [ALL$] WHERE [LOCATION] = 'BALLPARK'";
                        break;
                    case 7:
                        query = "SELECT * FROM [ALL$] WHERE [LOCATION] = 'STORAGE'";
                        break;                    
                }
                load(query);
            }
        }

        private void load(String query)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
            OleDbConnection conn = new OleDbConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    cmd = new OleDbCommand(query, conn);
                    da = new OleDbDataAdapter(cmd);
                    da.Fill(ds);
                    addButton.Enabled = true;
                    editButton.Enabled = true;
                    deleteButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    //Exception
                    filePath = null;
                    filePathLabel.Text = "";
                    addButton.Enabled = false;
                    editButton.Enabled = false;
                    MessageBox.Show("File must be in Excel format." + ex);
                }
                finally
                {
                    da.Dispose();
                    conn.Close();
                }

                if (filePath != null)
                {
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = ds.Tables[0].ToString();

                }
            }

                        
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[2].RowIndex;

                inv = dataGridView1.Rows[selectedrowindex].Cells[0].Value.ToString();
                loc = dataGridView1.Rows[selectedrowindex].Cells[1].Value.ToString();
                sn = dataGridView1.Rows[selectedrowindex].Cells[2].Value.ToString();
                brand = dataGridView1.Rows[selectedrowindex].Cells[3].Value.ToString();
                model = dataGridView1.Rows[selectedrowindex].Cells[4].Value.ToString();
                id = dataGridView1.Rows[selectedrowindex].Cells[5].Value.ToString();
                user = dataGridView1.Rows[selectedrowindex].Cells[6].Value.ToString();
                notes = dataGridView1.Rows[selectedrowindex].Cells[7].Value.ToString();

                EditForm form = new EditForm();
                form.Show();
            }
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete this record?");
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[2].RowIndex;
                sn = dataGridView1.Rows[selectedrowindex].Cells[2].Value.ToString();
            }

            string invQry = "UPDATE [ALL$] SET INVENTORY = '' WHERE SERIAL_NUMBER = '" + sn + "'";
            string locQry = "UPDATE [ALL$] SET LOCATION = '' WHERE SERIAL_NUMBER = '" + sn + "'";
            string snQry = "UPDATE [ALL$] SET SERIAL_NUMBER = '' WHERE SERIAL_NUMBER = '" + sn + "'";
            string brandQry = "UPDATE [ALL$] SET BRAND = '' WHERE SERIAL_NUMBER = '" + sn + "'";
            string modelQry = "UPDATE [ALL$] SET MODEL_NUMBER = '' WHERE SERIAL_NUMBER = '" + sn + "'";
            string idQry = "UPDATE [ALL$] SET SMG_ID = '' WHERE SERIAL_NUMBER = '" + sn + "'";
            string userQry = "UPDATE [ALL$] SET USER_NAME = '' WHERE SERIAL_NUMBER = '" + sn + "'";
            string notesQry = "UPDATE [ALL$] SET NOTES = '' WHERE SERIAL_NUMBER = '" + sn + "'";
            string updateQry = "UPDATE [ALL$] SET LAST_UPDATE = '' WHERE SERIAL_NUMBER = '" + sn + "'";

            try
            {
                String connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + Form1.filePath + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=0;MAXSCANROWS=10;READONLY=FALSE;\"";
                OleDbConnection conn = new OleDbConnection(connstr);
                //checking that connection state is closed or not if closed the     
                //open the connection    
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //create command object    
                OleDbCommand invCmd = new OleDbCommand(invQry, conn);
                OleDbCommand locCmd = new OleDbCommand(locQry, conn);
                OleDbCommand snCmd = new OleDbCommand(snQry, conn);
                OleDbCommand brandCmd = new OleDbCommand(brandQry, conn);
                OleDbCommand modelCmd = new OleDbCommand(modelQry, conn);
                OleDbCommand idCmd = new OleDbCommand(idQry, conn);
                OleDbCommand userCmd = new OleDbCommand(userQry, conn);
                OleDbCommand notesCmd = new OleDbCommand(notesQry, conn);
                OleDbCommand updateCmd = new OleDbCommand(updateQry, conn);

                int n = invCmd.ExecuteNonQuery();
                int n2 = locCmd.ExecuteNonQuery();
                int n4 = brandCmd.ExecuteNonQuery();
                int n5 = modelCmd.ExecuteNonQuery();
                int n6 = idCmd.ExecuteNonQuery();
                int n7 = userCmd.ExecuteNonQuery();
                int n8 = notesCmd.ExecuteNonQuery();
                int n9 = updateCmd.ExecuteNonQuery();
                int n3 = snCmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

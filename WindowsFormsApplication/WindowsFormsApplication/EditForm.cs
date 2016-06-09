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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int x = -1;
            disableEmptyFields(x);

            string invQry = "UPDATE [ALL$] SET INVENTORY = '" + invComboBox.Text + "' WHERE SERIAL_NUMBER = '" + Form1.sn + "'";
            string locQry = "UPDATE [ALL$] SET LOCATION = '" + locComboBox.Text + "' WHERE SERIAL_NUMBER = '" + Form1.sn + "'";
            string snQry = "UPDATE [ALL$] SET SERIAL_NUMBER = '" + serialNumBox.Text + "' WHERE SERIAL_NUMBER = '" + Form1.sn + "'";
            string brandQry = "UPDATE [ALL$] SET BRAND = '" + brandComboBox.Text + "' WHERE SERIAL_NUMBER = '" + Form1.sn + "'";
            string modelQry = "UPDATE [ALL$] SET MODEL_NUMBER = '" + modelComboBox.Text + "' WHERE SERIAL_NUMBER = '" + Form1.sn + "'";
            string idQry = "UPDATE [ALL$] SET SMG_ID = '" + idBox.Text + "' WHERE SERIAL_NUMBER = '" + Form1.sn + "'";
            string userQry = "UPDATE [ALL$] SET USER_NAME = '" + userNameBox.Text + "' WHERE SERIAL_NUMBER = '" + Form1.sn + "'";
            string notesQry = "UPDATE [ALL$] SET NOTES = '" + notesBox.Text + "' WHERE SERIAL_NUMBER = '" + Form1.sn + "'";
            string updateQry = "UPDATE [ALL$] SET LAST_UPDATE = '" + DateTime.Now + "' WHERE SERIAL_NUMBER = '" + Form1.sn + "'";

            try
            {
                String connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Form1.filePath + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=0;MAXSCANROWS=10;READONLY=FALSE;\"";
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

                if (invComboBox.Enabled == true) { int n = invCmd.ExecuteNonQuery(); }
                if (locComboBox.Enabled == true) { int n2 = locCmd.ExecuteNonQuery(); }
                if (brandComboBox.Enabled == true) { int n4 = brandCmd.ExecuteNonQuery(); }
                if (modelComboBox.Enabled == true) { int n5 = modelCmd.ExecuteNonQuery(); }
                if (idBox.Enabled == true) { int n6 = idCmd.ExecuteNonQuery(); }
                if (userNameBox.Enabled == true) { int n7 = userCmd.ExecuteNonQuery(); }
                if (notesBox.Enabled == true) { int n8 = notesCmd.ExecuteNonQuery(); }
                int n9 = updateCmd.ExecuteNonQuery();
                if (serialNumBox.Enabled == true) { int n3 = snCmd.ExecuteNonQuery(); }
                
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                        
            Close();
        }
                
        private void EditForm_Load(object sender, EventArgs e)
        {
            invLabelBox.Text = Form1.inv;
            locLabelBox.Text = Form1.loc;
            snLabelBox.Text = Form1.sn;
            brandLabelBox.Text = Form1.brand;
            modelLabelBox.Text = Form1.model;
            idLabelBox.Text = Form1.id;
            userLabelBox.Text = Form1.user;
            notesLabelBox.Text = Form1.notes;
        }

        private int isUnique(string sn)
        {
            string query = "SELECT COUNT(*) FROM [ALL$] WHERE [SERIAL_NUMBER] = '" + sn + "'";

            String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Form1.filePath + ";Extended Properties=\"Excel 12.0;ReadOnly=False;HDR=Yes;\"";
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

        private void disableEmptyFields(int x)
        {
            if (x != 0 & invComboBox.Text == "") { invComboBox.Enabled = false; }
            if (x != 1 & locComboBox.Text == "") { locComboBox.Enabled = false; }
            if (x != 2 & serialNumBox.Text == "") { serialNumBox.Enabled = false; }
            if (x != 3 & brandComboBox.Text == "") { brandComboBox.Enabled = false; }
            if (x != 4 & modelComboBox.Text == "") { modelComboBox.Enabled = false; }
            if (x != 5 & idBox.Text == "") { idBox.Enabled = false; }
            if (x != 6 & userNameBox.Text == "") { userNameBox.Enabled = false; }
            if (x != 7 & notesBox.Text == "") { notesBox.Enabled = false; }
        }

        private void invArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (!invComboBox.Enabled) { invComboBox.Enabled = true; }
            disableEmptyFields(x);
        }

        private void locArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 1;
            if (!locComboBox.Enabled) { locComboBox.Enabled = true; }
            disableEmptyFields(x);
        }     

        private void snArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 2;
            if (!serialNumBox.Enabled) { serialNumBox.Enabled = true; }
            disableEmptyFields(x);
        }

        private void brandArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 3;
            if (!brandComboBox.Enabled) { brandComboBox.Enabled = true; }
            disableEmptyFields(x);
        }

        private void modelArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 4;
            if (!modelComboBox.Enabled) { modelComboBox.Enabled = true; }
            disableEmptyFields(x);
        }

        private void idArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (!idBox.Enabled) { idBox.Enabled = true; }
            disableEmptyFields(x);
        }

        private void userArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 6;
            if (!userNameBox.Enabled) { userNameBox.Enabled = true; }
            disableEmptyFields(x);
        }

        private void notesArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 7;
            if (!notesBox.Enabled) { notesBox.Enabled = true; }
            disableEmptyFields(x);
        }        

        private void checkIfValid()
        {
            int inputResult = isUnique(serialNumBox.Text);

            if (invComboBox.Text != "" || locComboBox.Text != "" || brandComboBox.Text != "" || modelComboBox.Text != "" || idBox.Text != "" || userNameBox.Text != "" || notesBox.Text != "")
            {
                updateButton.Enabled = true;
            }            

            if (inputResult == 0 || serialNumBox.Text == snLabelBox.Text)
            {
                updateButton.Enabled = true;
            }
            else
            {
                updateButton.Enabled = false;
            }

            if (invComboBox.Text == "" & locComboBox.Text == "" & serialNumBox.Text == "" & brandComboBox.Text == "" & modelComboBox.Text == "" & idBox.Text == "" & userNameBox.Text == "" & notesBox.Text == "")
            {
                updateButton.Enabled = false;
            }
        }

        private void serialNumBox_TextChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void invComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void invComboBox_TextChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void locComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void locComboBox_TextChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void brandComboBox_TextChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void modelComboBox_TextChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void notesBox_TextChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            int x = -1;
            invComboBox.Text = ""; locComboBox.Text = ""; serialNumBox.Text = ""; brandComboBox.Text = ""; modelComboBox.Text = ""; idBox.Text = ""; userNameBox.Text = ""; notesBox.Text = "";
            disableEmptyFields(x);
            updateButton.Enabled = false;
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = (Form1)this.Owner;
            form.Enabled = true;
            form.refreshData();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }


}

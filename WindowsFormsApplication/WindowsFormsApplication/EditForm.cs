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
        public static string filePath, inv, loc, area, sn, brand, model, id, user, notes;
        public bool snValid = true;

        public EditForm(string invAttr, string locAttr, string areaAttr, string snAttr, string brandAttr, string modelAttr, string idAttr, string userAttr, string notesAttr)
        {
            InitializeComponent();
            filePath = Form1.filePath;
            inv = invAttr;
            loc = locAttr;
            area = areaAttr;
            sn = snAttr;
            brand = brandAttr;
            model = modelAttr;
            id = idAttr;
            user = userAttr;
            notes = notesAttr;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int x = -1;
            disableEmptyFields(x);

            string invQry = "UPDATE [INVENTORY$] SET INVENTORY = '" + invComboBox.Text + "' WHERE SERIAL_NUMBER = '" + sn + "'";
            string locQry = "UPDATE [INVENTORY$] SET LOCATION = '" + locComboBox.Text + "' WHERE SERIAL_NUMBER = '" + sn + "'";
            string areaQry = "UPDATE [INVENTORY$] SET AREA = '" + areaBox.Text + "' WHERE SERIAL_NUMBER = '" + sn + "'";
            string snQry = "UPDATE [INVENTORY$] SET SERIAL_NUMBER = '" + serialNumBox.Text + "' WHERE SERIAL_NUMBER = '" + sn + "'";
            string brandQry = "UPDATE [INVENTORY$] SET BRAND = '" + brandComboBox.Text + "' WHERE SERIAL_NUMBER = '" + sn + "'";
            string modelQry = "UPDATE [INVENTORY$] SET MODEL_NUMBER = '" + modelComboBox.Text + "' WHERE SERIAL_NUMBER = '" + sn + "'";
            string idQry = "UPDATE [INVENTORY$] SET SMG_ID = '" + idBox.Text + "' WHERE SERIAL_NUMBER = '" + sn + "'";
            string userQry = "UPDATE [INVENTORY$] SET USER_NAME = '" + userNameBox.Text + "' WHERE SERIAL_NUMBER = '" + sn + "'";
            string notesQry = "UPDATE [INVENTORY$] SET NOTES = '" + notesBox.Text + "' WHERE SERIAL_NUMBER = '" + sn + "'";
            string updateQry = "UPDATE [INVENTORY$] SET LAST_UPDATE = '" + DateTime.Now.ToShortDateString() + "' WHERE SERIAL_NUMBER = '" + sn + "'";

            try
            {
                String connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=0;MAXSCANROWS=10;READONLY=FALSE;\"";
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
                OleDbCommand areaCmd = new OleDbCommand(areaQry, conn);
                OleDbCommand snCmd = new OleDbCommand(snQry, conn);
                OleDbCommand brandCmd = new OleDbCommand(brandQry, conn);
                OleDbCommand modelCmd = new OleDbCommand(modelQry, conn);
                OleDbCommand idCmd = new OleDbCommand(idQry, conn);
                OleDbCommand userCmd = new OleDbCommand(userQry, conn);
                OleDbCommand notesCmd = new OleDbCommand(notesQry, conn);
                OleDbCommand updateCmd = new OleDbCommand(updateQry, conn);

                if (invComboBox.Enabled == true) { int n = invCmd.ExecuteNonQuery(); }
                if (locComboBox.Enabled == true) { int n1 = locCmd.ExecuteNonQuery(); }
                if (areaBox.Enabled == true) { int n2 = areaCmd.ExecuteNonQuery(); }
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
            invLabelBox.Text = inv;
            locLabelBox.Text = loc;
            areaLabelBox.Text = area;
            snLabelBox.Text = sn;
            brandLabelBox.Text = brand;
            modelLabelBox.Text = model;
            idLabelBox.Text = id;
            userLabelBox.Text = user;
            notesLabelBox.Text = notes;
        }

        private int isUnique(string sn)
        {
            string query = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [SERIAL_NUMBER] = '" + sn + "'";

            String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;ReadOnly=False;HDR=Yes;\"";
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
            if (x != 0 & invComboBox.SelectedIndex == -1) { invComboBox.Enabled = false; }
            if (x != 1 & locComboBox.SelectedIndex == -1) { locComboBox.Enabled = false; }
            if (x != 2 & areaBox.Text == "") { areaBox.Enabled = false; }
            if (x != 3 & serialNumBox.Text == "") { serialNumBox.Enabled = false; }
            if (x != 4 & brandComboBox.Text == "") { brandComboBox.Enabled = false; }
            if (x != 5 & modelComboBox.Text == "") { modelComboBox.Enabled = false; }
            if (x != 6 & idBox.Text == "") { idBox.Enabled = false; }
            if (x != 7 & userNameBox.Text == "") { userNameBox.Enabled = false; }
            if (x != 8 & notesBox.Text == "") { notesBox.Enabled = false; }
        }

        private void invArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (!invComboBox.Enabled) { invComboBox.Enabled = true; invComboBox.Focus(); }
            disableEmptyFields(x);
        }

        private void locArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 1;
            if (!locComboBox.Enabled) { locComboBox.Enabled = true; locComboBox.Focus(); }
            disableEmptyFields(x);
        }

        private void areaArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 2;
            if (!areaBox.Enabled) { areaBox.Enabled = true; areaBox.Focus(); }
            disableEmptyFields(x);
        }

        private void snArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 3;
            if (!serialNumBox.Enabled) { serialNumBox.Enabled = true; serialNumBox.Focus(); }
            disableEmptyFields(x);
        }

        private void brandArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 4;
            if (!brandComboBox.Enabled) { brandComboBox.Enabled = true; brandComboBox.Focus(); }
            disableEmptyFields(x);
        }

        private void modelArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (!modelComboBox.Enabled) { modelComboBox.Enabled = true; modelComboBox.Focus(); }
            disableEmptyFields(x);
        }

        private void idArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 6;
            if (!idBox.Enabled) { idBox.Enabled = true; idBox.Focus(); }
            disableEmptyFields(x);
        }

        private void userArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 7;
            if (!userNameBox.Enabled) { userNameBox.Enabled = true; userNameBox.Focus(); }
            disableEmptyFields(x);
        }

        private void notesArrowBtn_Click(object sender, EventArgs e)
        {
            int x = 8;
            if (!notesBox.Enabled) { notesBox.Enabled = true; notesBox.Focus(); }
            disableEmptyFields(x);
        }        

        private void checkIfValid()
        {
            if (snValid)
            {
                if (invComboBox.SelectedIndex != -1 || locComboBox.SelectedIndex != -1 || areaBox.Text != "" || brandComboBox.Text != "" || modelComboBox.Text != "" || idBox.Text != "" || userNameBox.Text != "" || notesBox.Text != "")
                {
                    updateButton.Enabled = true;
                }

                if (invComboBox.SelectedIndex == -1 & locComboBox.SelectedIndex == -1 & areaBox.Text == "" & serialNumBox.Text == "" & brandComboBox.Text == "" & modelComboBox.Text == "" & idBox.Text == "" & userNameBox.Text == "" & notesBox.Text == "")
                {
                    updateButton.Enabled = false;
                }
            }
            else
            {
                updateButton.Enabled = false;
            }
            
        }

        private void serialNumBox_TextChanged(object sender, EventArgs e)
        {
            var snText = serialNumBox.Text;

            if(snText == "")
            {
                snValid = true;
                checkIfValid();
            }
            else
            {
                int inputResult = isUnique(snText);

                if (inputResult == 0 || snText == snLabelBox.Text)
                {
                    snValid = true;
                }
                else
                {
                    snValid = false;
                }
                checkIfValid();
            }        
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

        private void areaBox_TextChanged(object sender, EventArgs e)
        {
            checkIfValid();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            invComboBox.SelectedIndex = -1;
            locComboBox.SelectedIndex = -1;
            areaBox.Text = "";
            serialNumBox.Text = "";
            brandComboBox.Text = "";
            modelComboBox.Text = "";
            idBox.Text = "";
            userNameBox.Text = "";
            notesBox.Text = "";

            invComboBox.Enabled = false;
            locComboBox.Enabled = false; 
            areaBox.Enabled = false; 
            serialNumBox.Enabled = false; 
            brandComboBox.Enabled = false;
            modelComboBox.Enabled = false; 
            idBox.Enabled = false;
            userNameBox.Enabled = false;
            notesBox.Enabled = false;

            checkIfValid();
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

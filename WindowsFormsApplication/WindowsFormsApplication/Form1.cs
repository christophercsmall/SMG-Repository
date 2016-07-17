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
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;";
            openFileDialog1.ShowDialog();

            tabControl1.SelectTab(0);

            if (filePath != null) 
            {
                try
                {
                    var query = "SELECT * FROM [INVENTORY$] WHERE [SERIAL_NUMBER] <> '-';";
                    var countQuery = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [SERIAL_NUMBER] <> '-';";

                    totalLabel.Text = load(query, countQuery).ToString();
                    dataGridView1.Sort(dataGridView1.Columns["LAST_UPDATE"], ListSortDirection.Descending);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File Containes Invalid Header Format \n\n" + ex.ToString());
                }                
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox.Clear();
            refreshData();
        }

        private void loadUserBtns()
        {
            List<string> areaList = new List<string>();
            var text = "";

            var tabIndex = tabControl1.SelectedIndex;

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            flowLayoutPanel4.Controls.Clear();
            flowLayoutPanel5.Controls.Clear();
            flowLayoutPanel6.Controls.Clear();
            flowLayoutPanel7.Controls.Clear();
            flowLayoutPanel8.Controls.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                text = row.Cells["AREA"].Value.ToString();    

                if (!areaList.Contains(text))
                {
                    areaList.Add(text);
                }                
            }

            areaList = areaList.OrderBy(n => n).ToList();

            foreach (var area in areaList)
            {
                switch (tabIndex)
                {
                    case 0:
                        flowLayoutPanel1.Controls.Add(createAreaBtn(area));
                        break;
                    case 1:
                        flowLayoutPanel2.Controls.Add(createAreaBtn(area));
                        break;
                    case 2:
                        flowLayoutPanel3.Controls.Add(createAreaBtn(area));
                        break;
                    case 3:
                        flowLayoutPanel4.Controls.Add(createAreaBtn(area));
                        break;
                    case 4:
                        flowLayoutPanel5.Controls.Add(createAreaBtn(area));
                        break;
                    case 5:
                        flowLayoutPanel6.Controls.Add(createAreaBtn(area));
                        break;
                    case 6:
                        flowLayoutPanel7.Controls.Add(createAreaBtn(area));
                        break;
                    case 7:
                        flowLayoutPanel8.Controls.Add(createAreaBtn(area));
                        break;
                }
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            var qry = "";
            var countQry = "";
            var tab = tabControl1.SelectedTab.Text;
            var text = searchBox.Text.ToString();

            if (text == "")
            {
                refreshData();
            }
            else
            {
                if (tab == "ALL")
                {
                    qry = "SELECT * FROM [INVENTORY$] WHERE ([INVENTORY] LIKE '%" + text + "%' OR [AREA] LIKE '%" + text + "%' OR [SERIAL_NUMBER] LIKE '%" + text + "%' OR [BRAND] LIKE '%" + text + "%' OR [MODEL_NUMBER] LIKE '%" + text + "%' OR [SMG_ID] LIKE '%" + text + "%' OR [USER_NAME] LIKE '%" + text + "%' OR [NOTES] LIKE '%" + text + "%'); ";
                    countQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE ([INVENTORY] LIKE '%" + text + "%' OR [AREA] LIKE '%" + text + "%' OR [SERIAL_NUMBER] LIKE '%" + text + "%' OR [BRAND] LIKE '%" + text + "%' OR [MODEL_NUMBER] LIKE '%" + text + "%' OR [SMG_ID] LIKE '%" + text + "%' OR [USER_NAME] LIKE '%" + text + "%' OR [NOTES] LIKE '%" + text + "%'); ";
                }
                else
                {
                    qry = "SELECT * FROM [INVENTORY$] WHERE [LOCATION] = '" + tab + "' AND ([INVENTORY] LIKE '%" + text + "%' OR [AREA] LIKE '%" + text + "%' OR [SERIAL_NUMBER] LIKE '%" + text + "%' OR [BRAND] LIKE '%" + text + "%' OR [MODEL_NUMBER] LIKE '%" + text + "%' OR [SMG_ID] LIKE '%" + text + "%' OR [USER_NAME] LIKE '%" + text + "%' OR [NOTES] LIKE '%" + text + "%'); ";
                    countQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [LOCATION] = '" + tab + "' AND ([INVENTORY] LIKE '%" + text + "%' OR [AREA] LIKE '%" + text + "%' OR [SERIAL_NUMBER] LIKE '%" + text + "%' OR [BRAND] LIKE '%" + text + "%' OR [MODEL_NUMBER] LIKE '%" + text + "%' OR [SMG_ID] LIKE '%" + text + "%' OR [USER_NAME] LIKE '%" + text + "%' OR [NOTES] LIKE '%" + text + "%'); ";                    
                }
                totalLabel.Text = load(qry, countQry).ToString();
            }
        }

        private Button createAreaBtn(string text)
        {   
            Button Btn = new Button();
            Btn.Text = text;
            Btn.AutoSize = true;            
            Btn.FlatStyle = FlatStyle.System;

            Btn.Click += (s, e) => { createBtnQuery(text); };
            return Btn;
        }

        private void createBtnQuery(string text)
        {
            var qry = "";
            var cntQry = "";
            var tabName = tabControl1.SelectedTab.Text;
            
            if (tabName == "ALL")
            {
                if (text == "")
                {
                    qry = "SELECT * FROM [INVENTORY$] WHERE [AREA] IS NULL AND [SERIAL_NUMBER] <> '-';";
                    cntQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [AREA] IS NULL AND [SERIAL_NUMBER] <> '-';";
                }
                else
                {
                    qry = "SELECT * FROM [INVENTORY$] WHERE [AREA] = '" + text + "' AND [SERIAL_NUMBER] <> '-';";
                    cntQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [AREA] = '" + text + "' AND [SERIAL_NUMBER] <> '-';";
                }                
            }
            else
            {
                if (text == "")
                {
                    qry = "SELECT * FROM [INVENTORY$] WHERE [AREA] IS NULL AND [LOCATION] = '"+ tabName +"';";
                    cntQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [AREA] IS NULL AND [LOCATION] = '" + tabName + "';";
                }
                else
                {
                    qry = "SELECT * FROM [INVENTORY$] WHERE [AREA] = '" + text + "' AND [LOCATION] = '" + tabName + "';";
                    cntQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [AREA] = '" + text + "' AND [LOCATION] = '" + tabName + "';";
                }                
            }           

            totalLabel.Text = load(qry, cntQry).ToString();
            
        }

        private int load(String query, String countQuery)
        {
            int n = 0;
            OleDbCommand cmd = new OleDbCommand();
            OleDbCommand countCmd = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=0;MAXSCANROWS=10;READONLY=FALSE;\""; //IMEX=0;MAXSCANROWS=10;
            OleDbConnection conn = new OleDbConnection(connString);
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    cmd = new OleDbCommand(query, conn);
                    countCmd = new OleDbCommand(countQuery, conn);
                    da = new OleDbDataAdapter(cmd);
                    da.Fill(ds);
                    n = (int)countCmd.ExecuteScalar();
                    addButton.Enabled = true;
                    editButton.Enabled = true;
                    deleteButton.Enabled = true;
                    searchBox.Enabled = true;
                }
                catch (Exception ex)
                {
                    //Exception
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel2.Controls.Clear();
                    flowLayoutPanel3.Controls.Clear();
                    flowLayoutPanel4.Controls.Clear();
                    flowLayoutPanel5.Controls.Clear();
                    flowLayoutPanel6.Controls.Clear();
                    flowLayoutPanel7.Controls.Clear();
                    flowLayoutPanel8.Controls.Clear();
                    dataGridView1.DataSource = null;
                    filePathLabel.Visible = false;
                    filePath = null;
                    filePathLabel.Text = "";
                    totalLabel.Text = "- - -";
                    lastUpdateLabel.Text = "- - -";
                    addButton.Enabled = false;
                    editButton.Enabled = false;
                    deleteButton.Enabled = false;
                    searchBox.Enabled = false;
                    MessageBox.Show("An error occured while trying to process this file. \n\n" + ex);
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
                    loadUserBtns();
                }
            }
            dataGridView1.Sort(dataGridView1.Columns["LAST_UPDATE"], ListSortDirection.Descending);
            if (dataGridView1.RowCount > 0)
            {
                lastUpdateLabel.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
            }
            return n;
        }

        private void addButton_Click(object sender, EventArgs e)
        {            
            AddForm form = new AddForm();
            form.Owner = this;
            form.Show();
            this.Enabled = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[2].RowIndex;

                var inv = dataGridView1.Rows[selectedrowindex].Cells[0].Value.ToString();
                var loc = dataGridView1.Rows[selectedrowindex].Cells[1].Value.ToString();
                var area = dataGridView1.Rows[selectedrowindex].Cells[2].Value.ToString();
                var sn = dataGridView1.Rows[selectedrowindex].Cells[3].Value.ToString();
                var brand = dataGridView1.Rows[selectedrowindex].Cells[4].Value.ToString();
                var model = dataGridView1.Rows[selectedrowindex].Cells[5].Value.ToString();
                var id = dataGridView1.Rows[selectedrowindex].Cells[6].Value.ToString();
                var user = dataGridView1.Rows[selectedrowindex].Cells[7].Value.ToString();
                var notes = dataGridView1.Rows[selectedrowindex].Cells[8].Value.ToString();

                EditForm form = new EditForm(inv, loc, area, sn, brand, model, id, user, notes);
                form.Owner = this;
                form.Show();
                this.Enabled = false;
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                DialogResult ans = MessageBox.Show("Delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (ans == DialogResult.Yes)
                {

                    int selectedrowindex = dataGridView1.SelectedCells[2].RowIndex;

                    var inv = dataGridView1.Rows[selectedrowindex].Cells[0].Value.ToString();
                    var loc = dataGridView1.Rows[selectedrowindex].Cells[1].Value.ToString();
                    var area = dataGridView1.Rows[selectedrowindex].Cells[2].Value.ToString();
                    var sn = dataGridView1.Rows[selectedrowindex].Cells[3].Value.ToString();
                    var brand = dataGridView1.Rows[selectedrowindex].Cells[4].Value.ToString();
                    var model = dataGridView1.Rows[selectedrowindex].Cells[5].Value.ToString();
                    var id = dataGridView1.Rows[selectedrowindex].Cells[6].Value.ToString();
                    var user = dataGridView1.Rows[selectedrowindex].Cells[7].Value.ToString();
                    var notes = dataGridView1.Rows[selectedrowindex].Cells[8].Value.ToString();

                    string selectedRecordString = "[" + inv + "] " + "[" + loc + "] " + "[" + area + "] " + "[" + sn + "] " + "[" + brand + "] " + "[" + model + "] " + "[" + id + "] " + "[" + user + "] " + "[" + notes + "] ";
                    string invQry = "UPDATE [INVENTORY$] SET INVENTORY = '-' WHERE SERIAL_NUMBER = '" + sn + "'";
                    string locQry = "UPDATE [INVENTORY$] SET LOCATION = '-' WHERE SERIAL_NUMBER = '" + sn + "'";
                    string areaQry = "UPDATE [INVENTORY$] SET AREA = '-' WHERE SERIAL_NUMBER = '" + sn + "'";
                    string snQry = "UPDATE [INVENTORY$] SET SERIAL_NUMBER = '-' WHERE SERIAL_NUMBER = '" + sn + "'";
                    string brandQry = "UPDATE [INVENTORY$] SET BRAND = '-' WHERE SERIAL_NUMBER = '" + sn + "'";
                    string modelQry = "UPDATE [INVENTORY$] SET MODEL_NUMBER = '-' WHERE SERIAL_NUMBER = '" + sn + "'";
                    string idQry = "UPDATE [INVENTORY$] SET SMG_ID = '-' WHERE SERIAL_NUMBER = '" + sn + "'";
                    string userQry = "UPDATE [INVENTORY$] SET USER_NAME = '-' WHERE SERIAL_NUMBER = '" + sn + "'";
                    string notesQry = "UPDATE [INVENTORY$] SET NOTES = '-' WHERE SERIAL_NUMBER = '" + sn + "'";
                    string updateQry = "UPDATE [INVENTORY$] SET LAST_UPDATE = '-' WHERE SERIAL_NUMBER = '" + sn + "'";

                    this.Enabled = false;

                    try
                    {
                        String connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=0;MAXSCANROWS=10;READONLY=FALSE;\""; //IMEX=0;MAXSCANROWS=10;
                        OleDbConnection conn = new OleDbConnection(connstr);

                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        //create command object    
                        OleDbCommand invCmd = new OleDbCommand(invQry, conn);
                        OleDbCommand locCmd = new OleDbCommand(locQry, conn);
                        OleDbCommand areaCmd = new OleDbCommand(areaQry, conn);
                        OleDbCommand brandCmd = new OleDbCommand(brandQry, conn);
                        OleDbCommand modelCmd = new OleDbCommand(modelQry, conn);
                        OleDbCommand idCmd = new OleDbCommand(idQry, conn);
                        OleDbCommand userCmd = new OleDbCommand(userQry, conn);
                        OleDbCommand notesCmd = new OleDbCommand(notesQry, conn);
                        OleDbCommand updateCmd = new OleDbCommand(updateQry, conn);
                        OleDbCommand snCmd = new OleDbCommand(snQry, conn);

                        int n = invCmd.ExecuteNonQuery();
                        int n1 = locCmd.ExecuteNonQuery();
                        int n2 = areaCmd.ExecuteNonQuery();
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

                    this.Enabled = true;
                    refreshData();
                }
            }
            else { deleteButton.Enabled = false; }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void refreshData()
        {
            var qry = "";
            var countQry = "";

            var tab = tabControl1.SelectedTab.Text;
            var searchText = searchBox.Text.ToString();

            if (filePath != null)
            {                
                if (searchText == "")
                {
                    switch (tab)
                    {
                        case "ALL":
                            qry = "SELECT * FROM [INVENTORY$] WHERE [LOCATION] <> '-'";
                            countQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [LOCATION] <> '-'";
                            break;
                        case "STADIUM":
                            qry = "SELECT * FROM [INVENTORY$] WHERE [LOCATION] = 'STADIUM'";
                            countQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [LOCATION] = 'STADIUM'";
                            break;
                        case "ARENA":
                            qry = "SELECT * FROM [INVENTORY$] WHERE [LOCATION] = 'ARENA'";
                            countQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [LOCATION] = 'ARENA'";
                            break;
                        case "TUCPA":
                            qry = "SELECT * FROM [INVENTORY$] WHERE [LOCATION] = 'TUCPA'";
                            countQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [LOCATION] = 'TUCPA'";
                            break;
                        case "POCC":
                            qry = "SELECT * FROM [INVENTORY$] WHERE [LOCATION] = 'POCC'";
                            countQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [LOCATION] = 'POCC'";
                            break;
                        case "RITZ":
                            qry = "SELECT * FROM [INVENTORY$] WHERE [LOCATION] = 'RITZ'";
                            countQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [LOCATION] = 'RITZ'";
                            break;
                        case "BALLPARK":
                            qry = "SELECT * FROM [INVENTORY$] WHERE [LOCATION] = 'BALLPARK'";
                            countQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [LOCATION] = 'BALLPARK'";
                            break;
                        case "STORAGE":
                            qry = "SELECT * FROM [INVENTORY$] WHERE [LOCATION] = 'STORAGE'";
                            countQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [LOCATION] = 'STORAGE'";
                            break;
                    }
                }
                else
                {
                    if (tab == "ALL")
                    {
                        qry = "SELECT * FROM [INVENTORY$] WHERE ([INVENTORY] LIKE '%" + searchText + "%' OR [AREA] LIKE '%" + searchText + "%' OR [SERIAL_NUMBER] LIKE '%" + searchText + "%' OR [BRAND] LIKE '%" + searchText + "%' OR [MODEL_NUMBER] LIKE '%" + searchText + "%' OR [SMG_ID] LIKE '%" + searchText + "%' OR [USER_NAME] LIKE '%" + searchText + "%' OR [NOTES] LIKE '%" + searchText + "%'); ";
                        countQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE ([INVENTORY] LIKE '%" + searchText + "%' OR [AREA] LIKE '%" + searchText + "%' OR [SERIAL_NUMBER] LIKE '%" + searchText + "%' OR [BRAND] LIKE '%" + searchText + "%' OR [MODEL_NUMBER] LIKE '%" + searchText + "%' OR [SMG_ID] LIKE '%" + searchText + "%' OR [USER_NAME] LIKE '%" + searchText + "%' OR [NOTES] LIKE '%" + searchText + "%'); ";
                    }
                    else
                    {
                        qry = "SELECT * FROM [INVENTORY$] WHERE [LOCATION] = '" + tab + "' AND ([INVENTORY] LIKE '%" + searchText + "%' OR [AREA] LIKE '%" + searchText + "%' OR [SERIAL_NUMBER] LIKE '%" + searchText + "%' OR [BRAND] LIKE '%" + searchText + "%' OR [MODEL_NUMBER] LIKE '%" + searchText + "%' OR [SMG_ID] LIKE '%" + searchText + "%' OR [USER_NAME] LIKE '%" + searchText + "%' OR [NOTES] LIKE '%" + searchText + "%'); ";
                        countQry = "SELECT COUNT(*) FROM [INVENTORY$] WHERE [LOCATION] = '" + tab + "' AND ([INVENTORY] LIKE '%" + searchText + "%' OR [AREA] LIKE '%" + searchText + "%' OR [SERIAL_NUMBER] LIKE '%" + searchText + "%' OR [BRAND] LIKE '%" + searchText + "%' OR [MODEL_NUMBER] LIKE '%" + searchText + "%' OR [SMG_ID] LIKE '%" + searchText + "%' OR [USER_NAME] LIKE '%" + searchText + "%' OR [NOTES] LIKE '%" + searchText + "%'); ";
                    }
                }
                totalLabel.Text = load(qry, countQry).ToString();
            }
        }
    }
}

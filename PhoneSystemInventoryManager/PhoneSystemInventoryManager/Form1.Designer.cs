namespace PhoneSystemInventoryManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.query2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciscoPhoneSystemDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciscoPhoneSystemDBDataSet = new PhoneSystemInventoryManager.CiscoPhoneSystemDBDataSet();
            this.query2TableAdapter = new PhoneSystemInventoryManager.CiscoPhoneSystemDBDataSetTableAdapters.Query2TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNSNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.switchPortNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patchPanelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patchPanelPortNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.query2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.query2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciscoPhoneSystemDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciscoPhoneSystemDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.query2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.fileToolStripMenuItem.Text = "Connect...";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "User Name",
            "Company",
            "Extension",
            "Phone MAC",
            "Phone Type",
            "IDF Name",
            "Switch Name (DNS)",
            "Patch Panel Name"});
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(408, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(161, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 5;
            // 
            // query2BindingSource
            // 
            this.query2BindingSource.DataMember = "Query2";
            this.query2BindingSource.DataSource = this.ciscoPhoneSystemDBDataSetBindingSource;
            // 
            // ciscoPhoneSystemDBDataSetBindingSource
            // 
            this.ciscoPhoneSystemDBDataSetBindingSource.DataSource = this.ciscoPhoneSystemDBDataSet;
            this.ciscoPhoneSystemDBDataSetBindingSource.Position = 0;
            // 
            // ciscoPhoneSystemDBDataSet
            // 
            this.ciscoPhoneSystemDBDataSet.DataSetName = "CiscoPhoneSystemDBDataSet";
            this.ciscoPhoneSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // query2TableAdapter
            // 
            this.query2TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 338);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.extensionNumDataGridViewTextBoxColumn,
            this.mACDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.iDFNameDataGridViewTextBoxColumn,
            this.dNSNameDataGridViewTextBoxColumn,
            this.switchPortNumDataGridViewTextBoxColumn,
            this.patchPanelNameDataGridViewTextBoxColumn,
            this.patchPanelPortNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.query2BindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "FName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "LName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            this.companyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extensionNumDataGridViewTextBoxColumn
            // 
            this.extensionNumDataGridViewTextBoxColumn.DataPropertyName = "ExtensionNum";
            this.extensionNumDataGridViewTextBoxColumn.HeaderText = "ExtensionNum";
            this.extensionNumDataGridViewTextBoxColumn.Name = "extensionNumDataGridViewTextBoxColumn";
            this.extensionNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mACDataGridViewTextBoxColumn
            // 
            this.mACDataGridViewTextBoxColumn.DataPropertyName = "MAC";
            this.mACDataGridViewTextBoxColumn.HeaderText = "MAC";
            this.mACDataGridViewTextBoxColumn.Name = "mACDataGridViewTextBoxColumn";
            this.mACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDFNameDataGridViewTextBoxColumn
            // 
            this.iDFNameDataGridViewTextBoxColumn.DataPropertyName = "IDFName";
            this.iDFNameDataGridViewTextBoxColumn.HeaderText = "IDFName";
            this.iDFNameDataGridViewTextBoxColumn.Name = "iDFNameDataGridViewTextBoxColumn";
            this.iDFNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dNSNameDataGridViewTextBoxColumn
            // 
            this.dNSNameDataGridViewTextBoxColumn.DataPropertyName = "DNSName";
            this.dNSNameDataGridViewTextBoxColumn.HeaderText = "DNSName";
            this.dNSNameDataGridViewTextBoxColumn.Name = "dNSNameDataGridViewTextBoxColumn";
            this.dNSNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // switchPortNumDataGridViewTextBoxColumn
            // 
            this.switchPortNumDataGridViewTextBoxColumn.DataPropertyName = "SwitchPortNum";
            this.switchPortNumDataGridViewTextBoxColumn.HeaderText = "SwitchPortNum";
            this.switchPortNumDataGridViewTextBoxColumn.Name = "switchPortNumDataGridViewTextBoxColumn";
            this.switchPortNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patchPanelNameDataGridViewTextBoxColumn
            // 
            this.patchPanelNameDataGridViewTextBoxColumn.DataPropertyName = "PatchPanelName";
            this.patchPanelNameDataGridViewTextBoxColumn.HeaderText = "PatchPanelName";
            this.patchPanelNameDataGridViewTextBoxColumn.Name = "patchPanelNameDataGridViewTextBoxColumn";
            this.patchPanelNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patchPanelPortNumDataGridViewTextBoxColumn
            // 
            this.patchPanelPortNumDataGridViewTextBoxColumn.DataPropertyName = "PatchPanelPortNum";
            this.patchPanelPortNumDataGridViewTextBoxColumn.HeaderText = "PatchPanelPortNum";
            this.patchPanelPortNumDataGridViewTextBoxColumn.Name = "patchPanelPortNumDataGridViewTextBoxColumn";
            this.patchPanelPortNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // query2BindingSource1
            // 
            this.query2BindingSource1.DataMember = "Query2";
            this.query2BindingSource1.DataSource = this.ciscoPhoneSystemDBDataSetBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.query2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciscoPhoneSystemDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciscoPhoneSystemDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.query2BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource ciscoPhoneSystemDBDataSetBindingSource;
        private CiscoPhoneSystemDBDataSet ciscoPhoneSystemDBDataSet;
        private System.Windows.Forms.BindingSource query2BindingSource;
        private CiscoPhoneSystemDBDataSetTableAdapters.Query2TableAdapter query2TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNSNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn switchPortNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patchPanelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patchPanelPortNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource query2BindingSource1;
    }
}


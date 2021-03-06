﻿namespace PhoneSystemInventoryManager
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeJackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.venueSpaceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.venueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.assignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneToUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchToSwitchToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.officeJackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patchPanelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venueSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.connectedLabel = new System.Windows.Forms.Label();
            this.dbLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recordsCountLabel = new System.Windows.Forms.Label();
            this.phoneToOfficeJackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchPanelPortToSwitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePhoneToUsertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePhoneToOfficeJacktoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePatchPanelPortToSwitchPorttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.fileToolStripMenuItem.Text = "Database Connect...";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDatabaseToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exportVisibleToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // backupDatabaseToolStripMenuItem
            // 
            this.backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            this.backupDatabaseToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.backupDatabaseToolStripMenuItem.Text = "Backup Database...";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.settingsToolStripMenuItem.Text = "Export All Records";
            // 
            // exportVisibleToolStripMenuItem
            // 
            this.exportVisibleToolStripMenuItem.Name = "exportVisibleToolStripMenuItem";
            this.exportVisibleToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exportVisibleToolStripMenuItem.Text = "Export Visible";
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.runToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createNewToolStripMenuItem.Text = "Create New";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.runToolStripMenuItem.Text = "Run...";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem1,
            this.assignToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.addToolStripMenuItem.Text = "Records";
            // 
            // createNewToolStripMenuItem1
            // 
            this.createNewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.phoneToolStripMenuItem,
            this.officeJackToolStripMenuItem,
            this.switchToolStripMenuItem,
            this.patchPanelToolStripMenuItem,
            this.iDFToolStripMenuItem1,
            this.venueSpaceToolStripMenuItem1,
            this.venueToolStripMenuItem1});
            this.createNewToolStripMenuItem1.Enabled = false;
            this.createNewToolStripMenuItem1.Name = "createNewToolStripMenuItem1";
            this.createNewToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.createNewToolStripMenuItem1.Text = "Create New";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // phoneToolStripMenuItem
            // 
            this.phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
            this.phoneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.phoneToolStripMenuItem.Text = "Phone";
            this.phoneToolStripMenuItem.Click += new System.EventHandler(this.phoneToolStripMenuItem_Click);
            // 
            // officeJackToolStripMenuItem
            // 
            this.officeJackToolStripMenuItem.Name = "officeJackToolStripMenuItem";
            this.officeJackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.officeJackToolStripMenuItem.Text = "Office Jack";
            this.officeJackToolStripMenuItem.Click += new System.EventHandler(this.officeJackToolStripMenuItem_Click);
            // 
            // switchToolStripMenuItem
            // 
            this.switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            this.switchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.switchToolStripMenuItem.Text = "Switch";
            this.switchToolStripMenuItem.Click += new System.EventHandler(this.switchToolStripMenuItem_Click);
            // 
            // patchPanelToolStripMenuItem
            // 
            this.patchPanelToolStripMenuItem.Name = "patchPanelToolStripMenuItem";
            this.patchPanelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.patchPanelToolStripMenuItem.Text = "Patch Panel";
            this.patchPanelToolStripMenuItem.Click += new System.EventHandler(this.patchPanelToolStripMenuItem_Click);
            // 
            // iDFToolStripMenuItem1
            // 
            this.iDFToolStripMenuItem1.Name = "iDFToolStripMenuItem1";
            this.iDFToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.iDFToolStripMenuItem1.Text = "IDF";
            this.iDFToolStripMenuItem1.Click += new System.EventHandler(this.iDFToolStripMenuItem1_Click);
            // 
            // venueSpaceToolStripMenuItem1
            // 
            this.venueSpaceToolStripMenuItem1.Name = "venueSpaceToolStripMenuItem1";
            this.venueSpaceToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.venueSpaceToolStripMenuItem1.Text = "Venue Space";
            this.venueSpaceToolStripMenuItem1.Click += new System.EventHandler(this.venueSpaceToolStripMenuItem1_Click);
            // 
            // venueToolStripMenuItem1
            // 
            this.venueToolStripMenuItem1.Name = "venueToolStripMenuItem1";
            this.venueToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.venueToolStripMenuItem1.Text = "Venue";
            this.venueToolStripMenuItem1.Click += new System.EventHandler(this.venueToolStripMenuItem1_Click);
            // 
            // assignToolStripMenuItem
            // 
            this.assignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phoneToUserToolStripMenuItem,
            this.phoneToOfficeJackToolStripMenuItem,
            this.patchPanelPortToSwitchToolStripMenuItem});
            this.assignToolStripMenuItem.Enabled = false;
            this.assignToolStripMenuItem.Name = "assignToolStripMenuItem";
            this.assignToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.assignToolStripMenuItem.Text = "Assign";
            // 
            // phoneToUserToolStripMenuItem
            // 
            this.phoneToUserToolStripMenuItem.Name = "phoneToUserToolStripMenuItem";
            this.phoneToUserToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.phoneToUserToolStripMenuItem.Text = "Phone -> User";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Edit";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "User";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "Phone";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "Office Jack";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem6.Text = "Switch";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem7.Text = "Patch Panel";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem8.Text = "IDF";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem9.Text = "Venue Space";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem10.Text = "Venue";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patchToSwitchToolStripMenuItem2,
            this.phoneToolStripMenuItem1,
            this.officeJackToolStripMenuItem1,
            this.switchToolStripMenuItem1,
            this.patchPanelToolStripMenuItem1,
            this.iDFToolStripMenuItem,
            this.venueSpaceToolStripMenuItem,
            this.venueToolStripMenuItem,
            this.toolStripSeparator1,
            this.DeletePhoneToUsertoolStripMenuItem,
            this.DeletePhoneToOfficeJacktoolStripMenuItem,
            this.DeletePatchPanelPortToSwitchPorttoolStripMenuItem});
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // patchToSwitchToolStripMenuItem2
            // 
            this.patchToSwitchToolStripMenuItem2.Name = "patchToSwitchToolStripMenuItem2";
            this.patchToSwitchToolStripMenuItem2.Size = new System.Drawing.Size(240, 22);
            this.patchToSwitchToolStripMenuItem2.Text = "User";
            // 
            // phoneToolStripMenuItem1
            // 
            this.phoneToolStripMenuItem1.Name = "phoneToolStripMenuItem1";
            this.phoneToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.phoneToolStripMenuItem1.Text = "Phone";
            // 
            // officeJackToolStripMenuItem1
            // 
            this.officeJackToolStripMenuItem1.Name = "officeJackToolStripMenuItem1";
            this.officeJackToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.officeJackToolStripMenuItem1.Text = "Office Jack";
            // 
            // switchToolStripMenuItem1
            // 
            this.switchToolStripMenuItem1.Name = "switchToolStripMenuItem1";
            this.switchToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.switchToolStripMenuItem1.Text = "Switch";
            // 
            // patchPanelToolStripMenuItem1
            // 
            this.patchPanelToolStripMenuItem1.Name = "patchPanelToolStripMenuItem1";
            this.patchPanelToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.patchPanelToolStripMenuItem1.Text = "Patch Panel";
            // 
            // iDFToolStripMenuItem
            // 
            this.iDFToolStripMenuItem.Name = "iDFToolStripMenuItem";
            this.iDFToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.iDFToolStripMenuItem.Text = "IDF";
            // 
            // venueSpaceToolStripMenuItem
            // 
            this.venueSpaceToolStripMenuItem.Name = "venueSpaceToolStripMenuItem";
            this.venueSpaceToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.venueSpaceToolStripMenuItem.Text = "Venue Space";
            // 
            // venueToolStripMenuItem
            // 
            this.venueToolStripMenuItem.Name = "venueToolStripMenuItem";
            this.venueToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.venueToolStripMenuItem.Text = "Venue";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ALL",
            "User Name",
            "Company",
            "Extension",
            "Phone MAC",
            "Phone Type",
            "IDF Name",
            "Switch Name (DNS)",
            "Patch Panel Name"});
            this.comboBox1.Location = new System.Drawing.Point(576, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.searchBtn.Location = new System.Drawing.Point(881, 27);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(150, 48);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(576, 54);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(299, 20);
            this.searchBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 338);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 338);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Database:";
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.BackColor = System.Drawing.Color.Red;
            this.connectedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.connectedLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedLabel.ForeColor = System.Drawing.Color.White;
            this.connectedLabel.Location = new System.Drawing.Point(74, 35);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(93, 15);
            this.connectedLabel.TabIndex = 8;
            this.connectedLabel.Text = "No Connection";
            this.connectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbLabel
            // 
            this.dbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dbLabel.AutoSize = true;
            this.dbLabel.Location = new System.Drawing.Point(12, 57);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(0, 13);
            this.dbLabel.TabIndex = 9;
            this.dbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Records: ";
            // 
            // recordsCountLabel
            // 
            this.recordsCountLabel.AutoSize = true;
            this.recordsCountLabel.Location = new System.Drawing.Point(72, 428);
            this.recordsCountLabel.Name = "recordsCountLabel";
            this.recordsCountLabel.Size = new System.Drawing.Size(0, 13);
            this.recordsCountLabel.TabIndex = 11;
            // 
            // phoneToOfficeJackToolStripMenuItem
            // 
            this.phoneToOfficeJackToolStripMenuItem.Name = "phoneToOfficeJackToolStripMenuItem";
            this.phoneToOfficeJackToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.phoneToOfficeJackToolStripMenuItem.Text = "Phone -> Office Jack";
            // 
            // patchPanelPortToSwitchToolStripMenuItem
            // 
            this.patchPanelPortToSwitchToolStripMenuItem.Name = "patchPanelPortToSwitchToolStripMenuItem";
            this.patchPanelPortToSwitchToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.patchPanelPortToSwitchToolStripMenuItem.Text = "Patch Panel Port -> Switch Port";
            this.patchPanelPortToSwitchToolStripMenuItem.Click += new System.EventHandler(this.patchPanelPortToSwitchToolStripMenuItem_Click);
            // 
            // DeletePhoneToUsertoolStripMenuItem
            // 
            this.DeletePhoneToUsertoolStripMenuItem.Name = "DeletePhoneToUsertoolStripMenuItem";
            this.DeletePhoneToUsertoolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.DeletePhoneToUsertoolStripMenuItem.Text = "Phone -> User";
            // 
            // DeletePhoneToOfficeJacktoolStripMenuItem
            // 
            this.DeletePhoneToOfficeJacktoolStripMenuItem.Name = "DeletePhoneToOfficeJacktoolStripMenuItem";
            this.DeletePhoneToOfficeJacktoolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.DeletePhoneToOfficeJacktoolStripMenuItem.Text = "Phone -> Office Jack";
            // 
            // DeletePatchPanelPortToSwitchPorttoolStripMenuItem
            // 
            this.DeletePatchPanelPortToSwitchPorttoolStripMenuItem.Name = "DeletePatchPanelPortToSwitchPorttoolStripMenuItem";
            this.DeletePatchPanelPortToSwitchPorttoolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.DeletePatchPanelPortToSwitchPorttoolStripMenuItem.Text = "Patch Panel Port -> Switch Port";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1043, 448);
            this.Controls.Add(this.recordsCountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbLabel);
            this.Controls.Add(this.connectedLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Phone System Inventory Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem backupDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patchPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officeJackToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label connectedLabel;
        private System.Windows.Forms.Label dbLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label recordsCountLabel;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patchToSwitchToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem iDFToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem venueSpaceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem venueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem assignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneToUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem officeJackToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patchPanelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venueSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem phoneToOfficeJackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patchPanelPortToSwitchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletePhoneToUsertoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletePhoneToOfficeJacktoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletePatchPanelPortToSwitchPorttoolStripMenuItem;
    }
}


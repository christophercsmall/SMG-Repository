namespace PhoneSystemInventoryManager
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
            this.switchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchToSwitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeJackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.connectedLabel = new System.Windows.Forms.Label();
            this.dbLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recordsCountLabel = new System.Windows.Forms.Label();
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
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.createNewToolStripMenuItem.Text = "Create New";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.runToolStripMenuItem.Text = "Run...";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem1});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.addToolStripMenuItem.Text = "Records";
            // 
            // createNewToolStripMenuItem1
            // 
            this.createNewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.phoneToolStripMenuItem,
            this.switchToolStripMenuItem,
            this.patchPanelToolStripMenuItem,
            this.patchToSwitchToolStripMenuItem,
            this.officeJackToolStripMenuItem});
            this.createNewToolStripMenuItem1.Name = "createNewToolStripMenuItem1";
            this.createNewToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.createNewToolStripMenuItem1.Text = "Create New";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // phoneToolStripMenuItem
            // 
            this.phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
            this.phoneToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.phoneToolStripMenuItem.Text = "Phone";
            // 
            // switchToolStripMenuItem
            // 
            this.switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            this.switchToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.switchToolStripMenuItem.Text = "Switch";
            // 
            // patchPanelToolStripMenuItem
            // 
            this.patchPanelToolStripMenuItem.Name = "patchPanelToolStripMenuItem";
            this.patchPanelToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.patchPanelToolStripMenuItem.Text = "Patch Panel";
            // 
            // patchToSwitchToolStripMenuItem
            // 
            this.patchToSwitchToolStripMenuItem.Name = "patchToSwitchToolStripMenuItem";
            this.patchToSwitchToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.patchToSwitchToolStripMenuItem.Text = "Patch To Switch";
            this.patchToSwitchToolStripMenuItem.Click += new System.EventHandler(this.patchToSwitchToolStripMenuItem_Click);
            // 
            // officeJackToolStripMenuItem
            // 
            this.officeJackToolStripMenuItem.Name = "officeJackToolStripMenuItem";
            this.officeJackToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.officeJackToolStripMenuItem.Text = "Office Jack";
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
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(881, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(576, 54);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(299, 20);
            this.searchBox.TabIndex = 5;
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
            this.dataGridView1.TabIndex = 0;
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
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.ToolStripMenuItem patchToSwitchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officeJackToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label connectedLabel;
        private System.Windows.Forms.Label dbLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label recordsCountLabel;
    }
}


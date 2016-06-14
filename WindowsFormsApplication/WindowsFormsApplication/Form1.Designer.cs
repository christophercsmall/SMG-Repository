namespace WindowsFormsApplication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.allTab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.stadiumTab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.arenaTab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tucpaTab = new System.Windows.Forms.TabPage();
            this.poccTab = new System.Windows.Forms.TabPage();
            this.ritzTab = new System.Windows.Forms.TabPage();
            this.ballparkTab = new System.Windows.Forms.TabPage();
            this.storageTab = new System.Windows.Forms.TabPage();
            this.lastUpdateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadInventoryButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reloadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.allTab.SuspendLayout();
            this.stadiumTab.SuspendLayout();
            this.arenaTab.SuspendLayout();
            this.tucpaTab.SuspendLayout();
            this.poccTab.SuspendLayout();
            this.ritzTab.SuspendLayout();
            this.ballparkTab.SuspendLayout();
            this.storageTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 381);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.allTab);
            this.tabControl1.Controls.Add(this.stadiumTab);
            this.tabControl1.Controls.Add(this.arenaTab);
            this.tabControl1.Controls.Add(this.tucpaTab);
            this.tabControl1.Controls.Add(this.poccTab);
            this.tabControl1.Controls.Add(this.ritzTab);
            this.tabControl1.Controls.Add(this.ballparkTab);
            this.tabControl1.Controls.Add(this.storageTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1097, 123);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 4;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // allTab
            // 
            this.allTab.BackColor = System.Drawing.Color.Transparent;
            this.allTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.allTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.allTab.Controls.Add(this.flowLayoutPanel1);
            this.allTab.Location = new System.Drawing.Point(4, 22);
            this.allTab.Name = "allTab";
            this.allTab.Size = new System.Drawing.Size(1089, 97);
            this.allTab.TabIndex = 0;
            this.allTab.Text = "ALL";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1085, 93);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // stadiumTab
            // 
            this.stadiumTab.BackColor = System.Drawing.Color.Transparent;
            this.stadiumTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stadiumTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stadiumTab.Controls.Add(this.flowLayoutPanel2);
            this.stadiumTab.Location = new System.Drawing.Point(4, 22);
            this.stadiumTab.Name = "stadiumTab";
            this.stadiumTab.Padding = new System.Windows.Forms.Padding(3);
            this.stadiumTab.Size = new System.Drawing.Size(1089, 97);
            this.stadiumTab.TabIndex = 0;
            this.stadiumTab.Text = "STADIUM";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1079, 87);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // arenaTab
            // 
            this.arenaTab.BackColor = System.Drawing.Color.Transparent;
            this.arenaTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.arenaTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.arenaTab.Controls.Add(this.flowLayoutPanel3);
            this.arenaTab.Location = new System.Drawing.Point(4, 22);
            this.arenaTab.Name = "arenaTab";
            this.arenaTab.Padding = new System.Windows.Forms.Padding(3);
            this.arenaTab.Size = new System.Drawing.Size(1089, 97);
            this.arenaTab.TabIndex = 5;
            this.arenaTab.Text = "ARENA";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1079, 87);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // tucpaTab
            // 
            this.tucpaTab.BackColor = System.Drawing.Color.White;
            this.tucpaTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tucpaTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tucpaTab.Controls.Add(this.flowLayoutPanel4);
            this.tucpaTab.Location = new System.Drawing.Point(4, 22);
            this.tucpaTab.Name = "tucpaTab";
            this.tucpaTab.Padding = new System.Windows.Forms.Padding(3);
            this.tucpaTab.Size = new System.Drawing.Size(1089, 97);
            this.tucpaTab.TabIndex = 1;
            this.tucpaTab.Text = "TUCPA";
            // 
            // poccTab
            // 
            this.poccTab.BackColor = System.Drawing.Color.White;
            this.poccTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.poccTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.poccTab.Controls.Add(this.flowLayoutPanel5);
            this.poccTab.Location = new System.Drawing.Point(4, 22);
            this.poccTab.Name = "poccTab";
            this.poccTab.Padding = new System.Windows.Forms.Padding(3);
            this.poccTab.Size = new System.Drawing.Size(1089, 97);
            this.poccTab.TabIndex = 2;
            this.poccTab.Text = "POCC";
            // 
            // ritzTab
            // 
            this.ritzTab.BackColor = System.Drawing.Color.White;
            this.ritzTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ritzTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ritzTab.Controls.Add(this.flowLayoutPanel6);
            this.ritzTab.Location = new System.Drawing.Point(4, 22);
            this.ritzTab.Name = "ritzTab";
            this.ritzTab.Padding = new System.Windows.Forms.Padding(3);
            this.ritzTab.Size = new System.Drawing.Size(1089, 97);
            this.ritzTab.TabIndex = 6;
            this.ritzTab.Text = "RITZ";
            // 
            // ballparkTab
            // 
            this.ballparkTab.BackColor = System.Drawing.Color.White;
            this.ballparkTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ballparkTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ballparkTab.Controls.Add(this.flowLayoutPanel7);
            this.ballparkTab.Location = new System.Drawing.Point(4, 22);
            this.ballparkTab.Name = "ballparkTab";
            this.ballparkTab.Size = new System.Drawing.Size(1089, 97);
            this.ballparkTab.TabIndex = 7;
            this.ballparkTab.Text = "BALLPARK";
            // 
            // storageTab
            // 
            this.storageTab.BackColor = System.Drawing.Color.White;
            this.storageTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.storageTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.storageTab.Controls.Add(this.flowLayoutPanel8);
            this.storageTab.Location = new System.Drawing.Point(4, 22);
            this.storageTab.Name = "storageTab";
            this.storageTab.Padding = new System.Windows.Forms.Padding(3);
            this.storageTab.Size = new System.Drawing.Size(1089, 97);
            this.storageTab.TabIndex = 4;
            this.storageTab.Text = "STORAGE";
            // 
            // lastUpdateLabel
            // 
            this.lastUpdateLabel.AutoSize = true;
            this.lastUpdateLabel.Location = new System.Drawing.Point(254, 188);
            this.lastUpdateLabel.Name = "lastUpdateLabel";
            this.lastUpdateLabel.Size = new System.Drawing.Size(22, 13);
            this.lastUpdateLabel.TabIndex = 3;
            this.lastUpdateLabel.Text = "- - -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Last Update: ";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(254, 210);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(22, 13);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "- - -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total: ";
            // 
            // loadInventoryButton
            // 
            this.loadInventoryButton.Location = new System.Drawing.Point(12, 12);
            this.loadInventoryButton.Name = "loadInventoryButton";
            this.loadInventoryButton.Size = new System.Drawing.Size(159, 33);
            this.loadInventoryButton.TabIndex = 0;
            this.loadInventoryButton.Text = "Load Inventory";
            this.loadInventoryButton.UseVisualStyleBackColor = true;
            this.loadInventoryButton.Click += new System.EventHandler(this.loadInventoryButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filePathLabel.Location = new System.Drawing.Point(342, 22);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(70, 15);
            this.filePathLabel.TabIndex = 7;
            this.filePathLabel.Text = "filePathLabel";
            this.filePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filePathLabel.Visible = false;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Enabled = false;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addButton.Location = new System.Drawing.Point(12, 624);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(159, 34);
            this.addButton.TabIndex = 45;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.Enabled = false;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editButton.Location = new System.Drawing.Point(177, 624);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(159, 34);
            this.editButton.TabIndex = 46;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(1034, 625);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 34);
            this.closeButton.TabIndex = 47;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 123);
            this.panel1.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 385);
            this.panel2.TabIndex = 49;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(342, 625);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(159, 33);
            this.deleteButton.TabIndex = 50;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 33);
            this.button1.TabIndex = 51;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1079, 87);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoScroll = true;
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1079, 87);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoScroll = true;
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(1079, 87);
            this.flowLayoutPanel6.TabIndex = 1;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoScroll = true;
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(1085, 93);
            this.flowLayoutPanel7.TabIndex = 1;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoScroll = true;
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel8.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(1079, 87);
            this.flowLayoutPanel8.TabIndex = 1;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WindowsFormsApplication.Form1);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Location = new System.Drawing.Point(12, 183);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(159, 43);
            this.reloadBtn.TabIndex = 52;
            this.reloadBtn.Text = "Refresh";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1121, 670);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.lastUpdateLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.loadInventoryButton);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.allTab.ResumeLayout(false);
            this.allTab.PerformLayout();
            this.stadiumTab.ResumeLayout(false);
            this.stadiumTab.PerformLayout();
            this.arenaTab.ResumeLayout(false);
            this.arenaTab.PerformLayout();
            this.tucpaTab.ResumeLayout(false);
            this.tucpaTab.PerformLayout();
            this.poccTab.ResumeLayout(false);
            this.poccTab.PerformLayout();
            this.ritzTab.ResumeLayout(false);
            this.ritzTab.PerformLayout();
            this.ballparkTab.ResumeLayout(false);
            this.ballparkTab.PerformLayout();
            this.storageTab.ResumeLayout(false);
            this.storageTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tucpaTab;
        private System.Windows.Forms.TabPage poccTab;
        private System.Windows.Forms.Button loadInventoryButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.TabPage storageTab;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TabPage ritzTab;
        private System.Windows.Forms.TabPage ballparkTab;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lastUpdateLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage stadiumTab;
        private System.Windows.Forms.TabPage arenaTab;
        private System.Windows.Forms.TabPage allTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Button reloadBtn;
    }
}


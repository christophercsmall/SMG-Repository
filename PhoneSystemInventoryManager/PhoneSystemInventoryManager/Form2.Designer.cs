namespace PhoneSystemInventoryManager
{
    partial class PatchToSwitchForm
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
            this.venueBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idfBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patchPanelBox = new System.Windows.Forms.ComboBox();
            this.PPPortBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.switchBox = new System.Windows.Forms.ComboBox();
            this.switchPortBox = new System.Windows.Forms.ComboBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.venueSpaceBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connectLabel = new System.Windows.Forms.Label();
            this.connectedLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PatchToSwitchDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatchToSwitchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // venueBox
            // 
            this.venueBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.venueBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.venueBox.FormattingEnabled = true;
            this.venueBox.Location = new System.Drawing.Point(90, 12);
            this.venueBox.Name = "venueBox";
            this.venueBox.Size = new System.Drawing.Size(121, 21);
            this.venueBox.TabIndex = 0;
            this.venueBox.SelectedIndexChanged += new System.EventHandler(this.venueBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Venue";
            // 
            // idfBox
            // 
            this.idfBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idfBox.Enabled = false;
            this.idfBox.FormattingEnabled = true;
            this.idfBox.Location = new System.Drawing.Point(90, 66);
            this.idfBox.Name = "idfBox";
            this.idfBox.Size = new System.Drawing.Size(121, 21);
            this.idfBox.TabIndex = 0;
            this.idfBox.SelectedIndexChanged += new System.EventHandler(this.idfBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDF";
            // 
            // patchPanelBox
            // 
            this.patchPanelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patchPanelBox.Enabled = false;
            this.patchPanelBox.FormattingEnabled = true;
            this.patchPanelBox.Location = new System.Drawing.Point(6, 19);
            this.patchPanelBox.Name = "patchPanelBox";
            this.patchPanelBox.Size = new System.Drawing.Size(110, 21);
            this.patchPanelBox.TabIndex = 0;
            this.patchPanelBox.SelectedValueChanged += new System.EventHandler(this.patchPanelBox_SelectedValueChanged);
            // 
            // PPPortBox
            // 
            this.PPPortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PPPortBox.Enabled = false;
            this.PPPortBox.FormattingEnabled = true;
            this.PPPortBox.Location = new System.Drawing.Point(122, 19);
            this.PPPortBox.Name = "PPPortBox";
            this.PPPortBox.Size = new System.Drawing.Size(45, 21);
            this.PPPortBox.TabIndex = 0;
            this.PPPortBox.SelectedIndexChanged += new System.EventHandler(this.PPPortBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.patchPanelBox);
            this.groupBox1.Controls.Add(this.PPPortBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patch Panel Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.switchBox);
            this.groupBox2.Controls.Add(this.switchPortBox);
            this.groupBox2.Location = new System.Drawing.Point(273, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 48);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Switch Port";
            // 
            // switchBox
            // 
            this.switchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.switchBox.Enabled = false;
            this.switchBox.FormattingEnabled = true;
            this.switchBox.Location = new System.Drawing.Point(57, 19);
            this.switchBox.Name = "switchBox";
            this.switchBox.Size = new System.Drawing.Size(110, 21);
            this.switchBox.TabIndex = 0;
            this.switchBox.SelectedIndexChanged += new System.EventHandler(this.switchBox_SelectedValueChanged);
            // 
            // switchPortBox
            // 
            this.switchPortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.switchPortBox.Enabled = false;
            this.switchPortBox.FormattingEnabled = true;
            this.switchPortBox.Location = new System.Drawing.Point(6, 19);
            this.switchPortBox.Name = "switchPortBox";
            this.switchPortBox.Size = new System.Drawing.Size(45, 21);
            this.switchPortBox.TabIndex = 0;
            this.switchPortBox.SelectedIndexChanged += new System.EventHandler(this.switchPortBox_SelectedIndexChanged);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(192, 116);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 24);
            this.connectBtn.TabIndex = 3;
            this.connectBtn.Text = "|---->      <----|";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // venueSpaceBox
            // 
            this.venueSpaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.venueSpaceBox.Enabled = false;
            this.venueSpaceBox.FormattingEnabled = true;
            this.venueSpaceBox.Location = new System.Drawing.Point(90, 39);
            this.venueSpaceBox.Name = "venueSpaceBox";
            this.venueSpaceBox.Size = new System.Drawing.Size(121, 21);
            this.venueSpaceBox.TabIndex = 0;
            this.venueSpaceBox.SelectedIndexChanged += new System.EventHandler(this.venueSpaceBox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Venue Space";
            // 
            // connectLabel
            // 
            this.connectLabel.AutoSize = true;
            this.connectLabel.Location = new System.Drawing.Point(206, 100);
            this.connectLabel.Name = "connectLabel";
            this.connectLabel.Size = new System.Drawing.Size(47, 13);
            this.connectLabel.TabIndex = 4;
            this.connectLabel.Text = "Connect";
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.Location = new System.Drawing.Point(200, 143);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(59, 13);
            this.connectedLabel.TabIndex = 4;
            this.connectedLabel.Text = "Connected";
            this.connectedLabel.Visible = false;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(327, 12);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(121, 23);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PatchToSwitchDataGridView
            // 
            this.PatchToSwitchDataGridView.AllowUserToAddRows = false;
            this.PatchToSwitchDataGridView.AllowUserToDeleteRows = false;
            this.PatchToSwitchDataGridView.AllowUserToOrderColumns = true;
            this.PatchToSwitchDataGridView.AllowUserToResizeRows = false;
            this.PatchToSwitchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatchToSwitchDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PatchToSwitchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatchToSwitchDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.PatchToSwitchDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PatchToSwitchDataGridView.Location = new System.Drawing.Point(0, 159);
            this.PatchToSwitchDataGridView.MultiSelect = false;
            this.PatchToSwitchDataGridView.Name = "PatchToSwitchDataGridView";
            this.PatchToSwitchDataGridView.ReadOnly = true;
            this.PatchToSwitchDataGridView.RowHeadersWidth = 30;
            this.PatchToSwitchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatchToSwitchDataGridView.Size = new System.Drawing.Size(460, 238);
            this.PatchToSwitchDataGridView.TabIndex = 6;
            this.PatchToSwitchDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatchToSwitchDataGridView_RowHeaderMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // PatchToSwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 397);
            this.Controls.Add(this.PatchToSwitchDataGridView);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.connectedLabel);
            this.Controls.Add(this.connectLabel);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.venueSpaceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idfBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.venueBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PatchToSwitchForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Create New Patch To Switch";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatchToSwitchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox venueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox idfBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox patchPanelBox;
        private System.Windows.Forms.ComboBox PPPortBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox switchBox;
        private System.Windows.Forms.ComboBox switchPortBox;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ComboBox venueSpaceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label connectLabel;
        private System.Windows.Forms.Label connectedLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView PatchToSwitchDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
namespace PhoneSystemInventoryManager
{
    partial class CreatePhoneToOfficeJackForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clearBtn = new System.Windows.Forms.Button();
            this.connectedLabel = new System.Windows.Forms.Label();
            this.connectLabel = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.venueSpaceBox = new System.Windows.Forms.ComboBox();
            this.selMacComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selJackBox = new System.Windows.Forms.TextBox();
            this.PPPortComboBox = new System.Windows.Forms.ComboBox();
            this.PatchToSwitchDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.idfBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.venueBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ppComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatchToSwitchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(327, 12);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(121, 23);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // connectedLabel
            // 
            this.connectedLabel.AutoSize = true;
            this.connectedLabel.Location = new System.Drawing.Point(200, 190);
            this.connectedLabel.Name = "connectedLabel";
            this.connectedLabel.Size = new System.Drawing.Size(59, 13);
            this.connectedLabel.TabIndex = 16;
            this.connectedLabel.Text = "Connected";
            this.connectedLabel.Visible = false;
            // 
            // connectLabel
            // 
            this.connectLabel.AutoSize = true;
            this.connectLabel.Location = new System.Drawing.Point(206, 147);
            this.connectLabel.Name = "connectLabel";
            this.connectLabel.Size = new System.Drawing.Size(47, 13);
            this.connectLabel.TabIndex = 17;
            this.connectLabel.Text = "Connect";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(192, 163);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 24);
            this.connectBtn.TabIndex = 15;
            this.connectBtn.Text = "|---->      <----|";
            this.connectBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Venue Space";
            // 
            // venueSpaceBox
            // 
            this.venueSpaceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.venueSpaceBox.Enabled = false;
            this.venueSpaceBox.FormattingEnabled = true;
            this.venueSpaceBox.Location = new System.Drawing.Point(100, 39);
            this.venueSpaceBox.Name = "venueSpaceBox";
            this.venueSpaceBox.Size = new System.Drawing.Size(121, 21);
            this.venueSpaceBox.TabIndex = 7;
            // 
            // selMacComboBox
            // 
            this.selMacComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selMacComboBox.Enabled = false;
            this.selMacComboBox.FormattingEnabled = true;
            this.selMacComboBox.Location = new System.Drawing.Point(6, 19);
            this.selMacComboBox.Name = "selMacComboBox";
            this.selMacComboBox.Size = new System.Drawing.Size(161, 21);
            this.selMacComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selMacComboBox);
            this.groupBox2.Location = new System.Drawing.Point(273, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 48);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phone MAC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selJackBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 48);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Office Jack";
            // 
            // selJackBox
            // 
            this.selJackBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selJackBox.Location = new System.Drawing.Point(6, 19);
            this.selJackBox.Name = "selJackBox";
            this.selJackBox.ReadOnly = true;
            this.selJackBox.Size = new System.Drawing.Size(162, 20);
            this.selJackBox.TabIndex = 0;
            // 
            // PPPortComboBox
            // 
            this.PPPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PPPortComboBox.Enabled = false;
            this.PPPortComboBox.FormattingEnabled = true;
            this.PPPortComboBox.Location = new System.Drawing.Point(100, 120);
            this.PPPortComboBox.Name = "PPPortComboBox";
            this.PPPortComboBox.Size = new System.Drawing.Size(347, 21);
            this.PPPortComboBox.TabIndex = 0;
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
            this.PatchToSwitchDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PatchToSwitchDataGridView.Location = new System.Drawing.Point(0, 208);
            this.PatchToSwitchDataGridView.MultiSelect = false;
            this.PatchToSwitchDataGridView.Name = "PatchToSwitchDataGridView";
            this.PatchToSwitchDataGridView.ReadOnly = true;
            this.PatchToSwitchDataGridView.RowHeadersWidth = 30;
            this.PatchToSwitchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatchToSwitchDataGridView.Size = new System.Drawing.Size(460, 238);
            this.PatchToSwitchDataGridView.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "IDF";
            // 
            // idfBox
            // 
            this.idfBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idfBox.Enabled = false;
            this.idfBox.FormattingEnabled = true;
            this.idfBox.Location = new System.Drawing.Point(100, 66);
            this.idfBox.Name = "idfBox";
            this.idfBox.Size = new System.Drawing.Size(121, 21);
            this.idfBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Venue";
            // 
            // venueBox
            // 
            this.venueBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.venueBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.venueBox.FormattingEnabled = true;
            this.venueBox.Location = new System.Drawing.Point(100, 12);
            this.venueBox.Name = "venueBox";
            this.venueBox.Size = new System.Drawing.Size(121, 21);
            this.venueBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Patch Panel";
            // 
            // ppComboBox
            // 
            this.ppComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ppComboBox.Enabled = false;
            this.ppComboBox.FormattingEnabled = true;
            this.ppComboBox.Location = new System.Drawing.Point(100, 93);
            this.ppComboBox.Name = "ppComboBox";
            this.ppComboBox.Size = new System.Drawing.Size(121, 21);
            this.ppComboBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Port/Jack Info.";
            // 
            // CreatePhoneToOfficeJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 446);
            this.Controls.Add(this.PPPortComboBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.connectedLabel);
            this.Controls.Add(this.connectLabel);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.venueSpaceBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PatchToSwitchDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ppComboBox);
            this.Controls.Add(this.idfBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.venueBox);
            this.Name = "CreatePhoneToOfficeJackForm";
            this.Text = "CreatePhoneToOfficeJackForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatchToSwitchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label connectedLabel;
        private System.Windows.Forms.Label connectLabel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox venueSpaceBox;
        private System.Windows.Forms.ComboBox selMacComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox PPPortComboBox;
        private System.Windows.Forms.DataGridView PatchToSwitchDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox idfBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox venueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ppComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox selJackBox;
    }
}
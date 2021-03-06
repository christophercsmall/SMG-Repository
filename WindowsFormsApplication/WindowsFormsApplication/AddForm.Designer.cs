﻿namespace WindowsFormsApplication
{
    partial class AddForm
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
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.locComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.invComboBox = new System.Windows.Forms.ComboBox();
            this.serialNumBox = new System.Windows.Forms.TextBox();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addAnotherCheckBox = new System.Windows.Forms.CheckBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Items.AddRange(new object[] {
            "DELL",
            "LENOVO"});
            this.brandComboBox.Location = new System.Drawing.Point(95, 185);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(159, 21);
            this.brandComboBox.TabIndex = 4;
            // 
            // locComboBox
            // 
            this.locComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locComboBox.FormattingEnabled = true;
            this.locComboBox.Items.AddRange(new object[] {
            "STADIUM",
            "ARENA",
            "TUCPA",
            "POCC",
            "BALLPARK",
            "RITZ"});
            this.locComboBox.Location = new System.Drawing.Point(95, 63);
            this.locComboBox.Name = "locComboBox";
            this.locComboBox.Size = new System.Drawing.Size(159, 21);
            this.locComboBox.TabIndex = 1;
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Items.AddRange(new object[] {
            "OPTIPLEX 3010",
            "OPTIPLEX 3020",
            "OPTIPLEX 380",
            "THINKCENTRE"});
            this.modelComboBox.Location = new System.Drawing.Point(95, 225);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(159, 21);
            this.modelComboBox.TabIndex = 5;
            // 
            // invComboBox
            // 
            this.invComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invComboBox.FormattingEnabled = true;
            this.invComboBox.Items.AddRange(new object[] {
            "PC",
            "LAPTOP",
            "SERVER",
            "MONITOR",
            "PRINTER",
            "CELLPHONE",
            "TABLET",
            "RADIO",
            "SWITCH",
            "ROUTER",
            "ACCESS POINT",
            "TV",
            "RF EQUIP",
            "AV EQUIP"});
            this.invComboBox.Location = new System.Drawing.Point(95, 22);
            this.invComboBox.Name = "invComboBox";
            this.invComboBox.Size = new System.Drawing.Size(159, 21);
            this.invComboBox.TabIndex = 0;
            // 
            // serialNumBox
            // 
            this.serialNumBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.serialNumBox.Location = new System.Drawing.Point(95, 146);
            this.serialNumBox.Name = "serialNumBox";
            this.serialNumBox.Size = new System.Drawing.Size(159, 20);
            this.serialNumBox.TabIndex = 3;
            this.serialNumBox.TextChanged += new System.EventHandler(this.serialNumBox_TextChanged);
            // 
            // notesBox
            // 
            this.notesBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.notesBox.Location = new System.Drawing.Point(95, 342);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(159, 20);
            this.notesBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Inventory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 345);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Notes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "S/N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Model";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(9, 268);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(45, 13);
            this.idLabel.TabIndex = 50;
            this.idLabel.Text = "SMG ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 305);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "User Name";
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(12, 411);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(161, 61);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add to Inventory";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addAnotherCheckBox
            // 
            this.addAnotherCheckBox.AutoSize = true;
            this.addAnotherCheckBox.Location = new System.Drawing.Point(12, 388);
            this.addAnotherCheckBox.Name = "addAnotherCheckBox";
            this.addAnotherCheckBox.Size = new System.Drawing.Size(84, 17);
            this.addAnotherCheckBox.TabIndex = 9;
            this.addAnotherCheckBox.Text = "Add another";
            this.addAnotherCheckBox.UseVisualStyleBackColor = true;
            // 
            // idBox
            // 
            this.idBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.idBox.Location = new System.Drawing.Point(95, 265);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(159, 20);
            this.idBox.TabIndex = 6;
            // 
            // userNameBox
            // 
            this.userNameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.userNameBox.Location = new System.Drawing.Point(95, 302);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(159, 20);
            this.userNameBox.TabIndex = 7;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(179, 411);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 61);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // areaBox
            // 
            this.areaBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.areaBox.Location = new System.Drawing.Point(95, 105);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(159, 20);
            this.areaBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Area";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 488);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.addAnotherCheckBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.serialNumBox);
            this.Controls.Add(this.invComboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.locComboBox);
            this.Controls.Add(this.brandComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.ComboBox locComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox invComboBox;
        private System.Windows.Forms.TextBox serialNumBox;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckBox addAnotherCheckBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.Label label7;
    }
}
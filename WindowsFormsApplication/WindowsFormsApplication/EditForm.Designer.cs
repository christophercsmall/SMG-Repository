namespace WindowsFormsApplication
{
    partial class EditForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.serialNumBox = new System.Windows.Forms.TextBox();
            this.invComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.locComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.invLabelBox = new System.Windows.Forms.TextBox();
            this.locLabelBox = new System.Windows.Forms.TextBox();
            this.snLabelBox = new System.Windows.Forms.TextBox();
            this.brandLabelBox = new System.Windows.Forms.TextBox();
            this.modelLabelBox = new System.Windows.Forms.TextBox();
            this.idLabelBox = new System.Windows.Forms.TextBox();
            this.userLabelBox = new System.Windows.Forms.TextBox();
            this.notesLabelBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.locArrowBtn = new System.Windows.Forms.Button();
            this.invArrowBtn = new System.Windows.Forms.Button();
            this.brandArrowBtn = new System.Windows.Forms.Button();
            this.snArrowBtn = new System.Windows.Forms.Button();
            this.modelArrowBtn = new System.Windows.Forms.Button();
            this.idArrowBtn = new System.Windows.Forms.Button();
            this.userArrowBtn = new System.Windows.Forms.Button();
            this.notesArrowBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.areaLabelBox = new System.Windows.Forms.TextBox();
            this.areaArrowBtn = new System.Windows.Forms.Button();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(308, 393);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 61);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // userNameBox
            // 
            this.userNameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.userNameBox.Enabled = false;
            this.userNameBox.Location = new System.Drawing.Point(254, 310);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(129, 20);
            this.userNameBox.TabIndex = 15;
            this.userNameBox.TextChanged += new System.EventHandler(this.userNameBox_TextChanged);
            // 
            // idBox
            // 
            this.idBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(254, 273);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(129, 20);
            this.idBox.TabIndex = 13;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(12, 393);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(161, 61);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Update Inventory";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 313);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "User Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(9, 276);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(45, 13);
            this.idLabel.TabIndex = 67;
            this.idLabel.Text = "SMG ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "S/N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Notes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Inventory";
            // 
            // notesBox
            // 
            this.notesBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.notesBox.Enabled = false;
            this.notesBox.Location = new System.Drawing.Point(254, 350);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(129, 20);
            this.notesBox.TabIndex = 17;
            this.notesBox.TextChanged += new System.EventHandler(this.notesBox_TextChanged);
            // 
            // serialNumBox
            // 
            this.serialNumBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.serialNumBox.Enabled = false;
            this.serialNumBox.Location = new System.Drawing.Point(254, 154);
            this.serialNumBox.Name = "serialNumBox";
            this.serialNumBox.Size = new System.Drawing.Size(129, 20);
            this.serialNumBox.TabIndex = 7;
            this.serialNumBox.TextChanged += new System.EventHandler(this.serialNumBox_TextChanged);
            // 
            // invComboBox
            // 
            this.invComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invComboBox.Enabled = false;
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
            this.invComboBox.Location = new System.Drawing.Point(254, 37);
            this.invComboBox.Name = "invComboBox";
            this.invComboBox.Size = new System.Drawing.Size(129, 21);
            this.invComboBox.TabIndex = 1;
            this.invComboBox.SelectedIndexChanged += new System.EventHandler(this.invComboBox_SelectedIndexChanged);
            this.invComboBox.TextChanged += new System.EventHandler(this.invComboBox_TextChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.Enabled = false;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Items.AddRange(new object[] {
            "OPTIPLEX 3010",
            "OPTIPLEX 3020",
            "OPTIPLEX 380",
            "THINKCENTRE"});
            this.modelComboBox.Location = new System.Drawing.Point(254, 233);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(129, 21);
            this.modelComboBox.TabIndex = 11;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            this.modelComboBox.TextChanged += new System.EventHandler(this.modelComboBox_TextChanged);
            // 
            // locComboBox
            // 
            this.locComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locComboBox.Enabled = false;
            this.locComboBox.FormattingEnabled = true;
            this.locComboBox.Items.AddRange(new object[] {
            "STADIUM",
            "ARENA",
            "TUCPA",
            "POCC",
            "BALLPARK",
            "RITZ"});
            this.locComboBox.Location = new System.Drawing.Point(254, 77);
            this.locComboBox.Name = "locComboBox";
            this.locComboBox.Size = new System.Drawing.Size(129, 21);
            this.locComboBox.TabIndex = 3;
            this.locComboBox.SelectedIndexChanged += new System.EventHandler(this.locComboBox_SelectedIndexChanged);
            this.locComboBox.TextChanged += new System.EventHandler(this.locComboBox_TextChanged);
            // 
            // brandComboBox
            // 
            this.brandComboBox.Enabled = false;
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Items.AddRange(new object[] {
            "DELL",
            "LENOVO"});
            this.brandComboBox.Location = new System.Drawing.Point(254, 193);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(129, 21);
            this.brandComboBox.TabIndex = 9;
            this.brandComboBox.SelectedIndexChanged += new System.EventHandler(this.brandComboBox_SelectedIndexChanged);
            this.brandComboBox.TextChanged += new System.EventHandler(this.brandComboBox_TextChanged);
            // 
            // invLabelBox
            // 
            this.invLabelBox.BackColor = System.Drawing.SystemColors.Info;
            this.invLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invLabelBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.invLabelBox.Location = new System.Drawing.Point(74, 37);
            this.invLabelBox.Name = "invLabelBox";
            this.invLabelBox.ReadOnly = true;
            this.invLabelBox.Size = new System.Drawing.Size(129, 20);
            this.invLabelBox.TabIndex = 80;
            // 
            // locLabelBox
            // 
            this.locLabelBox.BackColor = System.Drawing.SystemColors.Info;
            this.locLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locLabelBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.locLabelBox.Location = new System.Drawing.Point(74, 78);
            this.locLabelBox.Name = "locLabelBox";
            this.locLabelBox.ReadOnly = true;
            this.locLabelBox.Size = new System.Drawing.Size(129, 20);
            this.locLabelBox.TabIndex = 80;
            // 
            // snLabelBox
            // 
            this.snLabelBox.BackColor = System.Drawing.SystemColors.Info;
            this.snLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.snLabelBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.snLabelBox.Location = new System.Drawing.Point(74, 154);
            this.snLabelBox.Name = "snLabelBox";
            this.snLabelBox.ReadOnly = true;
            this.snLabelBox.Size = new System.Drawing.Size(129, 20);
            this.snLabelBox.TabIndex = 80;
            // 
            // brandLabelBox
            // 
            this.brandLabelBox.BackColor = System.Drawing.SystemColors.Info;
            this.brandLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brandLabelBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.brandLabelBox.Location = new System.Drawing.Point(74, 193);
            this.brandLabelBox.Name = "brandLabelBox";
            this.brandLabelBox.ReadOnly = true;
            this.brandLabelBox.Size = new System.Drawing.Size(129, 20);
            this.brandLabelBox.TabIndex = 80;
            // 
            // modelLabelBox
            // 
            this.modelLabelBox.BackColor = System.Drawing.SystemColors.Info;
            this.modelLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelLabelBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.modelLabelBox.Location = new System.Drawing.Point(74, 233);
            this.modelLabelBox.Name = "modelLabelBox";
            this.modelLabelBox.ReadOnly = true;
            this.modelLabelBox.Size = new System.Drawing.Size(129, 20);
            this.modelLabelBox.TabIndex = 80;
            // 
            // idLabelBox
            // 
            this.idLabelBox.BackColor = System.Drawing.SystemColors.Info;
            this.idLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idLabelBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.idLabelBox.Location = new System.Drawing.Point(74, 273);
            this.idLabelBox.Name = "idLabelBox";
            this.idLabelBox.ReadOnly = true;
            this.idLabelBox.Size = new System.Drawing.Size(129, 20);
            this.idLabelBox.TabIndex = 80;
            // 
            // userLabelBox
            // 
            this.userLabelBox.BackColor = System.Drawing.SystemColors.Info;
            this.userLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userLabelBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.userLabelBox.Location = new System.Drawing.Point(74, 310);
            this.userLabelBox.Name = "userLabelBox";
            this.userLabelBox.ReadOnly = true;
            this.userLabelBox.Size = new System.Drawing.Size(129, 20);
            this.userLabelBox.TabIndex = 80;
            // 
            // notesLabelBox
            // 
            this.notesLabelBox.BackColor = System.Drawing.SystemColors.Info;
            this.notesLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesLabelBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.notesLabelBox.Location = new System.Drawing.Point(74, 350);
            this.notesLabelBox.Name = "notesLabelBox";
            this.notesLabelBox.ReadOnly = true;
            this.notesLabelBox.Size = new System.Drawing.Size(129, 20);
            this.notesLabelBox.TabIndex = 80;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(227, 393);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 61);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // locArrowBtn
            // 
            this.locArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locArrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locArrowBtn.Location = new System.Drawing.Point(209, 75);
            this.locArrowBtn.Name = "locArrowBtn";
            this.locArrowBtn.Size = new System.Drawing.Size(39, 25);
            this.locArrowBtn.TabIndex = 2;
            this.locArrowBtn.Text = " >> ";
            this.locArrowBtn.UseVisualStyleBackColor = true;
            this.locArrowBtn.Click += new System.EventHandler(this.locArrowBtn_Click);
            // 
            // invArrowBtn
            // 
            this.invArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invArrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invArrowBtn.Location = new System.Drawing.Point(209, 35);
            this.invArrowBtn.Name = "invArrowBtn";
            this.invArrowBtn.Size = new System.Drawing.Size(39, 25);
            this.invArrowBtn.TabIndex = 0;
            this.invArrowBtn.Text = " >> ";
            this.invArrowBtn.UseVisualStyleBackColor = true;
            this.invArrowBtn.Click += new System.EventHandler(this.invArrowBtn_Click);
            // 
            // brandArrowBtn
            // 
            this.brandArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandArrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandArrowBtn.Location = new System.Drawing.Point(209, 190);
            this.brandArrowBtn.Name = "brandArrowBtn";
            this.brandArrowBtn.Size = new System.Drawing.Size(39, 25);
            this.brandArrowBtn.TabIndex = 6;
            this.brandArrowBtn.Text = " >> ";
            this.brandArrowBtn.UseVisualStyleBackColor = true;
            this.brandArrowBtn.Click += new System.EventHandler(this.brandArrowBtn_Click);
            // 
            // snArrowBtn
            // 
            this.snArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snArrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snArrowBtn.Location = new System.Drawing.Point(209, 151);
            this.snArrowBtn.Name = "snArrowBtn";
            this.snArrowBtn.Size = new System.Drawing.Size(39, 25);
            this.snArrowBtn.TabIndex = 4;
            this.snArrowBtn.Text = " >> ";
            this.snArrowBtn.UseVisualStyleBackColor = true;
            this.snArrowBtn.Click += new System.EventHandler(this.snArrowBtn_Click);
            // 
            // modelArrowBtn
            // 
            this.modelArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelArrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelArrowBtn.Location = new System.Drawing.Point(209, 230);
            this.modelArrowBtn.Name = "modelArrowBtn";
            this.modelArrowBtn.Size = new System.Drawing.Size(39, 25);
            this.modelArrowBtn.TabIndex = 8;
            this.modelArrowBtn.Text = " >> ";
            this.modelArrowBtn.UseVisualStyleBackColor = true;
            this.modelArrowBtn.Click += new System.EventHandler(this.modelArrowBtn_Click);
            // 
            // idArrowBtn
            // 
            this.idArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idArrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idArrowBtn.Location = new System.Drawing.Point(209, 271);
            this.idArrowBtn.Name = "idArrowBtn";
            this.idArrowBtn.Size = new System.Drawing.Size(39, 25);
            this.idArrowBtn.TabIndex = 10;
            this.idArrowBtn.Text = " >> ";
            this.idArrowBtn.UseVisualStyleBackColor = true;
            this.idArrowBtn.Click += new System.EventHandler(this.idArrowBtn_Click);
            // 
            // userArrowBtn
            // 
            this.userArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userArrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userArrowBtn.Location = new System.Drawing.Point(209, 308);
            this.userArrowBtn.Name = "userArrowBtn";
            this.userArrowBtn.Size = new System.Drawing.Size(39, 25);
            this.userArrowBtn.TabIndex = 12;
            this.userArrowBtn.Text = " >> ";
            this.userArrowBtn.UseVisualStyleBackColor = true;
            this.userArrowBtn.Click += new System.EventHandler(this.userArrowBtn_Click);
            // 
            // notesArrowBtn
            // 
            this.notesArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notesArrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesArrowBtn.Location = new System.Drawing.Point(209, 348);
            this.notesArrowBtn.Name = "notesArrowBtn";
            this.notesArrowBtn.Size = new System.Drawing.Size(39, 25);
            this.notesArrowBtn.TabIndex = 14;
            this.notesArrowBtn.Text = " >> ";
            this.notesArrowBtn.UseVisualStyleBackColor = true;
            this.notesArrowBtn.Click += new System.EventHandler(this.notesArrowBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 83;
            this.label7.Text = "Current Record";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(294, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 83;
            this.label9.Text = "Update";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Area";
            // 
            // areaLabelBox
            // 
            this.areaLabelBox.BackColor = System.Drawing.SystemColors.Info;
            this.areaLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaLabelBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.areaLabelBox.Location = new System.Drawing.Point(74, 116);
            this.areaLabelBox.Name = "areaLabelBox";
            this.areaLabelBox.ReadOnly = true;
            this.areaLabelBox.Size = new System.Drawing.Size(129, 20);
            this.areaLabelBox.TabIndex = 80;
            // 
            // areaArrowBtn
            // 
            this.areaArrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.areaArrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaArrowBtn.Location = new System.Drawing.Point(209, 113);
            this.areaArrowBtn.Name = "areaArrowBtn";
            this.areaArrowBtn.Size = new System.Drawing.Size(39, 25);
            this.areaArrowBtn.TabIndex = 2;
            this.areaArrowBtn.Text = " >> ";
            this.areaArrowBtn.UseVisualStyleBackColor = true;
            this.areaArrowBtn.Click += new System.EventHandler(this.areaArrowBtn_Click);
            // 
            // areaBox
            // 
            this.areaBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.areaBox.Enabled = false;
            this.areaBox.Location = new System.Drawing.Point(254, 116);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(129, 20);
            this.areaBox.TabIndex = 7;
            this.areaBox.TextChanged += new System.EventHandler(this.areaBox_TextChanged);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 467);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.snArrowBtn);
            this.Controls.Add(this.invArrowBtn);
            this.Controls.Add(this.notesArrowBtn);
            this.Controls.Add(this.userArrowBtn);
            this.Controls.Add(this.idArrowBtn);
            this.Controls.Add(this.modelArrowBtn);
            this.Controls.Add(this.brandArrowBtn);
            this.Controls.Add(this.areaArrowBtn);
            this.Controls.Add(this.locArrowBtn);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.notesLabelBox);
            this.Controls.Add(this.userLabelBox);
            this.Controls.Add(this.idLabelBox);
            this.Controls.Add(this.modelLabelBox);
            this.Controls.Add(this.brandLabelBox);
            this.Controls.Add(this.snLabelBox);
            this.Controls.Add(this.areaLabelBox);
            this.Controls.Add(this.locLabelBox);
            this.Controls.Add(this.invLabelBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.serialNumBox);
            this.Controls.Add(this.invComboBox);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.locComboBox);
            this.Controls.Add(this.brandComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditForm_FormClosed);
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.TextBox serialNumBox;
        private System.Windows.Forms.ComboBox invComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox locComboBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.TextBox invLabelBox;
        private System.Windows.Forms.TextBox locLabelBox;
        private System.Windows.Forms.TextBox snLabelBox;
        private System.Windows.Forms.TextBox brandLabelBox;
        private System.Windows.Forms.TextBox modelLabelBox;
        private System.Windows.Forms.TextBox idLabelBox;
        private System.Windows.Forms.TextBox userLabelBox;
        private System.Windows.Forms.TextBox notesLabelBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button locArrowBtn;
        private System.Windows.Forms.Button invArrowBtn;
        private System.Windows.Forms.Button brandArrowBtn;
        private System.Windows.Forms.Button snArrowBtn;
        private System.Windows.Forms.Button modelArrowBtn;
        private System.Windows.Forms.Button idArrowBtn;
        private System.Windows.Forms.Button userArrowBtn;
        private System.Windows.Forms.Button notesArrowBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox areaLabelBox;
        private System.Windows.Forms.Button areaArrowBtn;
        private System.Windows.Forms.TextBox areaBox;
    }
}
namespace EncryptMainMenu
{
    partial class Encrypter
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
            this.label1 = new System.Windows.Forms.Label();
            this.Encrypt = new System.Windows.Forms.RadioButton();
            this.Encyrpt_Decrypt = new System.Windows.Forms.GroupBox();
            this.Decrypt = new System.Windows.Forms.RadioButton();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.Input_Methods = new System.Windows.Forms.GroupBox();
            this.Text_Box = new System.Windows.Forms.RadioButton();
            this.File_Upload = new System.Windows.Forms.RadioButton();
            this.Rotor_Settings = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Input_textbox = new System.Windows.Forms.TextBox();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.File_Name = new System.Windows.Forms.GroupBox();
            this.btn_submit_name = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFile_Name_Text = new System.Windows.Forms.TextBox();
            this.lbl_input = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Encyrpt_Decrypt.SuspendLayout();
            this.Input_Methods.SuspendLayout();
            this.Rotor_Settings.SuspendLayout();
            this.File_Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Encrypter";
            // 
            // Encrypt
            // 
            this.Encrypt.AutoSize = true;
            this.Encrypt.Location = new System.Drawing.Point(6, 25);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(81, 24);
            this.Encrypt.TabIndex = 1;
            this.Encrypt.TabStop = true;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.CheckedChanged += new System.EventHandler(this.Encrypt_CheckedChanged);
            // 
            // Encyrpt_Decrypt
            // 
            this.Encyrpt_Decrypt.Controls.Add(this.Decrypt);
            this.Encyrpt_Decrypt.Controls.Add(this.Encrypt);
            this.Encyrpt_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encyrpt_Decrypt.Location = new System.Drawing.Point(505, 154);
            this.Encyrpt_Decrypt.Name = "Encyrpt_Decrypt";
            this.Encyrpt_Decrypt.Size = new System.Drawing.Size(209, 76);
            this.Encyrpt_Decrypt.TabIndex = 2;
            this.Encyrpt_Decrypt.TabStop = false;
            this.Encyrpt_Decrypt.Text = "Encyrpting or decrypting?";
            // 
            // Decrypt
            // 
            this.Decrypt.AutoSize = true;
            this.Decrypt.Location = new System.Drawing.Point(5, 49);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(82, 24);
            this.Decrypt.TabIndex = 2;
            this.Decrypt.TabStop = true;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.CheckedChanged += new System.EventHandler(this.Decrypt_CheckedChanged);
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(505, 712);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_encrypt.TabIndex = 3;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // Input_Methods
            // 
            this.Input_Methods.Controls.Add(this.Text_Box);
            this.Input_Methods.Controls.Add(this.File_Upload);
            this.Input_Methods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Methods.Location = new System.Drawing.Point(505, 266);
            this.Input_Methods.Name = "Input_Methods";
            this.Input_Methods.Size = new System.Drawing.Size(209, 80);
            this.Input_Methods.TabIndex = 4;
            this.Input_Methods.TabStop = false;
            this.Input_Methods.Text = "Input Method";
            // 
            // Text_Box
            // 
            this.Text_Box.AutoSize = true;
            this.Text_Box.Location = new System.Drawing.Point(6, 43);
            this.Text_Box.Name = "Text_Box";
            this.Text_Box.Size = new System.Drawing.Size(88, 24);
            this.Text_Box.TabIndex = 1;
            this.Text_Box.TabStop = true;
            this.Text_Box.Text = "Text Box";
            this.Text_Box.UseVisualStyleBackColor = true;
            this.Text_Box.CheckedChanged += new System.EventHandler(this.Text_Box_CheckedChanged);
            // 
            // File_Upload
            // 
            this.File_Upload.AutoSize = true;
            this.File_Upload.Location = new System.Drawing.Point(6, 20);
            this.File_Upload.Name = "File_Upload";
            this.File_Upload.Size = new System.Drawing.Size(107, 24);
            this.File_Upload.TabIndex = 0;
            this.File_Upload.TabStop = true;
            this.File_Upload.Text = "File Upload";
            this.File_Upload.UseVisualStyleBackColor = true;
            this.File_Upload.CheckedChanged += new System.EventHandler(this.File_Upload_CheckedChanged);
            // 
            // Rotor_Settings
            // 
            this.Rotor_Settings.Controls.Add(this.label6);
            this.Rotor_Settings.Controls.Add(this.comboBox4);
            this.Rotor_Settings.Controls.Add(this.comboBox3);
            this.Rotor_Settings.Controls.Add(this.comboBox2);
            this.Rotor_Settings.Controls.Add(this.label4);
            this.Rotor_Settings.Controls.Add(this.comboBox1);
            this.Rotor_Settings.Controls.Add(this.label2);
            this.Rotor_Settings.Controls.Add(this.label3);
            this.Rotor_Settings.Enabled = false;
            this.Rotor_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rotor_Settings.Location = new System.Drawing.Point(99, 294);
            this.Rotor_Settings.Name = "Rotor_Settings";
            this.Rotor_Settings.Size = new System.Drawing.Size(208, 184);
            this.Rotor_Settings.TabIndex = 5;
            this.Rotor_Settings.TabStop = false;
            this.Rotor_Settings.Text = "Rotor settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rotor 4";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "2",
            "3",
            "5",
            "7",
            "11 ",
            "13 ",
            "17 ",
            "19",
            "23",
            "29",
            "31",
            "37",
            "41",
            "43 ",
            "47",
            "53",
            "59",
            "61",
            "67",
            "71",
            "73"});
            this.comboBox4.Location = new System.Drawing.Point(75, 144);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 28);
            this.comboBox4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rotor 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rotor 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rotor 1";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2",
            "3",
            "5",
            "7",
            "11 ",
            "13 ",
            "17 ",
            "19",
            "23",
            "29",
            "31",
            "37",
            "41",
            "43 ",
            "47",
            "53",
            "59",
            "61",
            "67",
            "71",
            "73"});
            this.comboBox3.Location = new System.Drawing.Point(75, 110);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 28);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2",
            "3",
            "5",
            "7",
            "11 ",
            "13 ",
            "17 ",
            "19",
            "23",
            "29",
            "31",
            "37",
            "41",
            "43 ",
            "47",
            "53",
            "59",
            "61",
            "67",
            "71",
            "73"});
            this.comboBox2.Location = new System.Drawing.Point(75, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "5",
            "7",
            "11 ",
            "13 ",
            "17 ",
            "19",
            "23",
            "29",
            "31",
            "37",
            "41",
            "43 ",
            "47",
            "53",
            "59",
            "61",
            "67",
            "71",
            "73"});
            this.comboBox1.Location = new System.Drawing.Point(75, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // Input_textbox
            // 
            this.Input_textbox.Enabled = false;
            this.Input_textbox.Location = new System.Drawing.Point(355, 481);
            this.Input_textbox.Multiline = true;
            this.Input_textbox.Name = "Input_textbox";
            this.Input_textbox.Size = new System.Drawing.Size(501, 225);
            this.Input_textbox.TabIndex = 6;
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(639, 712);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 8;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // File_Name
            // 
            this.File_Name.Controls.Add(this.btn_submit_name);
            this.File_Name.Controls.Add(this.label5);
            this.File_Name.Controls.Add(this.txtFile_Name_Text);
            this.File_Name.Enabled = false;
            this.File_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_Name.Location = new System.Drawing.Point(901, 302);
            this.File_Name.Name = "File_Name";
            this.File_Name.Size = new System.Drawing.Size(200, 113);
            this.File_Name.TabIndex = 9;
            this.File_Name.TabStop = false;
            this.File_Name.Text = "Ouput File Directory";
            // 
            // btn_submit_name
            // 
            this.btn_submit_name.Location = new System.Drawing.Point(63, 84);
            this.btn_submit_name.Name = "btn_submit_name";
            this.btn_submit_name.Size = new System.Drawing.Size(75, 29);
            this.btn_submit_name.TabIndex = 11;
            this.btn_submit_name.Text = "Submit";
            this.btn_submit_name.UseVisualStyleBackColor = true;
            this.btn_submit_name.Click += new System.EventHandler(this.btn_submit_name_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "File Name:";
            // 
            // txtFile_Name_Text
            // 
            this.txtFile_Name_Text.Location = new System.Drawing.Point(94, 47);
            this.txtFile_Name_Text.Name = "txtFile_Name_Text";
            this.txtFile_Name_Text.Size = new System.Drawing.Size(100, 26);
            this.txtFile_Name_Text.TabIndex = 0;
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input.Location = new System.Drawing.Point(587, 458);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(46, 20);
            this.lbl_input.TabIndex = 10;
            this.lbl_input.Text = "Input";
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(564, 54);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 27);
            this.btn_help.TabIndex = 11;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(564, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Encrypter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1142, 744);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.File_Name);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.Input_textbox);
            this.Controls.Add(this.Rotor_Settings);
            this.Controls.Add(this.Input_Methods);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.Encyrpt_Decrypt);
            this.Name = "Encrypter";
            this.Text = "Encrypter";
            this.Load += new System.EventHandler(this.Encrypter_Load);
            this.Encyrpt_Decrypt.ResumeLayout(false);
            this.Encyrpt_Decrypt.PerformLayout();
            this.Input_Methods.ResumeLayout(false);
            this.Input_Methods.PerformLayout();
            this.Rotor_Settings.ResumeLayout(false);
            this.Rotor_Settings.PerformLayout();
            this.File_Name.ResumeLayout(false);
            this.File_Name.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Encrypt;
        private System.Windows.Forms.GroupBox Encyrpt_Decrypt;
        private System.Windows.Forms.RadioButton Decrypt;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.GroupBox Input_Methods;
        private System.Windows.Forms.RadioButton Text_Box;
        private System.Windows.Forms.RadioButton File_Upload;
        private System.Windows.Forms.GroupBox Rotor_Settings;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Input_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.GroupBox File_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFile_Name_Text;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.Button btn_submit_name;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
    }
}


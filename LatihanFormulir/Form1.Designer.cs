namespace LatihanFormulir
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label7 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            OtherCheckbox = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            Table = new TextBox();
            label9 = new Label();
            label10 = new Label();
            comboBox2 = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(243, 22);
            label1.Name = "label1";
            label1.Size = new Size(450, 46);
            label1.TabIndex = 0;
            label1.Text = "FORMULIR PENDAFTARAN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 109);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama Lengkap";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 142);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 5;
            label3.Text = "Tempat Lahir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 177);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 6;
            label4.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 208);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 7;
            label5.Text = "Alamat";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(259, 205);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(263, 27);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 240);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 9;
            label6.Text = "Jenis kelamin";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(259, 238);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Laki-Laki";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(351, 238);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 24);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perempuan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(125, 271);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 12;
            label7.Text = "Golongan Darah";
            label7.Click += label7_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(259, 302);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Reading";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(424, 302);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(69, 24);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "Music";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(351, 302);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(67, 24);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "Sport";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // OtherCheckbox
            // 
            OtherCheckbox.AutoSize = true;
            OtherCheckbox.Location = new Point(499, 302);
            OtherCheckbox.Name = "OtherCheckbox";
            OtherCheckbox.Size = new Size(68, 24);
            OtherCheckbox.TabIndex = 15;
            OtherCheckbox.Text = "Other";
            OtherCheckbox.UseVisualStyleBackColor = true;
            OtherCheckbox.CheckedChanged += OtherCheckbox_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(259, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(125, 303);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 21;
            label8.Text = "Hobby";
            label8.Click += label8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(633, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A", "B", "AB", "O" });
            comboBox1.Location = new Point(259, 268);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 23;
            // 
            // Table
            // 
            Table.Location = new Point(259, 332);
            Table.Name = "Table";
            Table.Size = new Size(263, 27);
            Table.TabIndex = 24;
            Table.Visible = false;
            Table.TextChanged += textBox3_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(125, 368);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 25;
            label9.Text = "Agama";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(125, 402);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 26;
            label10.Text = "Fakultas";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Kristen", "Islam", "Hindu ", "Budha", "Konghucu" });
            comboBox2.Location = new Point(259, 365);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(126, 436);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 28;
            label11.Text = "Jurusan";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(125, 470);
            label12.Name = "label12";
            label12.Size = new Size(113, 20);
            label12.TabIndex = 29;
            label12.Text = "Tempat Tinggal";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(126, 504);
            label13.Name = "label13";
            label13.Size = new Size(64, 20);
            label13.TabIndex = 30;
            label13.Text = "No. Telp";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Komputer", "Keperawatan", "Ekonomi Dan Bisnis", "Filsafat", "Pendidikan", "Pertanian" });
            comboBox3.Location = new Point(259, 399);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 31;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Informatika (TI)", "Sistem Informasi (SI)", "Teknologi Informasi (DKV)" });
            comboBox4.Location = new Point(259, 433);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 32;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Outsider Long Range", "Outsider Short Range", "Asrama Genset", "Asrama Crystal", "Asrama Guest House", "Asrama Bougenville", "Asrama Annex", "Asrama Edelweiss", "Asrama Jasmine" });
            comboBox5.Location = new Point(259, 467);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(151, 28);
            comboBox5.TabIndex = 33;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(259, 501);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 27);
            textBox3.TabIndex = 34;
            // 
            // button1
            // 
            button1.Location = new Point(259, 534);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 35;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(359, 534);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 36;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(633, 388);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 37;
            button3.Text = "Edit Photo";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(893, 597);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(comboBox2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(Table);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(OtherCheckbox);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox OtherCheckbox;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private TextBox Table;
        private Label label9;
        private Label label10;
        private ComboBox comboBox2;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
﻿namespace MathSol
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.comboBoxLength = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonConvert4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWeight = new System.Windows.Forms.ComboBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight2 = new System.Windows.Forms.TextBox();
            this.comboBoxWeight2 = new System.Windows.Forms.ComboBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonConvert3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVolume = new System.Windows.Forms.ComboBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.comboBoxVolume2 = new System.Windows.Forms.ComboBox();
            this.textBoxVolume2 = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonConvert2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.comboBoxArea2 = new System.Windows.Forms.ComboBox();
            this.textBoxArea2 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonConvert1 = new System.Windows.Forms.Button();
            this.comboBoxLength2 = new System.Windows.Forms.ComboBox();
            this.textBoxLength2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(46, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 60);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLength.BackColor = System.Drawing.Color.White;
            this.textBoxLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLength.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxLength.Location = new System.Drawing.Point(61, 163);
            this.textBoxLength.Multiline = true;
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(186, 31);
            this.textBoxLength.TabIndex = 7;
            this.textBoxLength.Text = "Nhập giá trị...";
            this.textBoxLength.Enter += new System.EventHandler(this.textBoxLength_Enter);
            this.textBoxLength.Leave += new System.EventHandler(this.textBoxLength_Leave);
            // 
            // comboBoxLength
            // 
            this.comboBoxLength.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxLength.BackColor = System.Drawing.Color.White;
            this.comboBoxLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLength.FormattingEnabled = true;
            this.comboBoxLength.Items.AddRange(new object[] {
            "km",
            "hm",
            "dam",
            "m",
            "dm",
            "cm",
            "mm"});
            this.comboBoxLength.Location = new System.Drawing.Point(263, 157);
            this.comboBoxLength.Name = "comboBoxLength";
            this.comboBoxLength.Size = new System.Drawing.Size(67, 37);
            this.comboBoxLength.TabIndex = 6;
            this.comboBoxLength.Text = "m";
            this.comboBoxLength.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(40, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đổi đơn vị đo độ dài";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 805);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(974, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 805);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(70, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 30);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(70, 775);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(904, 30);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(70, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(904, 745);
            this.panel5.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.buttonConvert4);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.comboBoxWeight);
            this.panel9.Controls.Add(this.textBoxWeight);
            this.panel9.Controls.Add(this.textBoxWeight2);
            this.panel9.Controls.Add(this.comboBoxWeight2);
            this.panel9.Controls.Add(this.pictureBox8);
            this.panel9.Controls.Add(this.pictureBox7);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 526);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(904, 150);
            this.panel9.TabIndex = 42;
            // 
            // buttonConvert4
            // 
            this.buttonConvert4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConvert4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.buttonConvert4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvert4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert4.ForeColor = System.Drawing.Color.White;
            this.buttonConvert4.Location = new System.Drawing.Point(376, 71);
            this.buttonConvert4.Name = "buttonConvert4";
            this.buttonConvert4.Size = new System.Drawing.Size(114, 60);
            this.buttonConvert4.TabIndex = 38;
            this.buttonConvert4.Text = "Đổi";
            this.buttonConvert4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label4.Location = new System.Drawing.Point(40, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 33);
            this.label4.TabIndex = 31;
            this.label4.Text = "Đổi đơn vị đo khối lượng";
            // 
            // comboBoxWeight
            // 
            this.comboBoxWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxWeight.BackColor = System.Drawing.Color.White;
            this.comboBoxWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWeight.FormattingEnabled = true;
            this.comboBoxWeight.Items.AddRange(new object[] {
            "tấn",
            "tạ ",
            "yến",
            "kg",
            "hg",
            "dag",
            "g"});
            this.comboBoxWeight.Location = new System.Drawing.Point(253, 80);
            this.comboBoxWeight.Name = "comboBoxWeight";
            this.comboBoxWeight.Size = new System.Drawing.Size(77, 37);
            this.comboBoxWeight.TabIndex = 32;
            this.comboBoxWeight.Text = "kg";
            this.comboBoxWeight.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxWeight.BackColor = System.Drawing.Color.White;
            this.textBoxWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeight.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxWeight.Location = new System.Drawing.Point(61, 89);
            this.textBoxWeight.Multiline = true;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(186, 31);
            this.textBoxWeight.TabIndex = 33;
            this.textBoxWeight.Text = "Nhập giá trị...";
            this.textBoxWeight.Enter += new System.EventHandler(this.textBoxWeight_Enter);
            this.textBoxWeight.Leave += new System.EventHandler(this.textBoxWeight_Leave);
            // 
            // textBoxWeight2
            // 
            this.textBoxWeight2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxWeight2.BackColor = System.Drawing.Color.White;
            this.textBoxWeight2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWeight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeight2.ForeColor = System.Drawing.Color.Black;
            this.textBoxWeight2.Location = new System.Drawing.Point(541, 89);
            this.textBoxWeight2.Multiline = true;
            this.textBoxWeight2.Name = "textBoxWeight2";
            this.textBoxWeight2.Size = new System.Drawing.Size(190, 31);
            this.textBoxWeight2.TabIndex = 36;
            // 
            // comboBoxWeight2
            // 
            this.comboBoxWeight2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxWeight2.BackColor = System.Drawing.Color.White;
            this.comboBoxWeight2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxWeight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWeight2.FormattingEnabled = true;
            this.comboBoxWeight2.Items.AddRange(new object[] {
            "tấn",
            "tạ ",
            "yến",
            "kg",
            "hg",
            "dag",
            "g"});
            this.comboBoxWeight2.Location = new System.Drawing.Point(747, 83);
            this.comboBoxWeight2.Name = "comboBoxWeight2";
            this.comboBoxWeight2.Size = new System.Drawing.Size(62, 37);
            this.comboBoxWeight2.TabIndex = 35;
            this.comboBoxWeight2.Text = "g";
            this.comboBoxWeight2.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(46, 71);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(290, 60);
            this.pictureBox8.TabIndex = 34;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(526, 71);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(290, 60);
            this.pictureBox7.TabIndex = 37;
            this.pictureBox7.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.buttonConvert3);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.comboBoxVolume);
            this.panel8.Controls.Add(this.textBoxVolume);
            this.panel8.Controls.Add(this.comboBoxVolume2);
            this.panel8.Controls.Add(this.textBoxVolume2);
            this.panel8.Controls.Add(this.pictureBox6);
            this.panel8.Controls.Add(this.pictureBox5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 376);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(904, 150);
            this.panel8.TabIndex = 41;
            // 
            // buttonConvert3
            // 
            this.buttonConvert3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConvert3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.buttonConvert3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvert3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert3.ForeColor = System.Drawing.Color.White;
            this.buttonConvert3.Location = new System.Drawing.Point(376, 73);
            this.buttonConvert3.Name = "buttonConvert3";
            this.buttonConvert3.Size = new System.Drawing.Size(114, 60);
            this.buttonConvert3.TabIndex = 30;
            this.buttonConvert3.Text = "Đổi";
            this.buttonConvert3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(40, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 33);
            this.label3.TabIndex = 23;
            this.label3.Text = "Đổi đơn vị đo thể tích";
            // 
            // comboBoxVolume
            // 
            this.comboBoxVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxVolume.BackColor = System.Drawing.Color.White;
            this.comboBoxVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVolume.FormattingEnabled = true;
            this.comboBoxVolume.Items.AddRange(new object[] {
            "l",
            "ml",
            "km³",
            "hm³",
            "dam³",
            "m³",
            "dm³",
            "cm³",
            "mm³"});
            this.comboBoxVolume.Location = new System.Drawing.Point(253, 85);
            this.comboBoxVolume.Name = "comboBoxVolume";
            this.comboBoxVolume.Size = new System.Drawing.Size(77, 37);
            this.comboBoxVolume.TabIndex = 24;
            this.comboBoxVolume.Text = "l";
            this.comboBoxVolume.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxVolume.BackColor = System.Drawing.Color.White;
            this.textBoxVolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVolume.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxVolume.Location = new System.Drawing.Point(61, 91);
            this.textBoxVolume.Multiline = true;
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(186, 31);
            this.textBoxVolume.TabIndex = 25;
            this.textBoxVolume.Text = "Nhập giá trị...";
            this.textBoxVolume.Enter += new System.EventHandler(this.textBoxVolume_Enter);
            this.textBoxVolume.Leave += new System.EventHandler(this.textBoxVolume_Leave);
            // 
            // comboBoxVolume2
            // 
            this.comboBoxVolume2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxVolume2.BackColor = System.Drawing.Color.White;
            this.comboBoxVolume2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVolume2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVolume2.FormattingEnabled = true;
            this.comboBoxVolume2.Items.AddRange(new object[] {
            "l",
            "ml",
            "km³",
            "hm³",
            "dam³",
            "m³",
            "dm³",
            "cm³",
            "mm³"});
            this.comboBoxVolume2.Location = new System.Drawing.Point(728, 85);
            this.comboBoxVolume2.Name = "comboBoxVolume2";
            this.comboBoxVolume2.Size = new System.Drawing.Size(81, 37);
            this.comboBoxVolume2.TabIndex = 27;
            this.comboBoxVolume2.Text = "cm³";
            this.comboBoxVolume2.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // textBoxVolume2
            // 
            this.textBoxVolume2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxVolume2.BackColor = System.Drawing.Color.White;
            this.textBoxVolume2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVolume2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVolume2.ForeColor = System.Drawing.Color.Black;
            this.textBoxVolume2.Location = new System.Drawing.Point(541, 91);
            this.textBoxVolume2.Multiline = true;
            this.textBoxVolume2.Name = "textBoxVolume2";
            this.textBoxVolume2.Size = new System.Drawing.Size(190, 31);
            this.textBoxVolume2.TabIndex = 28;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(46, 73);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(290, 60);
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(526, 73);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(290, 60);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonConvert2);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.comboBoxArea);
            this.panel7.Controls.Add(this.textBoxArea);
            this.panel7.Controls.Add(this.comboBoxArea2);
            this.panel7.Controls.Add(this.textBoxArea2);
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 226);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(904, 150);
            this.panel7.TabIndex = 40;
            // 
            // buttonConvert2
            // 
            this.buttonConvert2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConvert2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.buttonConvert2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvert2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert2.ForeColor = System.Drawing.Color.White;
            this.buttonConvert2.Location = new System.Drawing.Point(376, 73);
            this.buttonConvert2.Name = "buttonConvert2";
            this.buttonConvert2.Size = new System.Drawing.Size(114, 60);
            this.buttonConvert2.TabIndex = 22;
            this.buttonConvert2.Text = "Đổi";
            this.buttonConvert2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(40, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Đổi đơn vị đo diện tích";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxArea.BackColor = System.Drawing.Color.White;
            this.comboBoxArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Items.AddRange(new object[] {
            "km²",
            "hm²",
            "dam²",
            "m²",
            "dm²",
            "cm²",
            "mm²"});
            this.comboBoxArea.Location = new System.Drawing.Point(263, 85);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(67, 37);
            this.comboBoxArea.TabIndex = 16;
            this.comboBoxArea.Text = "m²";
            this.comboBoxArea.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // textBoxArea
            // 
            this.textBoxArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxArea.BackColor = System.Drawing.Color.White;
            this.textBoxArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArea.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxArea.Location = new System.Drawing.Point(61, 91);
            this.textBoxArea.Multiline = true;
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(186, 31);
            this.textBoxArea.TabIndex = 17;
            this.textBoxArea.Text = "Nhập giá trị...";
            this.textBoxArea.Enter += new System.EventHandler(this.textBoxArea_Enter);
            this.textBoxArea.Leave += new System.EventHandler(this.textBoxArea_Leave);
            // 
            // comboBoxArea2
            // 
            this.comboBoxArea2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxArea2.BackColor = System.Drawing.Color.White;
            this.comboBoxArea2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxArea2.FormattingEnabled = true;
            this.comboBoxArea2.Items.AddRange(new object[] {
            "km²",
            "hm²",
            "dam²",
            "m²",
            "dm²",
            "cm²",
            "mm²"});
            this.comboBoxArea2.Location = new System.Drawing.Point(728, 85);
            this.comboBoxArea2.Name = "comboBoxArea2";
            this.comboBoxArea2.Size = new System.Drawing.Size(81, 37);
            this.comboBoxArea2.TabIndex = 19;
            this.comboBoxArea2.Text = "cm²";
            this.comboBoxArea2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBoxArea2
            // 
            this.textBoxArea2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxArea2.BackColor = System.Drawing.Color.White;
            this.textBoxArea2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxArea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArea2.ForeColor = System.Drawing.Color.Black;
            this.textBoxArea2.Location = new System.Drawing.Point(541, 91);
            this.textBoxArea2.Multiline = true;
            this.textBoxArea2.Name = "textBoxArea2";
            this.textBoxArea2.Size = new System.Drawing.Size(190, 31);
            this.textBoxArea2.TabIndex = 20;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(46, 73);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(290, 60);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(526, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(290, 60);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonConvert1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.comboBoxLength);
            this.panel6.Controls.Add(this.textBoxLength);
            this.panel6.Controls.Add(this.comboBoxLength2);
            this.panel6.Controls.Add(this.textBoxLength2);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(904, 226);
            this.panel6.TabIndex = 39;
            // 
            // buttonConvert1
            // 
            this.buttonConvert1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonConvert1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.buttonConvert1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvert1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert1.ForeColor = System.Drawing.Color.White;
            this.buttonConvert1.Location = new System.Drawing.Point(376, 145);
            this.buttonConvert1.Name = "buttonConvert1";
            this.buttonConvert1.Size = new System.Drawing.Size(114, 60);
            this.buttonConvert1.TabIndex = 14;
            this.buttonConvert1.Text = "Đổi";
            this.buttonConvert1.UseVisualStyleBackColor = false;
            // 
            // comboBoxLength2
            // 
            this.comboBoxLength2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxLength2.BackColor = System.Drawing.Color.White;
            this.comboBoxLength2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLength2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLength2.FormattingEnabled = true;
            this.comboBoxLength2.Items.AddRange(new object[] {
            "km",
            "hm",
            "dam",
            "m",
            "dm",
            "cm",
            "mm"});
            this.comboBoxLength2.Location = new System.Drawing.Point(728, 157);
            this.comboBoxLength2.Name = "comboBoxLength2";
            this.comboBoxLength2.Size = new System.Drawing.Size(81, 37);
            this.comboBoxLength2.TabIndex = 11;
            this.comboBoxLength2.Text = "cm";
            // 
            // textBoxLength2
            // 
            this.textBoxLength2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLength2.BackColor = System.Drawing.Color.White;
            this.textBoxLength2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLength2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLength2.ForeColor = System.Drawing.Color.Black;
            this.textBoxLength2.Location = new System.Drawing.Point(541, 163);
            this.textBoxLength2.Multiline = true;
            this.textBoxLength2.Name = "textBoxLength2";
            this.textBoxLength2.Size = new System.Drawing.Size(190, 31);
            this.textBoxLength2.TabIndex = 12;
            this.textBoxLength2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(526, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 60);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 805);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.ComboBox comboBoxLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxLength2;
        private System.Windows.Forms.ComboBox comboBoxLength2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonConvert1;
        private System.Windows.Forms.Button buttonConvert4;
        private System.Windows.Forms.TextBox textBoxWeight2;
        private System.Windows.Forms.ComboBox comboBoxWeight2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.ComboBox comboBoxWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button buttonConvert3;
        private System.Windows.Forms.TextBox textBoxVolume2;
        private System.Windows.Forms.ComboBox comboBoxVolume2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.ComboBox comboBoxVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonConvert2;
        private System.Windows.Forms.TextBox textBoxArea2;
        private System.Windows.Forms.ComboBox comboBoxArea2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
    }
}
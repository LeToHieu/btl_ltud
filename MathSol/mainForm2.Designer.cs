namespace MathSol
{
    partial class mainForm2
    {

        private System.ComponentModel.IContainer components = null;
        private MathSol.CircularPictureBox circularPictureBox;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm2));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubGeometry = new System.Windows.Forms.Panel();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.btnGeometry = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSubArray = new System.Windows.Forms.Panel();
            this.buttonSpaceArr = new System.Windows.Forms.Button();
            this.btnArrAvg = new System.Windows.Forms.Button();
            this.btnArrSort = new System.Windows.Forms.Button();
            this.btnArray = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circularPictureBox2 = new MathSol.CircularPictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelSubGeometry.SuspendLayout();
            this.panelSubArray.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panelSideMenu.Controls.Add(this.panelSubGeometry);
            this.panelSideMenu.Controls.Add(this.btnGeometry);
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.panelSubArray);
            this.panelSideMenu.Controls.Add(this.btnArray);
            this.panelSideMenu.Controls.Add(this.btnConverter);
            this.panelSideMenu.Controls.Add(this.btnCal);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelSubGeometry
            // 
            this.panelSubGeometry.Controls.Add(this.btnArea);
            this.panelSubGeometry.Controls.Add(this.btnPerimeter);
            this.panelSubGeometry.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubGeometry.Location = new System.Drawing.Point(0, 426);
            this.panelSubGeometry.Name = "panelSubGeometry";
            this.panelSubGeometry.Size = new System.Drawing.Size(250, 85);
            this.panelSubGeometry.TabIndex = 11;
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.Firebrick;
            this.btnArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArea.FlatAppearance.BorderSize = 0;
            this.btnArea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArea.ForeColor = System.Drawing.Color.White;
            this.btnArea.Location = new System.Drawing.Point(0, 40);
            this.btnArea.Name = "btnArea";
            this.btnArea.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnArea.Size = new System.Drawing.Size(250, 40);
            this.btnArea.TabIndex = 3;
            this.btnArea.Text = "Tính diện tích";
            this.btnArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.BackColor = System.Drawing.Color.Firebrick;
            this.btnPerimeter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerimeter.FlatAppearance.BorderSize = 0;
            this.btnPerimeter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPerimeter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPerimeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerimeter.ForeColor = System.Drawing.Color.White;
            this.btnPerimeter.Location = new System.Drawing.Point(0, 0);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPerimeter.Size = new System.Drawing.Size(250, 40);
            this.btnPerimeter.TabIndex = 2;
            this.btnPerimeter.Text = "Tính chu vi";
            this.btnPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerimeter.UseVisualStyleBackColor = false;
            this.btnPerimeter.Click += new System.EventHandler(this.btnPerimeter_Click);
            // 
            // btnGeometry
            // 
            this.btnGeometry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeometry.FlatAppearance.BorderSize = 0;
            this.btnGeometry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGeometry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGeometry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeometry.ForeColor = System.Drawing.Color.White;
            this.btnGeometry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeometry.Location = new System.Drawing.Point(0, 381);
            this.btnGeometry.Name = "btnGeometry";
            this.btnGeometry.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGeometry.Size = new System.Drawing.Size(250, 45);
            this.btnGeometry.TabIndex = 10;
            this.btnGeometry.Text = "  Hình học";
            this.btnGeometry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeometry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeometry.UseVisualStyleBackColor = true;
            this.btnGeometry.Click += new System.EventHandler(this.btnGeometry_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 516);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 45);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelSubArray
            // 
            this.panelSubArray.BackColor = System.Drawing.Color.Firebrick;
            this.panelSubArray.Controls.Add(this.buttonSpaceArr);
            this.panelSubArray.Controls.Add(this.btnArrAvg);
            this.panelSubArray.Controls.Add(this.btnArrSort);
            this.panelSubArray.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubArray.Location = new System.Drawing.Point(0, 257);
            this.panelSubArray.Name = "panelSubArray";
            this.panelSubArray.Size = new System.Drawing.Size(250, 124);
            this.panelSubArray.TabIndex = 7;
            // 
            // buttonSpaceArr
            // 
            this.buttonSpaceArr.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSpaceArr.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSpaceArr.FlatAppearance.BorderSize = 0;
            this.buttonSpaceArr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSpaceArr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSpaceArr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpaceArr.ForeColor = System.Drawing.Color.White;
            this.buttonSpaceArr.Location = new System.Drawing.Point(0, 80);
            this.buttonSpaceArr.Name = "buttonSpaceArr";
            this.buttonSpaceArr.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSpaceArr.Size = new System.Drawing.Size(250, 40);
            this.buttonSpaceArr.TabIndex = 2;
            this.buttonSpaceArr.Text = "Dãy số cách đều";
            this.buttonSpaceArr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSpaceArr.UseVisualStyleBackColor = false;
            this.buttonSpaceArr.Click += new System.EventHandler(this.btnSpaceArr_Click);
            // 
            // btnArrAvg
            // 
            this.btnArrAvg.BackColor = System.Drawing.Color.Firebrick;
            this.btnArrAvg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArrAvg.FlatAppearance.BorderSize = 0;
            this.btnArrAvg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnArrAvg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnArrAvg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrAvg.ForeColor = System.Drawing.Color.White;
            this.btnArrAvg.Location = new System.Drawing.Point(0, 40);
            this.btnArrAvg.Name = "btnArrAvg";
            this.btnArrAvg.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnArrAvg.Size = new System.Drawing.Size(250, 40);
            this.btnArrAvg.TabIndex = 1;
            this.btnArrAvg.Text = "Tìm trung bình cộng ";
            this.btnArrAvg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArrAvg.UseVisualStyleBackColor = false;
            this.btnArrAvg.Click += new System.EventHandler(this.btnArrAvg_Click);
            // 
            // btnArrSort
            // 
            this.btnArrSort.BackColor = System.Drawing.Color.Firebrick;
            this.btnArrSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArrSort.FlatAppearance.BorderSize = 0;
            this.btnArrSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnArrSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnArrSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrSort.ForeColor = System.Drawing.Color.White;
            this.btnArrSort.Location = new System.Drawing.Point(0, 0);
            this.btnArrSort.Name = "btnArrSort";
            this.btnArrSort.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnArrSort.Size = new System.Drawing.Size(250, 40);
            this.btnArrSort.TabIndex = 0;
            this.btnArrSort.Text = "Sắp xếp dãy số";
            this.btnArrSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArrSort.UseVisualStyleBackColor = false;
            this.btnArrSort.Click += new System.EventHandler(this.btnArrSort_Click);
            // 
            // btnArray
            // 
            this.btnArray.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArray.FlatAppearance.BorderSize = 0;
            this.btnArray.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnArray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnArray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArray.ForeColor = System.Drawing.Color.White;
            this.btnArray.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArray.Location = new System.Drawing.Point(0, 212);
            this.btnArray.Name = "btnArray";
            this.btnArray.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnArray.Size = new System.Drawing.Size(250, 45);
            this.btnArray.TabIndex = 6;
            this.btnArray.Text = "  Dãy số";
            this.btnArray.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArray.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConverter.FlatAppearance.BorderSize = 0;
            this.btnConverter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConverter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.ForeColor = System.Drawing.Color.White;
            this.btnConverter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConverter.Location = new System.Drawing.Point(0, 167);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConverter.Size = new System.Drawing.Size(250, 45);
            this.btnConverter.TabIndex = 5;
            this.btnConverter.Text = "  Đổi đơn vị";
            this.btnConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConverter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnCal
            // 
            this.btnCal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCal.FlatAppearance.BorderSize = 0;
            this.btnCal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.ForeColor = System.Drawing.Color.White;
            this.btnCal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCal.Location = new System.Drawing.Point(0, 122);
            this.btnCal.Name = "btnCal";
            this.btnCal.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCal.Size = new System.Drawing.Size(250, 45);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "  Tính toán";
            this.btnCal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 122);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MathSol.Properties.Resources.logowhite;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 65);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 496);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Click += new System.EventHandler(this.circularPictureBox2_Click);
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.labelName);
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.Title);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(250, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(684, 65);
            this.panelTop.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.labelName.Location = new System.Drawing.Point(493, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(128, 65);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Hoàn";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.circularPictureBox2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(621, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 65);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // circularPictureBox2
            // 
            this.circularPictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.circularPictureBox2.Enabled = false;
            this.circularPictureBox2.Image = global::MathSol.Properties.Resources.nd2;
            this.circularPictureBox2.Location = new System.Drawing.Point(7, 5);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(47, 47);
            this.circularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox2.TabIndex = 2;
            this.circularPictureBox2.TabStop = false;
            this.circularPictureBox2.Click += new System.EventHandler(this.circularPictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(7, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 43);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.circularPictureBox2_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(262, 65);
            this.Title.TabIndex = 0;
            this.Title.Text = "  Tính toán";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // mainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "mainForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toán cấp 1";
            this.Load += new System.EventHandler(this.mainForm2_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubGeometry.ResumeLayout(false);
            this.panelSubArray.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private string FullName = "";
        private string UserName = "";
        private string UserImage = "";
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Panel panelSubArray;
        private System.Windows.Forms.Button buttonSpaceArr;
        private System.Windows.Forms.Button btnArrAvg;
        private System.Windows.Forms.Button btnArrSort;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelChildForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelSubGeometry;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnPerimeter;
        private System.Windows.Forms.Button btnGeometry;
        private System.Windows.Forms.Panel panelTop;
        private CircularPictureBox circularPictureBox2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        
    }
}


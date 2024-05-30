using System;
using System.Windows.Forms;

namespace MathSol
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.ChangePass = new System.Windows.Forms.Label();
            this.oldPass = new System.Windows.Forms.Label();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.PasswordError = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.PictureBox();
            this.textBoxNewPassConf = new System.Windows.Forms.TextBox();
            this.newPassConfirm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.circularPictureBoxAva = new MathSol.CircularPictureBox();
            this.circularPictureBox3 = new MathSol.CircularPictureBox();
            this.Check = new System.Windows.Forms.PictureBox();
            this.PasswordCheck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBoxAva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangePass
            // 
            this.ChangePass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChangePass.AutoSize = true;
            this.ChangePass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePass.ForeColor = System.Drawing.Color.DimGray;
            this.ChangePass.Location = new System.Drawing.Point(92, 419);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(231, 39);
            this.ChangePass.TabIndex = 2;
            this.ChangePass.Text = "Đổi mật khẩu";
            this.ChangePass.Click += new System.EventHandler(this.LoginToUse_Click);
            // 
            // oldPass
            // 
            this.oldPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.oldPass.AutoSize = true;
            this.oldPass.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oldPass.Location = new System.Drawing.Point(94, 495);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(127, 25);
            this.oldPass.TabIndex = 3;
            this.oldPass.Text = "Mật khẩu cũ";
            this.oldPass.Click += new System.EventHandler(this.Username_Click);
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxOldPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOldPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOldPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxOldPass.Location = new System.Drawing.Point(98, 530);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.Size = new System.Drawing.Size(459, 39);
            this.textBoxOldPass.TabIndex = 4;
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNewPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNewPass.Location = new System.Drawing.Point(98, 636);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(459, 39);
            this.textBoxNewPass.TabIndex = 6;
            // 
            // newPass
            // 
            this.newPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newPass.AutoSize = true;
            this.newPass.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPass.Location = new System.Drawing.Point(94, 594);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(140, 25);
            this.newPass.TabIndex = 5;
            this.newPass.Text = "Mật khẩu mới";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogin.BackColor = System.Drawing.Color.Red;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(160, 873);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(338, 78);
            this.buttonLogin.TabIndex = 16;
            this.buttonLogin.Text = "Đổi mật khẩu";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // PasswordError
            // 
            this.PasswordError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordError.AutoSize = true;
            this.PasswordError.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordError.Location = new System.Drawing.Point(154, 798);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(343, 25);
            this.PasswordError.TabIndex = 13;
            this.PasswordError.Text = "Mật khẩu bạn nhập chưa chính xác";
            this.PasswordError.Visible = false;
            // 
            // Error
            // 
            this.Error.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Error.Image = global::MathSol.Properties.Resources.icons8_error_90;
            this.Error.Location = new System.Drawing.Point(112, 797);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(38, 27);
            this.Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error.TabIndex = 14;
            this.Error.TabStop = false;
            this.Error.Visible = false;
            // 
            // textBoxNewPassConf
            // 
            this.textBoxNewPassConf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNewPassConf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNewPassConf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewPassConf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassConf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNewPassConf.Location = new System.Drawing.Point(98, 741);
            this.textBoxNewPassConf.Name = "textBoxNewPassConf";
            this.textBoxNewPassConf.Size = new System.Drawing.Size(459, 39);
            this.textBoxNewPassConf.TabIndex = 7;
            this.textBoxNewPassConf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // newPassConfirm
            // 
            this.newPassConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newPassConfirm.AutoSize = true;
            this.newPassConfirm.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPassConfirm.Location = new System.Drawing.Point(93, 697);
            this.newPassConfirm.Name = "newPassConfirm";
            this.newPassConfirm.Size = new System.Drawing.Size(226, 25);
            this.newPassConfirm.TabIndex = 15;
            this.newPassConfirm.Text = "Nhập lại mật khẩu mới";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 205);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sửa ảnh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Red;
            this.labelName.Location = new System.Drawing.Point(-156, 330);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(969, 52);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Nguyễn Đình Hoàn";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // circularPictureBoxAva
            // 
            this.circularPictureBoxAva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.circularPictureBoxAva.Image = global::MathSol.Properties.Resources.nd2;
            this.circularPictureBoxAva.Location = new System.Drawing.Point(204, 45);
            this.circularPictureBoxAva.Name = "circularPictureBoxAva";
            this.circularPictureBoxAva.Size = new System.Drawing.Size(250, 250);
            this.circularPictureBoxAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBoxAva.TabIndex = 18;
            this.circularPictureBoxAva.TabStop = false;
            // 
            // circularPictureBox3
            // 
            this.circularPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.circularPictureBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.circularPictureBox3.Location = new System.Drawing.Point(201, 44);
            this.circularPictureBox3.Name = "circularPictureBox3";
            this.circularPictureBox3.Size = new System.Drawing.Size(256, 256);
            this.circularPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox3.TabIndex = 20;
            this.circularPictureBox3.TabStop = false;
            // 
            // Check
            // 
            this.Check.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Check.Image = global::MathSol.Properties.Resources.icons8_error_90;
            this.Check.Location = new System.Drawing.Point(111, 798);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(38, 27);
            this.Check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Check.TabIndex = 25;
            this.Check.TabStop = false;
            this.Check.Visible = false;
            // 
            // PasswordCheck
            // 
            this.PasswordCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordCheck.AutoSize = true;
            this.PasswordCheck.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordCheck.Location = new System.Drawing.Point(154, 798);
            this.PasswordCheck.Name = "PasswordCheck";
            this.PasswordCheck.Size = new System.Drawing.Size(343, 25);
            this.PasswordCheck.TabIndex = 24;
            this.PasswordCheck.Text = "Mật khẩu bạn nhập chưa chính xác";
            this.PasswordCheck.Visible = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 1072);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.PasswordCheck);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.circularPictureBoxAva);
            this.Controls.Add(this.circularPictureBox3);
            this.Controls.Add(this.textBoxNewPassConf);
            this.Controls.Add(this.newPassConfirm);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.textBoxOldPass);
            this.Controls.Add(this.oldPass);
            this.Controls.Add(this.ChangePass);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfileForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toán Cấp 1";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBoxAva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private string FullName;
        private string UserName;
        private string UserImage;
        private string imageLocation = "";

        private System.Windows.Forms.Label ChangePass;
        private System.Windows.Forms.Label oldPass;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label newPass;
        private System.Windows.Forms.Button buttonLogin;
        private Label PasswordError;
        private PictureBox Error;
        private TextBox textBoxNewPassConf;
        private Label newPassConfirm;
        private CircularPictureBox circularPictureBoxAva;
        private CircularPictureBox circularPictureBox3;
        private Panel panel1;
        private Label label2;
        private Label labelName;
        private PictureBox Check;
        private Label PasswordCheck;
    }
}

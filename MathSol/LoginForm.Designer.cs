using System.Windows.Forms;

namespace MathSol
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoginToUse = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.noAccount = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.PasswordError = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsernameBox = new System.Windows.Forms.PictureBox();
            this.PasswordBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginToUse
            // 
            this.LoginToUse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginToUse.AutoSize = true;
            this.LoginToUse.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginToUse.ForeColor = System.Drawing.Color.Red;
            this.LoginToUse.Location = new System.Drawing.Point(72, 269);
            this.LoginToUse.Name = "LoginToUse";
            this.LoginToUse.Size = new System.Drawing.Size(515, 45);
            this.LoginToUse.TabIndex = 2;
            this.LoginToUse.Text = "Hãy đăng nhập để sử dụng";
            this.LoginToUse.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username.Location = new System.Drawing.Point(78, 359);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(194, 33);
            this.Username.TabIndex = 3;
            this.Username.Text = "Tên đăng nhập";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxUsername.Location = new System.Drawing.Point(98, 412);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(464, 39);
            this.textBoxUsername.TabIndex = 4;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword.Location = new System.Drawing.Point(98, 552);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(464, 39);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.Location = new System.Drawing.Point(78, 498);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(124, 33);
            this.password.TabIndex = 5;
            this.password.Text = "Mật khẩu";
            this.password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogin.BackColor = System.Drawing.Color.Red;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(82, 767);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(496, 81);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // noAccount
            // 
            this.noAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.noAccount.AutoSize = true;
            this.noAccount.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.noAccount.ForeColor = System.Drawing.Color.LightSlateGray;
            this.noAccount.Location = new System.Drawing.Point(210, 894);
            this.noAccount.Name = "noAccount";
            this.noAccount.Size = new System.Drawing.Size(239, 27);
            this.noAccount.TabIndex = 8;
            this.noAccount.Text = "Bạn chưa có tài khoản?";
            this.noAccount.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Register
            // 
            this.Register.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Register.AutoSize = true;
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.Red;
            this.Register.Location = new System.Drawing.Point(276, 931);
            this.Register.Margin = new System.Windows.Forms.Padding(3, 0, 3, 50);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(94, 29);
            this.Register.TabIndex = 9;
            this.Register.Text = "Đăng kí";
            this.Register.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPass.ForeColor = System.Drawing.Color.LightSlateGray;
            this.checkBoxShowPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxShowPass.Location = new System.Drawing.Point(368, 653);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(207, 29);
            this.checkBoxShowPass.TabIndex = 10;
            this.checkBoxShowPass.Text = "Hiển thị mật khẩu";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // PasswordError
            // 
            this.PasswordError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordError.AutoSize = true;
            this.PasswordError.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordError.Location = new System.Drawing.Point(129, 619);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(343, 25);
            this.PasswordError.TabIndex = 13;
            this.PasswordError.Text = "Mật khẩu bạn nhập chưa chính xác";
            this.PasswordError.Visible = false;
            this.PasswordError.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // Error
            // 
            this.Error.Image = global::MathSol.Properties.Resources.icons8_error_90;
            this.Error.Location = new System.Drawing.Point(86, 617);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(38, 27);
            this.Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error.TabIndex = 14;
            this.Error.TabStop = false;
            this.Error.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::MathSol.Properties.Resources.tc1;
            this.pictureBox1.Location = new System.Drawing.Point(201, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UsernameBox
            // 
            this.UsernameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameBox.Location = new System.Drawing.Point(82, 402);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(496, 59);
            this.UsernameBox.TabIndex = 11;
            this.UsernameBox.TabStop = false;
            this.UsernameBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordBox.Location = new System.Drawing.Point(82, 542);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(496, 59);
            this.PasswordBox.TabIndex = 12;
            this.PasswordBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 1023);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.noAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LoginToUse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.PasswordBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toán Cấp 1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LoginToUse;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button buttonLogin;
        private Label noAccount;
        private Label Register;
        private CheckBox checkBoxShowPass;
        private PictureBox UsernameBox;
        private PictureBox PasswordBox;
        private Label PasswordError;
        private PictureBox Error;
        private Users myUser = new Users();
    }
}

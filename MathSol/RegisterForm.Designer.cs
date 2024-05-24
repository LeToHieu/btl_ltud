namespace MathSol
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.BackToLogin = new System.Windows.Forms.Label();
            this.haveAccount = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.CreateAccount = new System.Windows.Forms.Label();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.ConfirmPass = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.PictureBox();
            this.PasswordError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToLogin
            // 
            this.BackToLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BackToLogin.AutoSize = true;
            this.BackToLogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToLogin.ForeColor = System.Drawing.Color.Red;
            this.BackToLogin.Location = new System.Drawing.Point(218, 1147);
            this.BackToLogin.Margin = new System.Windows.Forms.Padding(3, 0, 3, 50);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(223, 29);
            this.BackToLogin.TabIndex = 18;
            this.BackToLogin.Text = "Quay lại Đăng nhập";
            this.BackToLogin.Click += new System.EventHandler(this.BackLogin_Click);
            // 
            // haveAccount
            // 
            this.haveAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.haveAccount.AutoSize = true;
            this.haveAccount.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.haveAccount.ForeColor = System.Drawing.Color.LightSlateGray;
            this.haveAccount.Location = new System.Drawing.Point(220, 1109);
            this.haveAccount.Name = "haveAccount";
            this.haveAccount.Size = new System.Drawing.Size(217, 27);
            this.haveAccount.TabIndex = 17;
            this.haveAccount.Text = "Bạn đã có tài khoản?";
            this.haveAccount.Click += new System.EventHandler(this.noAccount_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRegister.BackColor = System.Drawing.Color.Red;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegister.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(81, 938);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(496, 81);
            this.buttonRegister.TabIndex = 22;
            this.buttonRegister.Text = "Đăng kí";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword.Location = new System.Drawing.Point(81, 591);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(496, 59);
            this.textBoxPassword.TabIndex = 15;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Red;
            this.password.Location = new System.Drawing.Point(78, 548);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(124, 33);
            this.password.TabIndex = 14;
            this.password.Text = "Mật khẩu";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxUsername.Location = new System.Drawing.Point(81, 452);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(496, 59);
            this.textBoxUsername.TabIndex = 13;
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Red;
            this.Username.Location = new System.Drawing.Point(78, 408);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(194, 33);
            this.Username.TabIndex = 12;
            this.Username.Text = "Tên đăng nhập";
            // 
            // CreateAccount
            // 
            this.CreateAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateAccount.AutoSize = true;
            this.CreateAccount.Font = new System.Drawing.Font("Tahoma", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount.ForeColor = System.Drawing.Color.Red;
            this.CreateAccount.Location = new System.Drawing.Point(72, 148);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(391, 64);
            this.CreateAccount.TabIndex = 11;
            this.CreateAccount.Text = "Tạo tài khoản";
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPassword2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPassword2.Location = new System.Drawing.Point(81, 747);
            this.textBoxPassword2.Multiline = true;
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(496, 59);
            this.textBoxPassword2.TabIndex = 20;
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfirmPass.AutoSize = true;
            this.ConfirmPass.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPass.ForeColor = System.Drawing.Color.Red;
            this.ConfirmPass.Location = new System.Drawing.Point(78, 705);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.Size = new System.Drawing.Size(230, 33);
            this.ConfirmPass.TabIndex = 19;
            this.ConfirmPass.Text = "Nhập lại mật khẩu";
            this.ConfirmPass.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFullName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFullName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFullName.Location = new System.Drawing.Point(81, 317);
            this.textBoxFullName.Multiline = true;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(496, 59);
            this.textBoxFullName.TabIndex = 15;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FullName
            // 
            this.FullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.ForeColor = System.Drawing.Color.Red;
            this.FullName.Location = new System.Drawing.Point(78, 273);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(129, 33);
            this.FullName.TabIndex = 21;
            this.FullName.Text = "Họ và tên";
            this.FullName.Click += new System.EventHandler(this.label2_Click);
            // 
            // Error
            // 
            this.Error.Image = global::MathSol.Properties.Resources.icons8_error_90;
            this.Error.Location = new System.Drawing.Point(87, 846);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(37, 27);
            this.Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error.TabIndex = 24;
            this.Error.TabStop = false;
            this.Error.Visible = false;
            // 
            // PasswordError
            // 
            this.PasswordError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordError.AutoSize = true;
            this.PasswordError.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordError.Location = new System.Drawing.Point(130, 848);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(343, 25);
            this.PasswordError.TabIndex = 23;
            this.PasswordError.Text = "Mật khẩu bạn nhập chưa chính xác";
            this.PasswordError.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 1231);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.ConfirmPass);
            this.Controls.Add(this.BackToLogin);
            this.Controls.Add(this.haveAccount);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.CreateAccount);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toán Cấp 1";
            this.Load += new System.EventHandler(this.MathGeek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BackToLogin;
        private System.Windows.Forms.Label haveAccount;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label CreateAccount;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.Label ConfirmPass;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.PictureBox Error;
        private System.Windows.Forms.Label PasswordError;
    }
}
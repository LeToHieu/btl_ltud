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
            this.SuspendLayout();
            // 
            // BackToLogin
            // 
            this.BackToLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BackToLogin.AutoSize = true;
            this.BackToLogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToLogin.ForeColor = System.Drawing.Color.Red;
            this.BackToLogin.Location = new System.Drawing.Point(145, 734);
            this.BackToLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 32);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(136, 18);
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
            this.haveAccount.Location = new System.Drawing.Point(147, 710);
            this.haveAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.haveAccount.Name = "haveAccount";
            this.haveAccount.Size = new System.Drawing.Size(136, 17);
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
            this.buttonRegister.Location = new System.Drawing.Point(54, 600);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(331, 52);
            this.buttonRegister.TabIndex = 16;
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
            this.textBoxPassword.Location = new System.Drawing.Point(54, 378);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(331, 38);
            this.textBoxPassword.TabIndex = 15;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Red;
            this.password.Location = new System.Drawing.Point(52, 351);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(78, 21);
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
            this.textBoxUsername.Location = new System.Drawing.Point(54, 289);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(331, 38);
            this.textBoxUsername.TabIndex = 13;
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Red;
            this.Username.Location = new System.Drawing.Point(52, 261);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(121, 21);
            this.Username.TabIndex = 12;
            this.Username.Text = "Tên đăng nhập";
            // 
            // CreateAccount
            // 
            this.CreateAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateAccount.AutoSize = true;
            this.CreateAccount.Font = new System.Drawing.Font("Tahoma", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount.ForeColor = System.Drawing.Color.Red;
            this.CreateAccount.Location = new System.Drawing.Point(48, 95);
            this.CreateAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(249, 41);
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
            this.textBoxPassword2.Location = new System.Drawing.Point(54, 478);
            this.textBoxPassword2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword2.Multiline = true;
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(331, 38);
            this.textBoxPassword2.TabIndex = 20;
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfirmPass.AutoSize = true;
            this.ConfirmPass.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPass.ForeColor = System.Drawing.Color.Red;
            this.ConfirmPass.Location = new System.Drawing.Point(52, 451);
            this.ConfirmPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.Size = new System.Drawing.Size(144, 21);
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
            this.textBoxFullName.Location = new System.Drawing.Point(54, 203);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFullName.Multiline = true;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(331, 38);
            this.textBoxFullName.TabIndex = 22;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FullName
            // 
            this.FullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.ForeColor = System.Drawing.Color.Red;
            this.FullName.Location = new System.Drawing.Point(52, 175);
            this.FullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(81, 21);
            this.FullName.TabIndex = 21;
            this.FullName.Text = "Họ và tên";
            this.FullName.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 788);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toán Cấp 1";
            this.Load += new System.EventHandler(this.MathGeek_Load);
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
    }
}
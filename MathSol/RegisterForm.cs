using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MathSol
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void noAccount_Click(object sender, EventArgs e)
        {

        }

        private void MathGeek_Load(object sender, EventArgs e)
        {

        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Error.Hide();
            PasswordError.Hide();
            Users users = new Users();
            string name = textBoxFullName.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string repassword = textBoxPassword2.Text;

            if (name == null || username == null || password == null || repassword == null) { return ; }

            if (name == "" || username == "" || password == "" || repassword == "") { return ; }
     
            if (password == repassword)
            {
                
                if (users.register(name, username, password))
                {
                    this.Close();
                }
                else
                {
                    Error.Show();
                    PasswordError.Text = "Tài khoản đã tồn tại";
                    PasswordError.Show();
                }
            }
            else
            {
                Error.Show();
                PasswordError.Text = "Mật khẩu không trùng khớp";
                PasswordError.Show();
            }

        }

        private void BackLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

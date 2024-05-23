using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSol
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            this.Hide();

            registerForm.ShowDialog();

            this.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                // Hiển thị mật khẩu
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            
            if (myUser.login(username, password))
            {
                this.Hide();
                mainForm2 mainForm = new mainForm2();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
    
                /*this.Close();*/
            }
            else
            {
                PasswordError.Visible = true;
                Error.Visible = true;
            }
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}

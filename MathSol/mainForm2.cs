using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSol
{
    public partial class mainForm2 : Form
    {
    
        private Button currentButton;

        ProfileForm ProfileForm = null;
        public mainForm2(string name,string username, string image)
        {
            
            InitializeComponent();
            hideSubMenu();
            this.labelName.Text = name;
            this.UserName = username;
            this.FullName = name;

            this.UserImage = image;
            if (image != "default.jpg")
            {
                this.circularPictureBox2.ImageLocation = "Resources/" + image;
            }
            if (ProfileForm != null)
            {
                this.FormClosed += (s, args) => ProfileForm.Close();
            }
            openChildForm(new Form1());
        }

       

        private void hideSubMenu()
        {
            panelSubGeometry.Visible = false;
            panelSubArray.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void UpdateButtonColors(Button clickedButton)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = clickedButton.BackColor;
                currentButton.ForeColor = clickedButton.ForeColor;
                currentButton.FlatAppearance.MouseOverBackColor = clickedButton.FlatAppearance.MouseOverBackColor;
                currentButton.FlatAppearance.MouseDownBackColor = clickedButton.FlatAppearance.MouseDownBackColor;
            }
            currentButton = clickedButton;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LoginForm = new LoginForm();
   
            LoginForm.FormClosed += (s, args) => this.Close();
            LoginForm.Show();

            if (ProfileForm != null)
            {
                ProfileForm.Close();
                ProfileForm = null;
                return;
            }
        }

        
        private void circularPictureBox2_Click(object sender, EventArgs e)
        {
            if (ProfileForm != null)
            {
                ProfileForm.Close();
                ProfileForm = null;
                
            }
            ProfileForm = new ProfileForm(FullName, UserName, UserImage, this);
            ProfileForm.Show();


        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubGeometry);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            Title.Text = btnCal.Text;
            UpdateButtonColors(sender as Button);
            openChildForm(new Form1());
            btnCal.BackColor = System.Drawing.Color.White;
            btnCal.ForeColor = System.Drawing.Color.Red;
            btnCal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnCal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            Title.Text = btnConverter.Text;
            UpdateButtonColors(sender as Button);
            openChildForm(new Form2());
            btnConverter.BackColor = System.Drawing.Color.White;
            btnConverter.ForeColor = System.Drawing.Color.Red;
            btnConverter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnConverter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubArray);
            UpdateButtonColors(sender as Button);
            btnArray.BackColor = System.Drawing.Color.White;
            btnArray.ForeColor = System.Drawing.Color.Red;
            btnArray.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnArray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
        }

        private void btnArrSort_Click(object sender, EventArgs e)
        {
            Title.Text = "  " + btnArrSort.Text;
            openChildForm(new Form3());
            hideSubMenu();
            
            
        }

        private void btnArrAvg_Click(object sender, EventArgs e)
        {
            Title.Text ="  " + btnArrAvg.Text;
            openChildForm(new Form4());
            
            hideSubMenu();
        }

        private void btnSpaceArr_Click(object sender, EventArgs e)
        {
            Title.Text = "  " + buttonSpaceArr.Text;
            openChildForm(new Form5());

            hideSubMenu();
        }

        private void btnGeometry_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubGeometry);
            UpdateButtonColors(sender as Button);
            btnGeometry.BackColor = System.Drawing.Color.White;
            btnGeometry.ForeColor = System.Drawing.Color.Red;
            btnGeometry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnGeometry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            Title.Text = "  " + btnPerimeter.Text;
            openChildForm(new Form6());
            hideSubMenu();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Title.Text = "  " + btnArea.Text;
            openChildForm(new Form7());
            hideSubMenu();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void updateUser(string image)
        {
         
            this.UserImage = image;
            this.circularPictureBox2.ImageLocation = "Resources/" + image;
        }

        private void mainForm2_Load(object sender, EventArgs e)
        {

        }
    }
}

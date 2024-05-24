﻿using System;
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
        public mainForm2()
        {
            InitializeComponent();
            hideSubMenu();
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
            LoginForm.Show();
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
        }

        private void btnArrSort_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnArrAvg_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSpaceArr_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnGeometry_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubGeometry);
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void circularPictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {
            ProfileForm ProfileForm = new ProfileForm();
            ProfileForm.Show();
        }
    }
}

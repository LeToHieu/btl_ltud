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

        private void btnMedia_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubArray);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
            //..
            //your codes
            //..
            hideSubMenu();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

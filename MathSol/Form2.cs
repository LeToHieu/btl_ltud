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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLength_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxLength.Text))
            {
                textBoxLength.Text = "Nhập giá trị...";
                textBoxLength.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        private void textBoxLength_Enter(object sender, EventArgs e)
        {
            if (textBoxLength.Text == "Nhập giá trị...")
            {
                textBoxLength.Text = "";
                textBoxLength.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxArea_Enter(object sender, EventArgs e)
        {
            if (textBoxArea.Text == "Nhập giá trị...")
            {
                textBoxArea.Text = "";
                textBoxArea.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxArea_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxArea.Text))
            {
                textBoxArea.Text = "Nhập giá trị...";
                textBoxArea.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        private void textBoxVolume_Enter(object sender, EventArgs e)
        {
            if (textBoxVolume.Text == "Nhập giá trị...")
            {
                textBoxVolume.Text = "";
                textBoxVolume.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxVolume_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxVolume.Text))
            {
                textBoxVolume.Text = "Nhập giá trị...";
                textBoxVolume.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        private void textBoxWeight_Enter(object sender, EventArgs e)
        {
            if (textBoxWeight.Text == "Nhập giá trị...")
            {
                textBoxWeight.Text = "";
                textBoxWeight.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBoxWeight_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxWeight.Text))
            {
                textBoxWeight.Text = "Nhập giá trị...";
                textBoxWeight.ForeColor = System.Drawing.Color.DimGray;
            }
        }
    }
}

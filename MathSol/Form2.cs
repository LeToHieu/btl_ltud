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
            comboBoxLength.SelectedIndex = 3; comboBoxLength2.SelectedIndex = 5;
            comboBoxArea.SelectedIndex = 3; comboBoxArea2.SelectedIndex = 5;
            comboBoxVolume.SelectedIndex = 0; comboBoxVolume2.SelectedIndex = 7;
            comboBoxWeight.SelectedIndex = 3; comboBoxWeight2.SelectedIndex = 6;
        }

        private void convertLengthClick(object sender, EventArgs e)
        {
            int index = comboBoxLength.SelectedIndex;
            int index2 = comboBoxLength2.SelectedIndex;
            string input = textBoxLength.Text;

            double[] factorsToMeters = { 1000, 100, 10, 1, 0.1, 0.01, 0.001 };

            if (!double.TryParse(input, out double inputValue))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            double valueInMeters = inputValue * factorsToMeters[index];
            double outputValue = valueInMeters / factorsToMeters[index2];

            textBoxLength2.Text = outputValue.ToString();
        }

        private void convertAreaClick(object sender, EventArgs e)
        {
            int index = comboBoxArea.SelectedIndex;
            int index2 = comboBoxArea2.SelectedIndex;
            string input = textBoxArea.Text;

            double[] factorsToSquareMeters = { 1000000, 10000, 100, 1, 0.01, 0.0001, 0.000001 };

            if (!double.TryParse(input, out double inputValue))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
            double valueInSquareMeters = inputValue * factorsToSquareMeters[index];

            double outputValue = valueInSquareMeters / factorsToSquareMeters[index2];

            textBoxArea2.Text = outputValue.ToString();
        }

        private void convertVolumeClick(object sender, EventArgs e)
        {
            int index = comboBoxVolume.SelectedIndex;
            int index2 = comboBoxVolume2.SelectedIndex;
            string input = textBoxVolume.Text;


            double[] factorsToCubicMeters = {
                    0.001,        
                    0.000001,     
                    1e9,          
                    1e6,         
                    1e3,          
                    1,            
                    1e-3,           
                    1e-6,         
                    1e-9          
                };

            if (!double.TryParse(input, out double inputValue))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }
                

            double valueInCubicMeters = inputValue * factorsToCubicMeters[index];

            double outputValue = valueInCubicMeters / factorsToCubicMeters[index2];

            textBoxVolume2.Text = outputValue.ToString();
        }

        private void convertWeightClick(object sender, EventArgs e)
        {
            int index = comboBoxWeight.SelectedIndex;
            int index2 = comboBoxWeight2.SelectedIndex;
            string input = textBoxWeight.Text;

            double[] factorsToKilograms = {
                1000,     
                100,       
                10,       
                1,       
                0.1,      
                0.01,      
                0.001      
            };

            if (!double.TryParse(input, out double inputValue))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            double valueInKilograms = inputValue * factorsToKilograms[index];

            double outputValue = valueInKilograms / factorsToKilograms[index2];

            textBoxWeight2.Text = outputValue.ToString();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathSol
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            selectWayToSort_combo_box.SelectedIndex = 0;
        }

        private double[] ParseStringToDoubleArray(string input)
        {
            string[] parts = input.Split(',');

            double[] numbers = parts.Select(part =>
            {
                if (double.TryParse(part.Trim(), out double number))
                {
                    return number;
                }
                else
                {
                    throw new FormatException($"Phần tử '{part}' không phải là số hợp lệ.");
                }
            }).ToArray();

            return numbers;
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            
            string input = input_richTextBox.Text;
            input = input.Trim();
            int option = selectWayToSort_combo_box.SelectedIndex;
            double[] arr = null;
            string str = "";
            output_label.Text = "";
            try
            {
                switch (option)
                {
                    case 0:
                        arr = ParseStringToDoubleArray(input);
                        Array.Sort(arr);
                        str = string.Join(", ", arr);
                        output_help_label.Text = "Dãy số được sắp xếp tăng dần là:";
                        output_label.AppendText(str);
                        
                        Console.WriteLine(str);
                        break;
                    case 1:
                        arr = ParseStringToDoubleArray(input);
                        Array.Sort(arr);
                        Array.Reverse(arr);
                        str = string.Join(", ", arr);
                        output_help_label.Text = "Dãy số được sắp xếp giảm dần là:";
                        output_label.AppendText(str);
                        Console.WriteLine(str);
                        break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dãy số không hợp lệ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void hiddenExample(object sender, EventArgs e)
        {
            textBoxExample.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            input_richTextBox.Text = "";
            output_help_label.Text = "";
            output_label.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void focusToDummy(object sender, EventArgs e)
        {
            dummy.Focus();
        }
    }
}

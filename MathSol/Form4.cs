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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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

        private void hiddenExample(object sender, EventArgs e)
        {
            textBoxExample.Hide();
        }

        private void Cacl_Click(object sender, EventArgs e)
        {
            string input = input_richTextBox.Text;
            input = input.Trim();
            double sum = 0;
            double[] arr = null;
            string str = "";
            output_label.Text = "";
            try
            {
                arr = ParseStringToDoubleArray(input);
                output_help_label.Text = "Kết quả:";
                foreach (var item in arr)
                {
                    sum += item;
                }
                output_label.Text = "Tổng dãy số: " + sum + Environment.NewLine;

                output_label.Text += "Trung bình cộng dãy: " + (double)System.Math.Round(sum /arr.Length,2);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dãy số không hợp lệ");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            input_richTextBox.Text = "";
            output_help_label.Text = "";
            output_label.Text = "";
        }

        private void focusToDummy(object sender, EventArgs e)
        {
            dummy.Focus();
        }

        private void output_help_label_Click(object sender, EventArgs e)
        {

        }
    }
}

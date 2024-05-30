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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CalculateTriangleArea()
        {
            try
            {
                // Lấy giá trị từ các TextBox và chuyển đổi sang số
                double a = Convert.ToDouble(textBoxA.Text);
                double h = Convert.ToDouble(textBoxH.Text);

               
                    // Tính diện tích tam giác
                    double Area = 0.5 * (a * h);
                    // Hiển thị kết quả ra Label
                    labelResult.Text = "Diện tích tam giác là: " + Area.ToString();
            }
            catch (FormatException)
            {
                // Xử lý lỗi nếu đầu vào không phải là số
                labelResult.Text = "Vui lòng nhập vào các số hợp lệ.";
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác nếu có
                labelResult.Text = "Đã xảy ra lỗi: " + ex.Message;
            }
        }

        private void CalculateTriangleArea2()
        {
            try
            {
                // Lấy giá trị từ các TextBox và chuyển đổi sang số
                double a = Convert.ToDouble(textBoxA1.Text);
                double b = Convert.ToDouble(textBoxB1.Text);


                // Tính diện tích tam giác
                double Area = 0.5 * (a * b);
                // Hiển thị kết quả ra Label
                labelResult1.Text = "Diện tích tam giác là: " + Area.ToString();
            }
            catch (FormatException)
            {
                // Xử lý lỗi nếu đầu vào không phải là số
                labelResult1.Text = "Vui lòng nhập vào các số hợp lệ.";
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác nếu có
                labelResult1.Text = "Đã xảy ra lỗi: " + ex.Message;
            }
        }
            private void CalculateRectangleArea()
        {
            try
            {
                // Lấy giá trị từ các TextBox và chuyển đổi sang số
                double length = Convert.ToDouble(textBoxA2.Text);
                double width = Convert.ToDouble(textBoxB2.Text);

                // Kiểm tra xem các giá trị có hợp lệ không
                if (length > 0 && width > 0)
                {
                    // Tính diện tích hình chữ nhật
                    double area = length * width;
                    // Hiển thị kết quả ra Label
                    labelResult2.Text = "Diện tích hình chữ nhật là: " + area.ToString();
                }
                else
                {
                    labelResult2.Text = "Chiều dài và chiều rộng phải lớn hơn 0.";
                }
            }
            catch (FormatException)
            {
                // Xử lý lỗi nếu đầu vào không phải là số
                labelResult2.Text = "Vui lòng nhập vào các số hợp lệ.";
            }
        }

        private void CalculateSquareArea()
        {
            try
            {
                // Lấy giá trị từ các TextBox và chuyển đổi sang số
                double a = Convert.ToDouble(textBoxA3.Text);

                // Kiểm tra xem các giá trị có hợp lệ không
                if (a > 0)
                {
                    // Tính diện tích hình vuông
                    double area = a * a;
                    // Hiển thị kết quả ra Label
                    labelResult3.Text = "Diện tích hình vuông là: " + area.ToString();
                }
                else
                {
                    labelResult3.Text = "Chiều dài cạnh phải lớn hơn 0.";
                }
            }
            catch (FormatException)
            {
                // Xử lý lỗi nếu đầu vào không phải là số
                labelResult3.Text = "Vui lòng nhập vào các số hợp lệ.";
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác nếu có
                labelResult3.Text = "Đã xảy ra lỗi: " + ex.Message;
            }
        }

        private void CalculateTrapezoidArea()
        {
            try
            {
                // Lấy giá trị từ các TextBox và chuyển đổi sang số
                double a = Convert.ToDouble(textBoxA4.Text);
                double b = Convert.ToDouble(textBoxB4.Text);
                double h = Convert.ToDouble(textBoxH4.Text);
               

                // Kiểm tra xem các giá trị có hợp lệ không
                if (a > 0 && b > 0 && h > 0)
                {
                    // Tính diện tích hình thang
                    double area = (a + b) * h * 0.5;
                    // Hiển thị kết quả ra Label
                    labelResult4.Text = "Diện tích hình thang là: " + area.ToString();
                }
                else
                {
                    labelResult4.Text = "Các cạnh và đường cao phải lớn hơn 0.";
                }
            }
            catch (FormatException)
            {
                // Xử lý lỗi nếu đầu vào không phải là số
                labelResult4.Text = "Vui lòng nhập vào các số hợp lệ.";
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác nếu có
                labelResult4.Text = "Đã xảy ra lỗi: " + ex.Message;
            }
        }

        private void CalculateParallelogramArea()
        {
            try
            {
                // Lấy giá trị từ các TextBox và chuyển đổi sang số
                double a = Convert.ToDouble(textBoxA5.Text);
                double h = Convert.ToDouble(textBoxH5.Text);

                // Kiểm tra xem các giá trị có hợp lệ không
                if (a > 0 && h > 0)
                {
                    double area = a * h;
                    // Hiển thị kết quả ra Label
                    labelResult5.Text = "Diện tích hình bình hành là: " + area.ToString();
                }
                else
                {
                    labelResult5.Text = "Cạnh và đường cao phải lớn hơn 0.";
                }
            }
            catch (FormatException)
            {
                // Xử lý lỗi nếu đầu vào không phải là số
                labelResult5.Text = "Vui lòng nhập vào các số hợp lệ.";
            }
        }

        private void CalculateCircleArea()
        {
            try
            {
                // Lấy giá trị từ TextBox và chuyển đổi sang số
                double radius = Convert.ToDouble(textBoxR.Text);

                // Kiểm tra xem giá trị có hợp lệ không
                if (radius > 0)
                {
                    // Tính diện tích hình tròn
                    double area = Math.PI * radius * radius;
                    // Hiển thị kết quả ra Label
                    labelResult6.Text = "Diện tích hình tròn là: " + area.ToString("F2");
                }
                else
                {
                    labelResult6.Text = "Bán kính phải lớn hơn 0.";
                }
            }
            catch (FormatException)
            {
                // Xử lý lỗi nếu đầu vào không phải là số
                labelResult6.Text = "Vui lòng nhập vào một số hợp lệ.";
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác nếu có
                labelResult6.Text = "Đã xảy ra lỗi: " + ex.Message;
            }
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            CalculateTriangleArea();
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonCal1_Click(object sender, EventArgs e)
        {
            CalculateRectangleArea();
        }

        private void buttonCal2_Click(object sender, EventArgs e)
        {
            CalculateSquareArea();
        }

        private void buttonCal4_Click(object sender, EventArgs e)
        {
            CalculateTrapezoidArea();
        }

        private void buttonCal5_Click(object sender, EventArgs e)
        {
            CalculateParallelogramArea();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void labelResult2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxA2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void labelResult3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxA3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void labelResult4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxB4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxA4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxC4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxD4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void labelResult5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxB5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxA5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void buttonCal6_Click(object sender, EventArgs e)
        {
            CalculateCircleArea();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CalculateTriangleArea2();
        }
    }
}


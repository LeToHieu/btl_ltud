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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CalculateTrianglePerimeter()
        {
            try
            {
                // Lấy giá trị từ các TextBox và chuyển đổi sang số
                double sideA = Convert.ToDouble(textBoxA.Text);
                double sideB = Convert.ToDouble(textBoxB.Text);
                double sideC = Convert.ToDouble(textBoxC.Text);

                // Kiểm tra xem các cạnh có tạo thành tam giác hợp lệ không
                if (IsValidTriangle(sideA, sideB, sideC))
                {
                    // Tính chu vi tam giác
                    double perimeter = sideA + sideB + sideC;
                    // Hiển thị kết quả ra Label
                    labelResult.Text = "Chu vi tam giác là: " + perimeter.ToString();
                }
                else
                {
                    labelResult.Text = "Các cạnh này không tạo thành một tam giác hợp lệ.";
                }
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

        private bool IsValidTriangle(double a, double b, double c)
        {
            // Điều kiện để tạo thành một tam giác hợp lệ
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        private void CalculateRectanglePerimeter()
        {
            try
            {
                // Lấy giá trị từ các TextBox và chuyển đổi sang số
                double length = Convert.ToDouble(textBoxA2.Text);
                double width = Convert.ToDouble(textBoxB2.Text);

                // Kiểm tra xem các giá trị có hợp lệ không
                if (length > 0 && width > 0)
                {
                    // Tính chu vi hình chữ nhật
                    double perimeter = 2 * (length + width);
                    // Hiển thị kết quả ra Label
                    labelResult2.Text = "Chu vi hình chữ nhật là: " + perimeter.ToString();
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

        private void CalculateSquarePerimeter()
        {
            try
            {
                // Lấy giá trị từ các TextBox và chuyển đổi sang số
                double a = Convert.ToDouble(textBoxA3.Text);

                // Kiểm tra xem các giá trị có hợp lệ không
                if (a > 0 )
                {
                    // Tính chu vi hình vuông
                    double perimeter = 4 * a;
                    // Hiển thị kết quả ra Label
                    labelResult3.Text = "Chu vi hình vuông là: " + perimeter.ToString();
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

        private void CalculateTrapezoidPerimeter()
        {
            try
            {
                // Lấy giá trị từ các TextBox và chuyển đổi sang số
                double sideA = Convert.ToDouble(textBoxA4.Text);
                double sideB = Convert.ToDouble(textBoxB4.Text);
                double sideC = Convert.ToDouble(textBoxC4.Text);
                double sideD = Convert.ToDouble(textBoxD4.Text);

                // Kiểm tra xem các giá trị có hợp lệ không
                if (sideA > 0 && sideB > 0 && sideC > 0 && sideD > 0)
                {
                    // Tính chu vi hình thang
                    double perimeter = sideA + sideB + sideC + sideD;
                    // Hiển thị kết quả ra Label
                    labelResult4.Text = "Chu vi hình thang là: " + perimeter.ToString();
                }
                else
                {
                    labelResult4.Text = "Các cạnh phải lớn hơn 0.";
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

        private void CalculateParallelogramPerimeter()
        {
            try
            {
                // Lấy giá trị từ các TextBox và chuyển đổi sang số
                double a = Convert.ToDouble(textBoxA5.Text);
                double b = Convert.ToDouble(textBoxB5.Text);

                // Kiểm tra xem các giá trị có hợp lệ không
                if (a > 0 && b > 0)
                {
                    double perimeter = 2 * (a + b);
                    // Hiển thị kết quả ra Label
                    labelResult5.Text = "Chu vi hình bình hành là: " + perimeter.ToString();
                }
                else
                {
                    labelResult5.Text = "Chiều dài các cạnh phải lớn hơn 0.";
                }
            }
            catch (FormatException)
            {
                // Xử lý lỗi nếu đầu vào không phải là số
                labelResult5.Text = "Vui lòng nhập vào các số hợp lệ.";
            }
        }

        private void CalculateCirclePerimeter()
        {
            try
            {
                // Lấy giá trị từ TextBox và chuyển đổi sang số
                double radius = Convert.ToDouble(textBoxR.Text);

                // Kiểm tra xem giá trị có hợp lệ không
                if (radius > 0)
                {
                    // Tính chu vi hình tròn
                    double perimeter = 2 * Math.PI * radius;
                    // Hiển thị kết quả ra Label
                    labelResult6.Text = "Chu vi hình tròn là: " + perimeter.ToString("F2");
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
            CalculateTrianglePerimeter();
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonCal1_Click(object sender, EventArgs e)
        {
            CalculateRectanglePerimeter();
        }

        private void buttonCal2_Click(object sender, EventArgs e)
        {
            CalculateSquarePerimeter();
        }

        private void buttonCal4_Click(object sender, EventArgs e)
        {
            CalculateTrapezoidPerimeter();
        }

        private void buttonCal5_Click(object sender, EventArgs e)
        {
            CalculateParallelogramPerimeter();
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
            CalculateCirclePerimeter();
        }
    }
}


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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            select_combo_box.SelectedIndex = 0;
        }

        private void selectValueChange(object sender, EventArgs e)
        {   
            if(select_combo_box.SelectedIndex == 0)
            {
                label2.Text = "Số cuối";
            }
            else
            {
                label2.Text = "Số thứ";
            }
        }

        private void caculate_Click(object sender, EventArgs e)
        {
            try
            {
                output_help_label.Text = "";
                output_label.Text = "";
                int index = select_combo_box.SelectedIndex;
                int fisrtNum = int.Parse( textBoxFirstNum.Text);
                int option = int.Parse(textBoxOption.Text);
                int space = int.Parse(textBoxSpace.Text);
                int output = 0;
                int checkArrLegit =0;
            
                switch (index)
                {
                    case 0:
                       

                        if ((option - fisrtNum)% space != 0)
                        {
                            MessageBox.Show("Dãy không hợp lệ");
                            return;
                        }
                        output = ((option - fisrtNum) / space) + 1;
                        output_label.Text = "Số số hạng là: " +  output.ToString();
                        break;
                    case 1:
                        output = ((option - 1)* space + fisrtNum);
                        output_label.Text = "Số thứ " + option + " là: " + output.ToString();
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đầu vào không hợp lệ");
            }
                
        }

        private void hiddenExample(object sender, EventArgs e)
        {
            
            TextBox lmao = sender as TextBox;
            if (lmao.Text.Trim() == "Nhập giá trị...")
            {
                lmao.Text = "";
            }
        }

        private void showExample(object sender, EventArgs e)
        {

            TextBox lmao = sender as TextBox;
            if(lmao.Text.Trim() == "")
            {
                lmao.Text = "Nhập giá trị...";
            }
        }
        private void focusToDummy(object sender, EventArgs e)
        {
            dummy.Focus();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBoxFirstNum.Text = "Nhập giá trị...";
            textBoxOption.Text = "Nhập giá trị...";
            textBoxSpace.Text = "Nhập giá trị...";
        }
    }
}

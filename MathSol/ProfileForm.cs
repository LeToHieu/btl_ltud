using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml.InkML;
using System.Security.Cryptography;
using System.Drawing.Text;
using System.Threading;

namespace MathSol
{
    public partial class ProfileForm : Form
    {
        mainForm2 frm;
        public ProfileForm(string name, string username, string image, mainForm2 frm)
        {
            this.UserName = username;
            this.FullName = name;
            this.UserImage = image;
            InitializeComponent();
            if (image!="default.jpg")
            {
                circularPictureBoxAva.ImageLocation = "Resources/" + image;
            }
            labelName.Text = name;
            this.frm = frm;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void LoginToUse_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            try
            {
                

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.imageLocation = openFileDialog.FileName;

                    /*circularPictureBoxAva.ImageLocation = this.imageLocation;*/
                    this.circularPictureBoxAva.ImageLocation = imageLocation;
                }

                string newImage = "";
                if (this.imageLocation != "")
                {
                    try
                    {
                        // Load the image from the specified path
                        using (Bitmap image = new Bitmap(imageLocation))
                        {
                            // Save the image to a new location (e.g., "C:\MySavedImage.png")

                            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(imageLocation);
                            /*image.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);*/
                            double currentTime = Environment.TickCount;
                            newImage = $"{fileNameWithoutExtension}_{currentTime}.png";

                            image.Save("Resources/" + newImage);
                            
                            frm.updateUser(newImage);



                            //delete old image
                            if (UserImage != "default.jpg")
                            {
                                File.Delete("Resources/" + UserImage);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        PasswordCheck.Visible = false;
                        Check.Visible = false;
                        MessageBox.Show($"Lỗi khi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        PasswordError.Visible = true;
                        Error.Visible = true;
                        return;
                    }
                }
                else
                {
                    newImage = this.UserImage;
                }

                if (!users.updateImage(this.UserName, newImage))
                {
                    PasswordCheck.Visible = false;
                    Check.Visible = false;
                    PasswordError.Text = "Có lỗi gì đó trong quá trình cập nhật đã xẩy ra";
                    PasswordError.Visible = true;
                    Error.Visible = true;
                    return;
                }


                this.UserImage = newImage;
                this.imageLocation = "";


            }
            catch (Exception){
                MessageBox.Show("Không thể mở ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            string oldPass = textBoxOldPass.Text;
            string newPass = textBoxNewPass.Text;
            string newPassCf = textBoxNewPassConf.Text;

            PasswordCheck.Visible = false;
            Check.Visible = false;
            PasswordError.Visible = false;
            Error.Visible = false;


            if (oldPass == null || newPass == null || newPassCf == null ) { return; }

            if (oldPass == "" || newPass == "" || newPassCf == "" ) { return; }

            if (newPass != newPassCf)
            {
                PasswordCheck.Visible = false;
                Check.Visible = false;
                PasswordError.Text = "Mật khẩu mới không trùng khớp";
                PasswordError.Visible = true;
                Error.Visible = true;
                return;
            }

            if (!users.login(this.UserName, oldPass))
            {
                PasswordCheck.Visible = false;
                Check.Visible = false;
                PasswordError.Text = "Mật khẩu cũ không đúng";
                PasswordError.Visible = true;
                Error.Visible = true;
                return;
            }
            

            if (!users.updateUser(this.UserName, newPass))
            {
                PasswordCheck.Visible = false;
                Check.Visible = false;
                PasswordError.Text = "Có lỗi gì đó trong quá trình cập nhật đã xẩy ra";
                PasswordError.Visible = true;
                Error.Visible = true;
                return;
            }

            PasswordError.Visible = false;
            Error.Visible = false;
            PasswordCheck.Text = "Cập nhật thành công";
            PasswordCheck.ForeColor = Color.Green;
            PasswordCheck.Visible = true;
            int width = 16;
            int height = 16;
            Bitmap checkmarkImage = new Bitmap(width, height);
            Graphics.FromImage(checkmarkImage).Clear(Color.Transparent); // Set transparent background (optional)
            Graphics.FromImage(checkmarkImage).TextRenderingHint = TextRenderingHint.AntiAlias; // Improve text quality (optional)
            Graphics.FromImage(checkmarkImage).DrawString("\u2713", new Font("Arial", 10), Brushes.Green, 0, 0); // Adjust font size and position as needed
            Check.Image = checkmarkImage;
            Check.Visible = true;


            textBoxOldPass.Text = "";
            textBoxNewPass.Text = "";
            textBoxNewPassConf.Text = "";
        }
    }
}


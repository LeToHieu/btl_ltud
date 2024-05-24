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
    public partial class ProfileForm : Form
    {
        public ProfileForm(string name, string username, string image)
        {
            this.UserName = username;
            this.FullName = name;
            this.UserImage = image;
            InitializeComponent();
            circularPictureBoxAva.Image = Image.FromFile("Resources/" + image);
            labelName.Text = name;
        }

        private void LoginToUse_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }
    }
}

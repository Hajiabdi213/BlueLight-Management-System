using BlueLight_Management_System.Models;
using BlueLight_Management_System.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Custom_Controls
{
    public partial class UserProfileControl : UserControl
    {

        public UserProfileControl()
        {
            InitializeComponent();
        }

        private Image ConvertBytetoImage(byte[] photo)
        {
            // this method is used when you want to get binary photo from database 
            Image newImage;
            using (MemoryStream ms = new MemoryStream(photo, 0, photo.Length))
            {
                ms.Write(photo, 0, photo.Length);
                newImage = Image.FromStream(ms, true);
            }
            return newImage;
        }
       

        private void labelUserFullName_Click(object sender, EventArgs e)
        {

        }

        private void labelUserRole_Click(object sender, EventArgs e)
        {

        }

        private void roundedPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelUserFullName_Click_1(object sender, EventArgs e)
        {

        }

        private void roundedPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserProfileControl_Load(object sender, EventArgs e)
        {
           if(Login.userInfo!=null)
            {
        labelUserFullName.Text = Login.userInfo.FullName;
                   labelUserRole.Text = Login.userInfo.Role;
                    if (Login.userInfo.Picture.Length > 0)
                    {
                        roundedPictureBox1.Image = ConvertBytetoImage(Login.userInfo.Picture);

                    }
            }
           
        }
    }
}

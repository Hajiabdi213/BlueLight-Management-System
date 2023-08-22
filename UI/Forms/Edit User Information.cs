using BlueLight_Management_System.Data;
using BlueLight_Management_System.Models;
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

namespace BlueLight_Management_System.UI.Forms
{
    public partial class Edit_User_Information : Form
    {
        public Edit_User_Information(UsersManagement usersManagement)
        {
            InitializeComponent();
        }

        //methods for Image Processing
        private byte[] ConvertFiletoByte(string sPath)
        {
            // use this method when saving image and converting it into byte
            byte[] data = null;
            FileInfo fileInfo = new FileInfo(sPath);
            long numBytes = fileInfo.Length;
            FileStream fileStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fileStream);
            data = br.ReadBytes((int)numBytes);
            return data;
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
        public User UserInfo { get; set; }
        //--
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        // show existing user data for the user to be edited
        public void DisplayUserData()
        {
            textBoxFirstName.Text = UserInfo.FirstName;
            textBoxLastName.Text = UserInfo.LastName;
            textBoxPassword.Text = UserInfo.Password;
            textBoxPhone.Text = UserInfo.Phone;
            textBoxUsername.Text = UserInfo.Username;
            comboBoxUserRole.Text = UserInfo.Role;
            comboBoxUserStatus.Text = UserInfo.IsActive ? "Active" : "In Active";
            pictureBoxUserProfile.Image = ConvertBytetoImage(UserInfo.Picture);
        }

        public void UpdateUser()
        {
            DataContext context = new DataContext();
            var targetUser = context.Users.SingleOrDefault(u => u.User_Id == UserInfo.User_Id);
            if (targetUser != null)

            {
                targetUser.FirstName = textBoxFirstName.Text;
                targetUser.LastName = textBoxLastName.Text;
                targetUser.FullName = "";
                targetUser.Phone = textBoxPhone.Text;
                targetUser.Username = textBoxUsername.Text;
                targetUser.Password = textBoxPassword.Text;
                targetUser.Role = comboBoxUserRole.Text;
                targetUser.UpdatedAt = DateTime.Now;
                targetUser.IsActive = comboBoxUserStatus.Text == "Active" ? true : false;
                if (pictureBoxUserProfile.ImageLocation != null)
                {
                    targetUser.Picture = ConvertFiletoByte(pictureBoxUserProfile.ImageLocation);

                }

            }
            else
            {
                return;
            }
            ;


            if (MessageBox.Show("Are You Sure To Update?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // context.Users.Update(targetUser);
                context.SaveChanges();
                insert();



                this.Close();


            }
            else
            {

                return;
            }
            ;
        }
        
       

        
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = textBoxLastName.Text = textBoxUsername.Text = textBoxPassword.Text = textBoxPhone.Text = comboBoxUserRole.Text = "";
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void Edit_User_Information_Load(object sender, EventArgs e)
        {
            DisplayUserData();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please Select a Photo";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBoxUserProfile.ImageLocation = ofd.FileName;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the event to prevent non-numeric input
                e.Handled = true;
            }
        }
    }
}

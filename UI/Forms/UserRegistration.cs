//using Microsoft.IdentityModel.Tokens;
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
    public partial class UserRegistration : Form
    {
        public UserRegistration(UsersManagement usersManagement)
        {
            InitializeComponent();
        }

        // --
        public delegate void AddNewDelegate(object sender, AddNewEventArgs args);
        public event AddNewDelegate AddNewEventHandler;
        public class AddNewEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        protected void insert()
        {
            AddNewEventArgs args = new AddNewEventArgs();
            AddNewEventHandler.Invoke(this, args);
        }
        //--

        // check empty texboxes

        // check empty texboxes
        private bool CheckEmptyTextBoxes()
        {
            var isEmptyFieldExist = false;
            List<bool> emptyCheckLists = new List<bool>();
            if (string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                errorProvider1.SetError(textBoxFirstName, "Enter The First Name");
                emptyCheckLists.Add(true);

            }
            else
            {
                errorProvider1.SetError(textBoxFirstName, string.Empty);
                emptyCheckLists.Add(false);
            }
            //02. check lastname
            if (string.IsNullOrEmpty(textBoxLastName.Text))
            {
                errorProvider1.SetError(textBoxLastName, "Enter the Last Name");
                emptyCheckLists.Add(true);
            }
            else
            {
                errorProvider1.SetError(textBoxLastName, string.Empty);
                emptyCheckLists.Add(false);

            }

            //03. Check phone
            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                errorProvider1.SetError(textBoxPhone, "Enter the Phone");
                emptyCheckLists.Add(true);
            }
            else
            {
                errorProvider1.SetError(textBoxPhone, string.Empty);
                emptyCheckLists.Add(false);


            }

            //04. Check username
            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                errorProvider1.SetError(textBoxUsername, "Enter the Username");
                emptyCheckLists.Add(true);
            }
            else
            {
                errorProvider1.SetError(textBoxUsername, string.Empty);
                emptyCheckLists.Add(false);

            }

            // 05. Check password
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                errorProvider1.SetError(textBoxPassword, "Enter the Password");
                emptyCheckLists.Add(true);
            }
            else
            {
                errorProvider1.SetError(textBoxPassword, string.Empty);
                emptyCheckLists.Add(false);

            }

            //06. Check role
            if (string.IsNullOrEmpty(comboBoxUserRole.Text))
            {
                errorProvider1.SetError(comboBoxUserRole, "Choose the Role");
                emptyCheckLists.Add(true);
            }
            else
            {
                errorProvider1.SetError(comboBoxUserRole, string.Empty);
                emptyCheckLists.Add(false);

            }

            //07. Check the Photo
            if (pictureBoxUserProfile.Image is null)
            {
                errorProvider1.SetError(pictureBoxUserProfile, "Please upload the user photo");
                emptyCheckLists.Add(true);
            }
            else
            {
                errorProvider1.SetError(pictureBoxUserProfile, string.Empty);
                emptyCheckLists.Add(false);

            }
            foreach (var item in emptyCheckLists)
            {
                if (item is true)
                {
                    isEmptyFieldExist = true;
                    break;
                }
                else
                {
                    isEmptyFieldExist = false;
                }
            }
            return isEmptyFieldExist;

        }
        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }


        private byte[] ConvertFiletoByte(string sPath)
        {
            // use this method when saving image and converting it into byte
            byte[] data = new byte[0];
            FileInfo fileInfo = new FileInfo(sPath);
            long numBytes = fileInfo.Length;
            FileStream fileStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fileStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_KeyUp(object sender, KeyEventArgs e)
        {
            CheckEmptyTextBoxes();
        }

        private void textBoxLastName_KeyUp(object sender, KeyEventArgs e)
        {
            CheckEmptyTextBoxes();

        }

        private void textBoxPhone_KeyUp(object sender, KeyEventArgs e)
        {
            CheckEmptyTextBoxes();

        }

        private void textBoxUsername_KeyUp(object sender, KeyEventArgs e)
        {
            CheckEmptyTextBoxes();

        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            CheckEmptyTextBoxes();

        }

        private void comboBoxUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckEmptyTextBoxes();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = textBoxLastName.Text = textBoxUsername.Text = textBoxPassword.Text = textBoxPhone.Text = comboBoxUserRole.Text = "";
        }

        private void UserRegistration_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
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

        private void buttonSave_Click_1(object sender, EventArgs e)
        {

            CheckEmptyTextBoxes();
            if (CheckEmptyTextBoxes())
            {
                return;
            }



            DataContext context = new DataContext();
            User user = new User()
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Phone = textBoxPhone.Text,
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text,
                Role = comboBoxUserRole.Text,
                FullName = $"{textBoxFirstName.Text} {textBoxLastName.Text}",
                IsActive = true,
                Picture = ConvertFiletoByte(pictureBoxUserProfile.ImageLocation),
                RegisteredAt = DateTime.Now,
                UpdatedAt = DateTime.Now

            };

            if (MessageBox.Show("Are You Sure To Save?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                context.Users.Add(user);
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

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textBoxFirstName.Text = textBoxLastName.Text = textBoxUsername.Text = textBoxPassword.Text = textBoxPhone.Text = comboBoxUserRole.Text = "";
        }
    }
}

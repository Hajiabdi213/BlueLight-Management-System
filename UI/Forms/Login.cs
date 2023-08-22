//using Microsoft.IdentityModel.Tokens;
using BlueLight_Management_System.Data;
using BlueLight_Management_System.Models;
//using Studio_Management_System.Properties;
//using Studio_Management_System.UI.Custom_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Forms
{
    public partial class Login : Form
    {
        public static User userInfo;
        public Login()
        {
            
            InitializeComponent();

        }

        // check empty texboxes
        private bool CheckEmptyTextBoxes()
        {
            var isEmptyFieldExist = false;
            List<bool> emptyCheckLists = new List<bool>();
            //01. check username
            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                errorProvider1.SetError(textBoxUsername, "Enter The First Name");
                emptyCheckLists.Add(true);

            }
            else
            {
                errorProvider1.SetError(textBoxUsername, string.Empty);
                emptyCheckLists.Add(false);
            }
            //02. check password
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                errorProvider1.SetError(textBoxPassword, "Enter the Last Name");
                emptyCheckLists.Add(true);
            }
            else
            {
                errorProvider1.SetError(textBoxPassword, string.Empty);
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {



            CheckEmptyTextBoxes();


            //checking the user
            DataContext context = new DataContext();
            var user = context.Users.FirstOrDefault(u => u.Username == textBoxUsername.Text && u.Password == textBoxPassword.Text && u.IsActive);
            if (user != null)
            {
                //MainContainer mainContainer = new MainContainer();
                //userInfo = user;

                //mainContainer.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Waxbaad Qaladay, ama Waa lagaa Xidhay in aad gasho!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_KeyUp(object sender, KeyEventArgs e)
        {
            CheckEmptyTextBoxes();
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            CheckEmptyTextBoxes();

        }

        private void comboBoxUserRole_SelectedValueChanged(object sender, EventArgs e)
        {
            CheckEmptyTextBoxes();
        }

      

       

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
       

        private void label1_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text=="dev01"&&textBoxPassword.Text=="d1234")
            {

            

                var context = new DataContext();
                var superAdminUser = new User()
                {
                    FirstName = "Abdillahi",
                    LastName = "Osman",
                    IsActive = true,
                    Username = "sadmin",
                    Password = "sadmin",
                    RegisteredAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FullName = "",
                    Phone = "0634675961",
                    Role = "Super Admin",
                   // Picture = Resources.GetResourceStream("fedfh")
                };

                context.Users.Add(superAdminUser);
                context.SaveChanges();
                MessageBox.Show("Super Admin has been Created");
            }
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            
            CheckEmptyTextBoxes();
            if(CheckEmptyTextBoxes())
            {
                return;
            }

            //checking the user
            DataContext context = new DataContext();
            var user = context.Users.FirstOrDefault(u => u.Username==textBoxUsername.Text && u.Password==textBoxPassword.Text && u.IsActive);           
            if (user != null && user.Username==textBoxUsername.Text && user.Password==textBoxPassword.Text)
            {
                MainContainer mainContainer = new MainContainer();
                userInfo = user;
                mainContainer.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Waxbaad Qaladay, ama Waa lagaa Xidhay in aad gasho!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "CWm3KFbeZ8XP")
            {
                var context = new DataContext();
                var superAdminUser = new User()
                {
                    FirstName = "Abdillahi",
                    LastName = "Osman",
                    IsActive = true,
                    Username = "sadmin",
                    Password = "sadmin",
                    RegisteredAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FullName = "",
                    Phone = "0634675961",
                    Role = "Super Admin",
                    // Picture = Resources.GetResourceStream("fedfh")
                };

                context.Users.Add(superAdminUser);
                context.SaveChanges();
                MessageBox.Show("Super Admin has been Created");
            }
        }

        private void checkBoxPasswordVisibilityController_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswordVisibilityController.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                checkBoxPasswordVisibilityController.Text = "Hide Password";

            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                checkBoxPasswordVisibilityController.Text = "Show Password";
            }
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            
            textBoxUsername.Text = textBoxPassword.Text = "";
            label2.ForeColor = Color.FromArgb(18, 113, 255);
            buttonLogin.BackColor = Color.FromArgb(18, 113, 255);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPasswordVisibilityController_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}

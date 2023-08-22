using BlueLight_Management_System.Data;
using BlueLight_Management_System.Models;
//using Studio_Management_System.Properties;
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
    public partial class UsersManagement : Form
    {
        public UsersManagement()
        {
            InitializeComponent();
        }

        //--

        public void refreshDataEnventHandler1(object sender, UserRegistration.AddNewEventArgs args)
        {
            ShowAllUsers();
        }

        public void refreshDataEnventHandler2(object sender, Edit_User_Information.UpdateEventArgs args)
        {
            ShowAllUsers();

        }
        //--


        //show users
        public void ShowAllUsers()
        {
            var context = new DataContext();
           // materialDataTableUsers.ShowVerticalScroll = false;
            var allUsers = (from user in context.Users where(user.Role!="Super Admin") // show all users info except super admins
                            select (new
                            {
                                UserId = user.User_Id,                             
                                Picture = user.Picture,
                                FullName = user.FullName,
                                Phone = user.Phone,
                                Username = user.Username,
                                Role = user.Role,
                                Status = user.IsActive ? "Active" : "In Active",
                                registeredAt = user.RegisteredAt,
                                updatedAt = user.UpdatedAt



                            })).OrderByDescending(u => u.UserId).ToList();
            materialDataTableUsers.DataSource = allUsers;
        }

        // search specific user
        public void SearchUsers()
        {
            var context = new DataContext();
            var filteredUsers = new List<User>();
            foreach (var user in context.Users.ToList())
            {
                if (user.FullName.ToLower().Contains(textBoxSearch.Text.ToLower().Trim()) || user.Phone.ToLower().Contains(textBoxSearch.Text.ToLower().Trim()) || user.Username.ToLower().Contains(textBoxSearch.Text.ToLower().Trim()) )
                {
                    if(!user.Role.Contains("Super"))
                    {

                    filteredUsers.Add(user);
                    }
                }
            }
            var allUsers = (from user in filteredUsers
                            select (new
                            {
                                UserId = user.User_Id,
                                Picture = user.Picture,
                                FullName = user.FullName,
                                Phone = user.Phone,
                                Username = user.Username,
                                Role = user.Role,
                                Status = user.IsActive ? "Active" : "In Active",
                                Registered  = user.RegisteredAt,
                                UpdatedAt = user.UpdatedAt



                            })).OrderByDescending(u => u.UserId).ToList();
            materialDataTableUsers.DataSource = allUsers;

        }



        private void UsersManagement_Load(object sender, EventArgs e)
        {
            ShowAllUsers();
            materialDataTableUsers.DefaultCellStyle.SelectionForeColor = Color.Black;
            materialDataTableUsers.DefaultCellStyle.BackColor = Color.White;
        }

        private void buttonUserRegistration_Click_1(object sender, EventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration(this);
            userRegistration.AddNewEventHandler += refreshDataEnventHandler1;
            userRegistration.ShowDialog();
        }

        private void materialDataTableAllUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

      

       

        private void UsersManagement_Load_1(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();

            ShowAllUsers();

            materialDataTableUsers.RowsDefaultCellStyle.BackColor = Color.White;
            materialDataTableUsers.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUserRegistration_Click(object sender, EventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration(this);
            userRegistration.AddNewEventHandler += refreshDataEnventHandler1;
            userRegistration.ShowDialog();
        }

        private void materialDataTableUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var userId = Convert.ToInt32(materialDataTableUsers.CurrentRow.Cells["UserId"].Value);
            //delete user
            if (materialDataTableUsers.Columns[e.ColumnIndex].Name == "buttonDelete")
            {
                if (MessageBox.Show("Are you sure to Delete", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   
                    var context = new DataContext();
                    var targetUser = context.Users.SingleOrDefault(u => u.User_Id == userId);
                    if (targetUser != null)
                    {
                        context.Users.Remove(targetUser);
                        context.SaveChanges();

                        ShowAllUsers();

                    }
                    return;
                };

            }



            // update 
            if (materialDataTableUsers.Columns[e.ColumnIndex].Name == "buttonEdit")
            {

                var context = new DataContext();
                var targetUser = context.Users.SingleOrDefault(u => u.User_Id ==userId);
                if (targetUser != null)
                {
                    Edit_User_Information editUserInfo = new Edit_User_Information(this);

                    editUserInfo.UserInfo = targetUser;
                    editUserInfo.UpdateEventHandler += refreshDataEnventHandler2;
                    editUserInfo.ShowDialog();


                }
                return;


            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchUsers();
        }
    }
}

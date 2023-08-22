using BlueLight_Management_System.Data;
using BlueLight_Management_System.Models;
using BlueLight_Management_System.UI.Forms;
//using Studio_Management_System.UI.Custom_Controls;
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
    public partial class MainContainer : Form
    {
        public MainContainer()
        {
            InitializeComponent();

        }

        // code to show other form in the panel
        public void ShowOtherForm(object form)
        {
            panelMainContainer.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelMainContainer.Controls.Add(frm);
            panelMainContainer.Tag = frm;


            frm.Show();

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
      


        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
        private void buttonInvoice_Click_1(object sender, EventArgs e)
        {
         ShowOtherForm(new Invoices());
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ShowOtherForm(new Dashboard());
        }

       

        

       
        private void userProfileControl1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUsers_Click_1(object sender, EventArgs e)
        {
            ShowOtherForm(new UsersManagement());
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            ShowOtherForm(new Invoices());
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            ShowOtherForm(new Customers());
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            ShowOtherForm(new Services());
        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            ShowOtherForm(new Payments_Form());
        }

        

        private void MainContainer_Load(object sender, EventArgs e)
        {




            // removing settings except the super admin
            if (Login.userInfo.Role != "Super Admin")
            {
                Controls.Remove(buttonSettings);

                buttonSettings.Dispose();
                Refresh();
            }
            //removing admin controls when a user is logged in
            if (Login.userInfo.Role is "User")
            {
                Controls.Remove(buttonServices);
                Controls.Remove(buttonUsers);
                Controls.Remove(buttonBackup);
                Controls.Remove(buttonSettings);

                buttonBackup.Dispose();
                buttonSettings.Dispose();
                buttonServices.Dispose();
                buttonUsers.Dispose();
                Refresh();
            }

            ShowOtherForm(new Dashboard());
            var context = new DataContext();
            if (context.CompanySettings.ToList().Count > 0)
            {
                var logo = context.CompanySettings.First().CompanyLogo;


                pictureBoxLogo.Image = ConvertBytetoImage(logo);
            }
            return;
        }

          

        private void buttonReports_Click(object sender, EventArgs e)
        {
            ShowOtherForm(new Reports());
        }

        private void buttonDashboard_Click_1(object sender, EventArgs e)
        {
            ShowOtherForm(new Dashboard());
        }

        private void MainContainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ShowOtherForm(new Settings());
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            ShowOtherForm(new Backup());
        }
    }
}

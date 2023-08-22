using System.Drawing;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Forms
{
    partial class MainContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainContainer));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonInvoice = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonPayments = new System.Windows.Forms.Button();
            this.buttonReports = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.userProfileControl1 = new BlueLight_Management_System.UI.Custom_Controls.UserProfileControl();
            this.panelSidebar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.panelSidebar.Controls.Add(this.panel3);
            this.panelSidebar.Controls.Add(this.flowLayoutPanel1);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Location = new System.Drawing.Point(1, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(192, 697);
            this.panelSidebar.TabIndex = 0;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.buttonLogout);
            this.panel3.Location = new System.Drawing.Point(5, 647);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 48);
            this.panel3.TabIndex = 2;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, -12);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.buttonLogout.Size = new System.Drawing.Size(182, 54);
            this.buttonLogout.TabIndex = 30;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.buttonDashboard);
            this.flowLayoutPanel1.Controls.Add(this.buttonInvoice);
            this.flowLayoutPanel1.Controls.Add(this.buttonServices);
            this.flowLayoutPanel1.Controls.Add(this.buttonClients);
            this.flowLayoutPanel1.Controls.Add(this.buttonPayments);
            this.flowLayoutPanel1.Controls.Add(this.buttonReports);
            this.flowLayoutPanel1.Controls.Add(this.buttonUsers);
            this.flowLayoutPanel1.Controls.Add(this.buttonBackup);
            this.flowLayoutPanel1.Controls.Add(this.buttonSettings);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 554);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(3, 3);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(183, 54);
            this.buttonDashboard.TabIndex = 19;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click_1);
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.FlatAppearance.BorderSize = 0;
            this.buttonInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInvoice.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonInvoice.ForeColor = System.Drawing.Color.White;
            this.buttonInvoice.Image = ((System.Drawing.Image)(resources.GetObject("buttonInvoice.Image")));
            this.buttonInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInvoice.Location = new System.Drawing.Point(3, 63);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.buttonInvoice.Size = new System.Drawing.Size(183, 54);
            this.buttonInvoice.TabIndex = 20;
            this.buttonInvoice.Text = "Invoices";
            this.buttonInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInvoice.UseVisualStyleBackColor = true;
            this.buttonInvoice.Click += new System.EventHandler(this.buttonInvoice_Click);
            // 
            // buttonServices
            // 
            this.buttonServices.FlatAppearance.BorderSize = 0;
            this.buttonServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServices.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonServices.ForeColor = System.Drawing.Color.White;
            this.buttonServices.Image = ((System.Drawing.Image)(resources.GetObject("buttonServices.Image")));
            this.buttonServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonServices.Location = new System.Drawing.Point(3, 123);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.buttonServices.Size = new System.Drawing.Size(183, 54);
            this.buttonServices.TabIndex = 21;
            this.buttonServices.Text = "Services";
            this.buttonServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonServices.UseVisualStyleBackColor = true;
            this.buttonServices.Click += new System.EventHandler(this.buttonServices_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.FlatAppearance.BorderSize = 0;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonClients.ForeColor = System.Drawing.Color.White;
            this.buttonClients.Image = ((System.Drawing.Image)(resources.GetObject("buttonClients.Image")));
            this.buttonClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClients.Location = new System.Drawing.Point(3, 183);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.buttonClients.Size = new System.Drawing.Size(183, 54);
            this.buttonClients.TabIndex = 22;
            this.buttonClients.Text = "Customers";
            this.buttonClients.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonPayments
            // 
            this.buttonPayments.FlatAppearance.BorderSize = 0;
            this.buttonPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayments.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonPayments.ForeColor = System.Drawing.Color.White;
            this.buttonPayments.Image = ((System.Drawing.Image)(resources.GetObject("buttonPayments.Image")));
            this.buttonPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayments.Location = new System.Drawing.Point(3, 243);
            this.buttonPayments.Name = "buttonPayments";
            this.buttonPayments.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.buttonPayments.Size = new System.Drawing.Size(183, 54);
            this.buttonPayments.TabIndex = 23;
            this.buttonPayments.Text = "Payments";
            this.buttonPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPayments.UseVisualStyleBackColor = true;
            this.buttonPayments.Click += new System.EventHandler(this.buttonPayments_Click);
            // 
            // buttonReports
            // 
            this.buttonReports.FlatAppearance.BorderSize = 0;
            this.buttonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReports.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonReports.ForeColor = System.Drawing.Color.White;
            this.buttonReports.Image = ((System.Drawing.Image)(resources.GetObject("buttonReports.Image")));
            this.buttonReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReports.Location = new System.Drawing.Point(3, 303);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.buttonReports.Size = new System.Drawing.Size(183, 54);
            this.buttonReports.TabIndex = 25;
            this.buttonReports.Text = "Reports";
            this.buttonReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonUsers.ForeColor = System.Drawing.Color.White;
            this.buttonUsers.Image = ((System.Drawing.Image)(resources.GetObject("buttonUsers.Image")));
            this.buttonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsers.Location = new System.Drawing.Point(3, 363);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.buttonUsers.Size = new System.Drawing.Size(183, 54);
            this.buttonUsers.TabIndex = 26;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click_1);
            // 
            // buttonBackup
            // 
            this.buttonBackup.FlatAppearance.BorderSize = 0;
            this.buttonBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackup.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonBackup.ForeColor = System.Drawing.Color.White;
            this.buttonBackup.Image = ((System.Drawing.Image)(resources.GetObject("buttonBackup.Image")));
            this.buttonBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBackup.Location = new System.Drawing.Point(3, 423);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.buttonBackup.Size = new System.Drawing.Size(183, 54);
            this.buttonBackup.TabIndex = 27;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(3, 483);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.buttonSettings.Size = new System.Drawing.Size(183, 54);
            this.buttonSettings.TabIndex = 28;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(187, 84);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::BlueLight_Management_System.Properties.Resources.Copy_of_baked_1_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(187, 84);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panelMainContainer);
            this.panel1.Controls.Add(this.panelTopBar);
            this.panel1.Location = new System.Drawing.Point(193, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 738);
            this.panel1.TabIndex = 1;
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainContainer.Location = new System.Drawing.Point(0, 87);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(905, 585);
            this.panelMainContainer.TabIndex = 1;
            // 
            // panelTopBar
            // 
            this.panelTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopBar.BackColor = System.Drawing.Color.White;
            this.panelTopBar.Controls.Add(this.userProfileControl1);
            this.panelTopBar.Location = new System.Drawing.Point(1, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panelTopBar.Size = new System.Drawing.Size(908, 87);
            this.panelTopBar.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(614, 676);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Developed by: Abdillahi Osman H. Abdi";
            // 
            // userProfileControl1
            // 
            this.userProfileControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userProfileControl1.BackColor = System.Drawing.Color.White;
            this.userProfileControl1.Location = new System.Drawing.Point(640, 0);
            this.userProfileControl1.Name = "userProfileControl1";
            this.userProfileControl1.Size = new System.Drawing.Size(247, 87);
            this.userProfileControl1.TabIndex = 0;
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1099, 699);
            this.Name = "MainContainer";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainContainer_FormClosed);
            this.Load += new System.EventHandler(this.MainContainer_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSidebar;
        private Panel panelLogo;
        private PictureBox pictureBoxLogo;
        private Panel panel1;
        private Panel panelTopBar;
        private Custom_Controls.UserProfileControl userProfileControl1;
        private Panel panelMainContainer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonDashboard;
        private Button buttonInvoice;
        private Button buttonServices;
        private Button buttonClients;
        private Button buttonPayments;
        private Button buttonReports;
        private Button buttonUsers;
        private Button buttonBackup;
        private Panel panel3;
        private Button buttonLogout;
        private Button buttonSettings;
        private Label label8;
    }
}
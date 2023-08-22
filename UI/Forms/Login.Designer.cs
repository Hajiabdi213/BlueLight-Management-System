using System.Drawing;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Forms
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxPasswordVisibilityController = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBanner = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPictureBox1 = new BlueLight_Management_System.UI.Custom_Controls.RoundedPictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panelBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.checkBoxPasswordVisibilityController);
            this.panel2.Controls.Add(this.buttonLogin);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxUsername);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(591, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 573);
            this.panel2.TabIndex = 3;
            // 
            // checkBoxPasswordVisibilityController
            // 
            this.checkBoxPasswordVisibilityController.AutoSize = true;
            this.checkBoxPasswordVisibilityController.Font = new System.Drawing.Font("Lato", 14.25F);
            this.checkBoxPasswordVisibilityController.Location = new System.Drawing.Point(39, 408);
            this.checkBoxPasswordVisibilityController.Name = "checkBoxPasswordVisibilityController";
            this.checkBoxPasswordVisibilityController.Size = new System.Drawing.Size(163, 27);
            this.checkBoxPasswordVisibilityController.TabIndex = 9;
            this.checkBoxPasswordVisibilityController.Text = "Show Password";
            this.checkBoxPasswordVisibilityController.UseVisualStyleBackColor = true;
            this.checkBoxPasswordVisibilityController.CheckedChanged += new System.EventHandler(this.checkBoxPasswordVisibilityController_CheckedChanged);
            this.checkBoxPasswordVisibilityController.CheckStateChanged += new System.EventHandler(this.checkBoxPasswordVisibilityController_CheckStateChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(225)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(41, 462);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(344, 40);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxPassword.Location = new System.Drawing.Point(39, 336);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(321, 36);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 18F);
            this.label7.Location = new System.Drawing.Point(39, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxUsername.Location = new System.Drawing.Point(39, 249);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(321, 36);
            this.textBoxUsername.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 18F);
            this.label6.Location = new System.Drawing.Point(39, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 24F);
            this.label5.Location = new System.Drawing.Point(26, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "Log in to your dashboard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 24F);
            this.label4.Location = new System.Drawing.Point(128, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hi There !";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // panelBanner
            // 
            this.panelBanner.BackgroundImage = global::BlueLight_Management_System.Properties.Resources.cover_2_;
            this.panelBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBanner.Controls.Add(this.roundedPictureBox1);
            this.panelBanner.Controls.Add(this.label3);
            this.panelBanner.Controls.Add(this.label2);
            this.panelBanner.Controls.Add(this.label1);
            this.panelBanner.Location = new System.Drawing.Point(1, -14);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(585, 587);
            this.panelBanner.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato", 69.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(18, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 112);
            this.label3.TabIndex = 2;
            this.label3.Text = "System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lato", 69.75F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(16, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 112);
            this.label2.TabIndex = 1;
            this.label2.Text = "Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato", 69.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "BlueLight";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.Image = global::BlueLight_Management_System.Properties.Resources.Orange_White_Cute_Television_Entertainment_Logo_1_;
            this.roundedPictureBox1.Location = new System.Drawing.Point(373, 367);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(134, 124);
            this.roundedPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundedPictureBox1.TabIndex = 11;
            this.roundedPictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Developed by: Abdillahi Osman Haji";
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1014, 612);
            this.MinimumSize = new System.Drawing.Size(1014, 612);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panelBanner.ResumeLayout(false);
            this.panelBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private Label label7;
        private TextBox textBoxUsername;
        private Label label6;
        private Label label5;
        private Panel panelBanner;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private CheckBox checkBoxPasswordVisibilityController;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Custom_Controls.RoundedPictureBox roundedPictureBox1;
        private Label label8;
    }
}
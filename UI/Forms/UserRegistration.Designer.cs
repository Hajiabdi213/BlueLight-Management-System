using System.Drawing;
using System.Windows.Forms;
using MaterialSkin2Framework;

namespace BlueLight_Management_System.UI.Forms
{
    partial class UserRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin2Framework.Controls.MaterialDivider();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.comboBoxUserRole = new System.Windows.Forms.ComboBox();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(100, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Register New User";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxFirstName.Location = new System.Drawing.Point(139, 71);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(254, 36);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Lato", 18F);
            this.labelFirstName.Location = new System.Drawing.Point(10, 75);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(136, 29);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "First Name:";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(5, 44);
            this.materialDivider1.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(417, 1);
            this.materialDivider1.TabIndex = 8;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxLastName.Location = new System.Drawing.Point(139, 120);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(254, 36);
            this.textBoxLastName.TabIndex = 10;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Lato", 18F);
            this.labelLastName.Location = new System.Drawing.Point(6, 123);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(130, 29);
            this.labelLastName.TabIndex = 9;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxPhone.Location = new System.Drawing.Point(139, 168);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(254, 36);
            this.textBoxPhone.TabIndex = 12;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Lato", 18F);
            this.labelPhone.Location = new System.Drawing.Point(6, 172);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(86, 29);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "Phone:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxUsername.Location = new System.Drawing.Point(139, 217);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(254, 36);
            this.textBoxUsername.TabIndex = 14;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Lato", 18F);
            this.labelUsername.Location = new System.Drawing.Point(6, 220);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(128, 29);
            this.labelUsername.TabIndex = 13;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxPassword.Location = new System.Drawing.Point(139, 265);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(254, 36);
            this.textBoxPassword.TabIndex = 16;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Lato", 18F);
            this.labelPassword.Location = new System.Drawing.Point(9, 269);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(119, 29);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Password:";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Lato", 18F);
            this.labelRole.Location = new System.Drawing.Point(9, 321);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(66, 29);
            this.labelRole.TabIndex = 17;
            this.labelRole.Text = "Role:";
            // 
            // comboBoxUserRole
            // 
            this.comboBoxUserRole.Font = new System.Drawing.Font("Lato", 18F);
            this.comboBoxUserRole.FormattingEnabled = true;
            this.comboBoxUserRole.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.comboBoxUserRole.Location = new System.Drawing.Point(139, 317);
            this.comboBoxUserRole.Name = "comboBoxUserRole";
            this.comboBoxUserRole.Size = new System.Drawing.Size(254, 37);
            this.comboBoxUserRole.TabIndex = 18;
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(261, 372);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(132, 99);
            this.pictureBoxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserProfile.TabIndex = 19;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(139, 372);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(105, 99);
            this.buttonOpenFileDialog.TabIndex = 20;
            this.buttonOpenFileDialog.Text = "Upload";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.buttonOpenFileDialog_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 18F);
            this.label8.Location = new System.Drawing.Point(10, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Picture:";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonClear.Location = new System.Drawing.Point(10, 490);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(175, 37);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonSave.Location = new System.Drawing.Point(218, 490);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(175, 37);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 538);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonOpenFileDialog);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.Controls.Add(this.comboBoxUserRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(429, 577);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(429, 577);
            this.Name = "UserRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Registration";
            this.Load += new System.EventHandler(this.UserRegistration_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private MaterialSkin2Framework.Controls.MaterialDivider materialDivider1;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxPhone;
        private Label labelPhone;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Label labelRole;
        private ComboBox comboBoxUserRole;
        private PictureBox pictureBoxUserProfile;
        private Button buttonOpenFileDialog;
        private Label label8;
        private Button buttonClear;
        private Button buttonSave;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}
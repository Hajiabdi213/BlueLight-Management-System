using System.Drawing;
using System.Windows.Forms;
using MaterialSkin2Framework;

namespace BlueLight_Management_System.UI.Forms
{
    partial class Edit_User_Information
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxUserRole = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.comboBoxUserStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.materialDivider1 = new MaterialSkin2Framework.Controls.MaterialDivider();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxFirstName.Location = new System.Drawing.Point(19, 108);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(293, 36);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 18F);
            this.label7.Location = new System.Drawing.Point(10, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(230, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edit User Information";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxLastName.Location = new System.Drawing.Point(369, 108);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(293, 36);
            this.textBoxLastName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 18F);
            this.label2.Location = new System.Drawing.Point(365, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxPhone.Location = new System.Drawing.Point(19, 194);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(293, 36);
            this.textBoxPhone.TabIndex = 12;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 18F);
            this.label3.Location = new System.Drawing.Point(15, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxUsername.Location = new System.Drawing.Point(369, 194);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(293, 36);
            this.textBoxUsername.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 18F);
            this.label4.Location = new System.Drawing.Point(365, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Username:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Lato", 18F);
            this.textBoxPassword.Location = new System.Drawing.Point(19, 287);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(293, 36);
            this.textBoxPassword.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 18F);
            this.label5.Location = new System.Drawing.Point(15, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 18F);
            this.label6.Location = new System.Drawing.Point(369, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Role:";
            // 
            // comboBoxUserRole
            // 
            this.comboBoxUserRole.Font = new System.Drawing.Font("Lato", 18F);
            this.comboBoxUserRole.FormattingEnabled = true;
            this.comboBoxUserRole.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.comboBoxUserRole.Location = new System.Drawing.Point(369, 287);
            this.comboBoxUserRole.Name = "comboBoxUserRole";
            this.comboBoxUserRole.Size = new System.Drawing.Size(293, 37);
            this.comboBoxUserRole.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 18F);
            this.label8.Location = new System.Drawing.Point(19, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 29);
            this.label8.TabIndex = 24;
            this.label8.Text = "Picture:";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonUpload.Location = new System.Drawing.Point(19, 383);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(120, 120);
            this.buttonUpload.TabIndex = 23;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // comboBoxUserStatus
            // 
            this.comboBoxUserStatus.Font = new System.Drawing.Font("Lato", 18F);
            this.comboBoxUserStatus.FormattingEnabled = true;
            this.comboBoxUserStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.comboBoxUserStatus.Location = new System.Drawing.Point(369, 383);
            this.comboBoxUserStatus.Name = "comboBoxUserStatus";
            this.comboBoxUserStatus.Size = new System.Drawing.Size(293, 37);
            this.comboBoxUserStatus.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 18F);
            this.label9.Location = new System.Drawing.Point(369, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "Status:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Lato", 18F);
            this.buttonUpdate.Location = new System.Drawing.Point(528, 452);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(134, 43);
            this.buttonUpdate.TabIndex = 28;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lato", 18F);
            this.button2.Location = new System.Drawing.Point(369, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 43);
            this.button2.TabIndex = 27;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(1, 49);
            this.materialDivider1.MouseState = MaterialSkin2Framework.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(722, 1);
            this.materialDivider1.TabIndex = 29;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(187, 383);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserProfile.TabIndex = 22;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // Edit_User_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 515);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxUserStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.Controls.Add(this.comboBoxUserRole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(693, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(693, 554);
            this.Name = "Edit_User_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit_User_Information";
            this.Load += new System.EventHandler(this.Edit_User_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFirstName;
        private Label label7;
        private Label label1;
        private TextBox textBoxLastName;
        private Label label2;
        private TextBox textBoxPhone;
        private Label label3;
        private TextBox textBoxUsername;
        private Label label4;
        private TextBox textBoxPassword;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxUserRole;
        private Label label8;
        private Button buttonUpload;
        private PictureBox pictureBoxUserProfile;
        private ComboBox comboBoxUserStatus;
        private Label label9;
        private Button buttonUpdate;
        private Button button2;
        private MaterialSkin2Framework.Controls.MaterialDivider materialDivider1;
        private OpenFileDialog openFileDialog1;
    }
}
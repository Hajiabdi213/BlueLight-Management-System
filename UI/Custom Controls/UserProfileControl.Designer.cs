using System.Drawing;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Custom_Controls
{
    partial class UserProfileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserFullName = new System.Windows.Forms.Label();
            this.labelUserRole = new System.Windows.Forms.Label();
            this.roundedPictureBox1 = new BlueLight_Management_System.UI.Custom_Controls.RoundedPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserFullName
            // 
            this.labelUserFullName.AutoSize = true;
            this.labelUserFullName.Font = new System.Drawing.Font("Lato", 15.75F);
            this.labelUserFullName.Location = new System.Drawing.Point(4, 13);
            this.labelUserFullName.Name = "labelUserFullName";
            this.labelUserFullName.Size = new System.Drawing.Size(100, 25);
            this.labelUserFullName.TabIndex = 1;
            this.labelUserFullName.Text = "Full name";
            this.labelUserFullName.Click += new System.EventHandler(this.labelUserFullName_Click_1);
            // 
            // labelUserRole
            // 
            this.labelUserRole.AutoSize = true;
            this.labelUserRole.Font = new System.Drawing.Font("Lato", 15.75F);
            this.labelUserRole.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUserRole.Location = new System.Drawing.Point(21, 42);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(54, 25);
            this.labelUserRole.TabIndex = 2;
            this.labelUserRole.Text = "Role";
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPictureBox1.Location = new System.Drawing.Point(168, 8);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(74, 71);
            this.roundedPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundedPictureBox1.TabIndex = 0;
            this.roundedPictureBox1.TabStop = false;
            this.roundedPictureBox1.Click += new System.EventHandler(this.roundedPictureBox1_Click_1);
            // 
            // UserProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelUserRole);
            this.Controls.Add(this.labelUserFullName);
            this.Controls.Add(this.roundedPictureBox1);
            this.Name = "UserProfileControl";
            this.Size = new System.Drawing.Size(247, 87);
            this.Load += new System.EventHandler(this.UserProfileControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedPictureBox roundedPictureBox1;
        private Label labelUserFullName;
        private Label labelUserRole;
    }
}

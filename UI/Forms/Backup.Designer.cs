namespace BlueLight_Management_System.UI.Forms
{
    partial class Backup
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBrowseBackupLocation = new System.Windows.Forms.Button();
            this.buttonTakeBackup = new System.Windows.Forms.Button();
            this.textBoxBackupLocation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRestoreDatabase = new System.Windows.Forms.Button();
            this.buttonBrowseRestoreLocation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRestoreLocation = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Backup and Restore";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonBrowseBackupLocation);
            this.groupBox1.Controls.Add(this.buttonTakeBackup);
            this.groupBox1.Controls.Add(this.textBoxBackupLocation);
            this.groupBox1.Font = new System.Drawing.Font("Lato", 18F);
            this.groupBox1.Location = new System.Drawing.Point(18, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location to be backed up:";
            // 
            // buttonBrowseBackupLocation
            // 
            this.buttonBrowseBackupLocation.Location = new System.Drawing.Point(76, 123);
            this.buttonBrowseBackupLocation.Name = "buttonBrowseBackupLocation";
            this.buttonBrowseBackupLocation.Size = new System.Drawing.Size(314, 41);
            this.buttonBrowseBackupLocation.TabIndex = 2;
            this.buttonBrowseBackupLocation.Text = "Browse Location";
            this.buttonBrowseBackupLocation.UseVisualStyleBackColor = true;
            this.buttonBrowseBackupLocation.Click += new System.EventHandler(this.buttonBrowseBackupLocation_Click);
            // 
            // buttonTakeBackup
            // 
            this.buttonTakeBackup.Enabled = false;
            this.buttonTakeBackup.Location = new System.Drawing.Point(465, 126);
            this.buttonTakeBackup.Name = "buttonTakeBackup";
            this.buttonTakeBackup.Size = new System.Drawing.Size(314, 38);
            this.buttonTakeBackup.TabIndex = 1;
            this.buttonTakeBackup.Text = "Take Backup";
            this.buttonTakeBackup.UseVisualStyleBackColor = true;
            this.buttonTakeBackup.Click += new System.EventHandler(this.buttonTakeBackup_Click);
            // 
            // textBoxBackupLocation
            // 
            this.textBoxBackupLocation.Location = new System.Drawing.Point(11, 74);
            this.textBoxBackupLocation.Name = "textBoxBackupLocation";
            this.textBoxBackupLocation.ReadOnly = true;
            this.textBoxBackupLocation.Size = new System.Drawing.Size(808, 36);
            this.textBoxBackupLocation.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonRestoreDatabase);
            this.groupBox2.Controls.Add(this.buttonBrowseRestoreLocation);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxRestoreLocation);
            this.groupBox2.Font = new System.Drawing.Font("Lato", 18F);
            this.groupBox2.Location = new System.Drawing.Point(12, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 205);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore Database";
            // 
            // buttonRestoreDatabase
            // 
            this.buttonRestoreDatabase.Enabled = false;
            this.buttonRestoreDatabase.Location = new System.Drawing.Point(471, 145);
            this.buttonRestoreDatabase.Name = "buttonRestoreDatabase";
            this.buttonRestoreDatabase.Size = new System.Drawing.Size(314, 38);
            this.buttonRestoreDatabase.TabIndex = 5;
            this.buttonRestoreDatabase.Text = "Restore Database";
            this.buttonRestoreDatabase.UseVisualStyleBackColor = true;
            this.buttonRestoreDatabase.Click += new System.EventHandler(this.buttonRestoreDatabase_Click);
            // 
            // buttonBrowseRestoreLocation
            // 
            this.buttonBrowseRestoreLocation.Location = new System.Drawing.Point(82, 144);
            this.buttonBrowseRestoreLocation.Name = "buttonBrowseRestoreLocation";
            this.buttonBrowseRestoreLocation.Size = new System.Drawing.Size(314, 41);
            this.buttonBrowseRestoreLocation.TabIndex = 4;
            this.buttonBrowseRestoreLocation.Text = "Browse Location";
            this.buttonBrowseRestoreLocation.UseVisualStyleBackColor = true;
            this.buttonBrowseRestoreLocation.Click += new System.EventHandler(this.buttonBrowseRestoreLocation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location to be restored:";
            // 
            // textBoxRestoreLocation
            // 
            this.textBoxRestoreLocation.Location = new System.Drawing.Point(11, 92);
            this.textBoxRestoreLocation.Name = "textBoxRestoreLocation";
            this.textBoxRestoreLocation.ReadOnly = true;
            this.textBoxRestoreLocation.Size = new System.Drawing.Size(814, 36);
            this.textBoxRestoreLocation.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Backup";
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowseBackupLocation;
        private System.Windows.Forms.Button buttonTakeBackup;
        private System.Windows.Forms.TextBox textBoxBackupLocation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRestoreDatabase;
        private System.Windows.Forms.Button buttonBrowseRestoreLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRestoreLocation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
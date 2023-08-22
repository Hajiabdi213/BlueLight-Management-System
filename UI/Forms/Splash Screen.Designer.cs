namespace BlueLight_Management_System.UI.Forms
{
    partial class Splash_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash_Screen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelVersion = new System.Windows.Forms.Label();
            this.custom_Progress_Bar1 = new BlueLight_Management_System.UI.Custom_Controls.Custom_Progress_Bar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(574, 381);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 19);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "Version: ";
            // 
            // custom_Progress_Bar1
            // 
            this.custom_Progress_Bar1.BackColor = System.Drawing.Color.White;
            this.custom_Progress_Bar1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.custom_Progress_Bar1.Location = new System.Drawing.Point(-1, 409);
            this.custom_Progress_Bar1.Name = "custom_Progress_Bar1";
            this.custom_Progress_Bar1.Size = new System.Drawing.Size(799, 12);
            this.custom_Progress_Bar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.custom_Progress_Bar1.TabIndex = 1;
            this.custom_Progress_Bar1.Click += new System.EventHandler(this.custom_Progress_Bar1_Click);
            // 
            // Splash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlueLight_Management_System.Properties.Resources.Blue___Yellow_Modern_Business_With_Us_Marketing_Agency_Facebook_Post;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 427);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.custom_Progress_Bar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash_Screen";
            this.Load += new System.EventHandler(this.Splash_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Custom_Controls.Custom_Progress_Bar ProgressBar1;
        private Custom_Controls.Custom_Progress_Bar custom_Progress_Bar1;
        private System.Windows.Forms.Label labelVersion;
    }
}
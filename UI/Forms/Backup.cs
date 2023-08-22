using BlueLight_Management_System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace BlueLight_Management_System.UI.Forms
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        //Backup Method
        public void TakeBackup()
        {
            var dataContext = new DataContext();

            // Get the connection string from your DataContext
            string connectionString = dataContext.Database.Connection.ConnectionString;

            // Create a SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a backup command
                    string databaseName = connection.Database;                   
                    string backupFilePath = textBoxBackupLocation.Text;
                    string backupQuery = $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFilePath}'";

                    using (SqlCommand command = new SqlCommand(backupQuery, connection))
                    {
                        // Execute the backup command
                        command.ExecuteNonQuery();
                    }

                    // Display a success message
                    MessageBox.Show("Backup completed successfully.");
                    textBoxBackupLocation.Clear();
                }
                catch (Exception ex)
                {
                    // Display an error message
                    MessageBox.Show("Backup failed. Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    connection.Close();
                    buttonTakeBackup.Enabled = false;
                }
            }

        }

        //Restore method
        public void RestoreDatabase()
        {
            SqlConnection con = new SqlConnection();
            var dataContext = new DataContext();

            // Get the connection string from your DataContext
            string connectionString = dataContext.Database.Connection.ConnectionString;

            // Set the connection string.
            con.ConnectionString = connectionString;
            //code for the restore button
            con.Open();
            String database = con.Database.ToString();
            try
            {

                string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                cmd1.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBoxRestoreLocation.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, con);
                cmd3.ExecuteNonQuery();
                // s.Speak("Database Restored successfully");
                MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonRestoreDatabase.Enabled = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            textBoxRestoreLocation.Clear();
        }

        private void buttonTakeBackup_Click(object sender, EventArgs e)
        {
            TakeBackup();
        }

        private void buttonBrowseBackupLocation_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Backup Files (*.bak)|*.bak";
            saveFileDialog1.ShowDialog();
            if(saveFileDialog1.FileName.StartsWith("C:"))
            {
               if(MessageBox.Show("Halkan Backup kuma samayn kartid, fadlan dooro drive kale", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)==DialogResult.OK);
                return;
            }
            textBoxBackupLocation.Text = saveFileDialog1.FileName;
            buttonTakeBackup.Enabled = true;
        }

        private void buttonBrowseRestoreLocation_Click(object sender, EventArgs e)
        {
            //code for restore browse button
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxRestoreLocation.Text = ofd.FileName;
                buttonRestoreDatabase.Enabled = true;
              
            }
        }

        private void buttonRestoreDatabase_Click(object sender, EventArgs e)
        {

            RestoreDatabase();
        }

        private void Backup_Load(object sender, EventArgs e)
        {

        }
    }
}

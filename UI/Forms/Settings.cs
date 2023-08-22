using BlueLight_Management_System.Data;
using BlueLight_Management_System.Models;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }



        //methods for Image Processing
        private byte[] ConvertFiletoByte(string sPath)
        {
            // use this method when saving image and converting it into byte
            byte[] data = null;
            FileInfo fileInfo = new FileInfo(sPath);
            long numBytes = fileInfo.Length;
            FileStream fileStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fileStream);
            data = br.ReadBytes((int)numBytes);
            return data;
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

        public void ProcessCompanySettings()
        {
            var context = new DataContext();

            var companySettings = new Company()
            {
                CompanyName = textBoxCompanyName.Text,
                CompanyLogo = ConvertFiletoByte(pictureBoxLogo.ImageLocation)
            };

            if (context.CompanySettings.ToList().Count > 0)
            {
                context.CompanySettings.Remove(context.CompanySettings.First());
                context.CompanySettings.Add(companySettings);
            }
            else
            {
                context.CompanySettings.Add(companySettings);
            }

            context.SaveChangesAsync();

        }   
        private void Settings_Load(object sender, EventArgs e)
        {
            var context = new DataContext();

            if (context.CompanySettings.ToList().Count > 0)
            {
                textBoxCompanyName.Text = context.CompanySettings.First().CompanyName;
                var logo = context.CompanySettings.First().CompanyLogo;
                pictureBoxLogo.Image = ConvertBytetoImage(logo);
            }
            return;


        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonUpload_Click_1(object sender, EventArgs e)
        {
 OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please Select a Photo";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxLogo.ImageLocation = ofd.FileName;
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            ProcessCompanySettings();
        }

        private void Settings_Load_1(object sender, EventArgs e)
        {

        }
    }
}

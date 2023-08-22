using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Custom_Controls
{
    public partial class RoundedPictureBox : PictureBox
    {
        public RoundedPictureBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            this.Region = new Region(graphicsPath);
            base.OnPaint(pe);
        }
    }
}

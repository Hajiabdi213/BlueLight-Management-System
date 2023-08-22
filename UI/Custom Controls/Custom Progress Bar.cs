using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueLight_Management_System.UI.Custom_Controls
{
    internal class Custom_Progress_Bar:ProgressBar
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Get the graphics object for the progress bar.
            Graphics graphics = e.Graphics;

            // Set the color of the progress bar.
            graphics.FillRectangle(new SolidBrush(Color.Red), 0, 0, this.Width, this.Height);
        }
    }
}

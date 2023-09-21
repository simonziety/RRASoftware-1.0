using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace RotaryAxisAnalyzer
{
    internal class PanelDecoration : Panel
    {
        private int cornerRadius = 10; // Adjust this value to change the corner radius

        public PanelDecoration()
        {
            // Set the DoubleBuffered property to reduce flickering
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();

            int width = Width;
            int height = Height;
            int radius = cornerRadius;

            // Create a rounded rectangle path
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(width - 2 * radius, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(width - 2 * radius, height - 2 * radius, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, height - 2 * radius, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();

            // Set the panel's region to the rounded rectangle path
            Region = new Region(path);

            // You can customize the background color here
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }
        }
    }
}

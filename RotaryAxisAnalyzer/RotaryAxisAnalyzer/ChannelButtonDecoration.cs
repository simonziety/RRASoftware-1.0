using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotaryAxisAnalyzer
{
    internal class ChannelButtonDecoration
    {
        public static void ChannelBtnDecoration(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;

            int radius = 10;
            GraphicsPath roundedPath = new GraphicsPath();
            roundedPath.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            roundedPath.AddArc(control.Width - 2 * radius, 0, radius * 2, radius * 2, 270, 90);
            roundedPath.AddArc(control.Width - 2 * radius, control.Height - 2 * radius, radius * 2, radius * 2, 0, 90);
            roundedPath.AddArc(0, control.Height - 2 * radius, radius * 2, radius * 2, 90, 90);
            roundedPath.CloseFigure();
            control.Region = new Region(roundedPath);

            int shadowOffset = 0;
            Rectangle shadowRect = new Rectangle(
                shadowOffset,
                shadowOffset,
                control.Width,
                control.Height
            );

            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(50, Color.Black)))
            {
                e.Graphics.FillRectangle(shadowBrush, shadowRect);
            }

        }
    }
}

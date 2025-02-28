using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PayrollSystem.UserControls
{
    public class TransparentLabel : Label
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Prevent background painting
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Parent != null)
            {
                // Get the parent graphics to paint the background
                using (var bmp = new Bitmap(Parent.Width, Parent.Height))
                {
                    Parent.DrawToBitmap(bmp, Parent.ClientRectangle);
                    e.Graphics.DrawImage(bmp, -Left, -Top);
                }
            }

            // Set anti-aliasing and high-quality rendering for smoother text
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw the label text with the smoothing and high-quality settings
            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }
    }
}

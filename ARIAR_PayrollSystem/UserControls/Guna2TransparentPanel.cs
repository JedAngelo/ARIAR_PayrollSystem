using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.UserControls
{
    public class Guna2TransparentPanel : Guna2Panel
    {
        public Guna2TransparentPanel()
        {
            // Enable double buffering and optimize painting
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);

            // Set the default transparent background
            this.BackColor = System.Drawing.Color.Transparent;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Suppress the background painting to allow transparency
            if (Parent != null)
            {
                // Handle cases where Parent.BackgroundImage is null
                if (Parent.BackgroundImage != null)
                {
                    var bounds = new System.Drawing.Rectangle(this.Left, this.Top, this.Width, this.Height);
                    e.Graphics.DrawImage(Parent.BackgroundImage, bounds, bounds, GraphicsUnit.Pixel);
                }
                else
                {
                    // If no background image, fill with parent control's background color
                    using (var brush = new System.Drawing.SolidBrush(Parent.BackColor))
                    {
                        e.Graphics.FillRectangle(brush, this.ClientRectangle);
                    }
                }
            }
            else
            {
                base.OnPaintBackground(e); // Fallback to default behavior if Parent is null
            }
        }
    }
}

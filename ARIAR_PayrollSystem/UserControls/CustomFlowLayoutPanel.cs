using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ARIAR_PayrollSystem.UserControls
{
    public class CustomFlowLayoutPanel : FlowLayoutPanel
    {
        // DllImport for ShowScrollBar from user32.dll
        [DllImport("user32.dll")]
        private static extern int ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        // Constants for the scroll bar types
        private const int SB_HORZ = 0; // Horizontal scroll bar
        private const int SB_VERT = 1; // Vertical scroll bar
        private const int SB_BOTH = 3; // Both scroll bars

        // Override the WndProc method to intercept messages
        protected override void WndProc(ref Message m)
        {
            // Intercept window messages for non-client area painting and resizing
            const int WM_NCPAINT = 0x0085; // Non-client area painting message
            const int WM_NCCALCSIZE = 0x0083; // Non-client area (scroll bars) calculation
            const int WM_SIZE = 0x0005; // Resize event message

            // Hide the scrollbars when necessary
            if (m.Msg == WM_NCPAINT || m.Msg == WM_NCCALCSIZE || m.Msg == WM_SIZE)
            {
                ShowScrollBar(this.Handle, SB_BOTH, false); // Hides both scroll bars
            }

            // Call base to handle other messages
            base.WndProc(ref m);
        }

        // Override the OnLayout method to suppress the scroll bars visibility
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

            // Ensure scrollbars remain hidden
            this.HorizontalScroll.Visible = false;
            this.VerticalScroll.Visible = false;
        }
    }
}

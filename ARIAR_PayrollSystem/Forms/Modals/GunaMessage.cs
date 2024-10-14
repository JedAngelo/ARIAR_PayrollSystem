using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Forms.Modals
{
    public class GunaMessage
    {
        public static void ShowMessage(Form parentForm, string message, string caption, MessageDialogIcon icon, MessageDialogButtons buttons = MessageDialogButtons.OK)
        {
            // Create and configure the Guna2MessageDialog
            Guna2MessageDialog dialog = new Guna2MessageDialog
            {
                Caption = caption,
                Icon = icon,
                Parent = parentForm,
                Buttons = buttons,
                Style = MessageDialogStyle.Default,
                Text = message,
            };

            // Show the dialog asynchronously (non-blocking)
            dialog.Show();
        }

        // Convenience methods for specific message types
        public static void InfoMessage(Form parentForm, string message, string caption)
        {
            ShowMessage(parentForm, message, caption, MessageDialogIcon.Information);
        }

        public static void ErrorMessage(Form parentForm, string message, string caption)
        {
            ShowMessage(parentForm, message, caption, MessageDialogIcon.Error);
        }

        public static void WarningMessage(Form parentForm, string message, string caption, MessageDialogButtons buttons = MessageDialogButtons.OK)
        {
            ShowMessage(parentForm, message, caption, MessageDialogIcon.Warning, buttons);
        }   

        public static DialogResult QuestionMessage(Form parentForm, string message, string caption, MessageDialogButtons buttons = MessageDialogButtons.YesNoCancel)
        {
            Guna2MessageDialog dialog = new Guna2MessageDialog
            {
                Caption = caption,
                Icon = MessageDialogIcon.Question,
                Parent = parentForm,
                Buttons = buttons,
                Style = MessageDialogStyle.Default,
                Text = message,
            };

            // Capture the response
            var result = dialog.Show();  // Result can be Yes, No, or Cancel
            return result;                             // Process the result as needed
        }







    }
}

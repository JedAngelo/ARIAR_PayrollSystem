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
        public static void Info(Form parentForm, string message, string caption)
        {
            if (parentForm.InvokeRequired)
            {
                parentForm.Invoke(new Action(() => Info(parentForm, message, caption)));
            }
            else
            {
                ShowMessage(parentForm, message, caption, MessageDialogIcon.Information);
            }
        }

        public static void Error(Form parentForm, string message, string caption)
        {
            if (parentForm.InvokeRequired)
            {
                parentForm.Invoke(new Action(() => Error(parentForm, message, caption)));
            }
            else
            {
                ShowMessage(parentForm, message, caption, MessageDialogIcon.Error);
            }
        }

        public static void Warning(Form parentForm, string message, string caption, MessageDialogButtons buttons = MessageDialogButtons.OK)
        {
            if (parentForm.InvokeRequired)
            {
                parentForm.Invoke(new Action(() => Warning(parentForm, message, caption, buttons)));
            }
            else
            {
                ShowMessage(parentForm, message, caption, MessageDialogIcon.Warning, buttons);
            }
        }

        public static DialogResult Question(Form parentForm, string message, string caption, MessageDialogButtons buttons = MessageDialogButtons.YesNoCancel)
        {
            if (parentForm.InvokeRequired)
            {
                return (DialogResult)parentForm.Invoke(new Func<DialogResult>(() => Question(parentForm, message, caption, buttons)));
            }
            else
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

                // Show and capture the response
                return dialog.Show();
            }
        }








    }
}

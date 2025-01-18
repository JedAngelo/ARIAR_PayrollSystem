using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace PayrollSystem.Forms.Modals
{
    public class GunaMessage
    {
        public static DialogResult ShowMessage(string message, string caption, MessageDialogIcon icon, MessageDialogButtons buttons = MessageDialogButtons.OK)
        {
            // Attempt to find the main form once
            var mainForm = Application.OpenForms["MainForm"] as Form;

            if (mainForm == null)
            {
                GunaMessage.Error("No main form found!", "ERROR");
                return DialogResult.None;
            }

            Guna2MessageDialog dialog = new Guna2MessageDialog
            {
                Caption = caption,
                Icon = icon,
                Parent = mainForm,
                Buttons = buttons,
                Style = MessageDialogStyle.Default,
                Text = message,
            };

            if (mainForm.InvokeRequired)
            {
                // Run on the main UI thread and capture DialogResult
                return (DialogResult)mainForm.Invoke(new Func<DialogResult>(() => dialog.Show()));
            }
            else
            {
                return dialog.Show();
            }
        }


        // Convenience methods for specific message types
        public static DialogResult Info(string message, string caption)
        {
            return ShowMessage(message, caption, MessageDialogIcon.Information);
        }

        public static DialogResult Error(string message, string caption)
        {
            return ShowMessage(message, caption, MessageDialogIcon.Error);
        }

        public static DialogResult Warning(string message, string caption, MessageDialogButtons buttons = MessageDialogButtons.OK)
        {
            return ShowMessage(message, caption, MessageDialogIcon.Warning, buttons);
        }

        public static DialogResult Question(Form parentForm, string message, string caption, MessageDialogButtons buttons = MessageDialogButtons.YesNoCancel)
        {
            if (parentForm.InvokeRequired)
            {
                // Run on the main UI thread and capture DialogResult
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

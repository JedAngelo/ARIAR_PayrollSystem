﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals
{
    public partial class ConsoleLogsModal : Form
    {
        private bool _isConsoleOutputRedirected;
        public ConsoleLogsModal()
        {
            InitializeComponent();
            _isConsoleOutputRedirected = false;
            //RedirectConsoleToTextBox();
        }
        public void RedirectConsoleToTextBox()
        {
            if (!_isConsoleOutputRedirected)
            {
                var textWriter = new TextBoxWriter(ConsoleLogs);
                Console.SetOut(textWriter); // Redirect console output
                _isConsoleOutputRedirected = true;
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ConsoleLogsModal_Load(object sender, EventArgs e)
        {
        }

        private void ConsoleLogsModal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Hide();
            }
        }
    }
    public class TextBoxWriter : TextWriter
    {
        private readonly RichTextBox _outputBox;
        private StringBuilder _buffer; // Buffer to accumulate characters

        public TextBoxWriter(RichTextBox outputBox)
        {
            _outputBox = outputBox;
            _buffer = new StringBuilder();
        }

        public override Encoding Encoding => Encoding.UTF8;

        public override void Write(char value)
        {
            _buffer.Append(value);
            if (value == '\n')
            {
                FlushBuffer();
            }
        }

        public override void Write(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                _buffer.Append(value);
                FlushBuffer();
            }
        }

        public override void WriteLine(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                _buffer.Append(value + Environment.NewLine);
                FlushBuffer();

            }
        }

        private void FlushBuffer()
        {
            if (_buffer.Length > 0)
            {
                string timestamp = DateTime.Now.ToString("HH:mm:ss.fff"); // Format with milliseconds

                string text = $"[{timestamp}]    {_buffer}";

                _buffer.Clear();
                _outputBox.Invoke((MethodInvoker)(() =>
                {
                    _outputBox.AppendText(text);
                    _outputBox.ScrollToCaret();
                }));
            }
        }
    }
}
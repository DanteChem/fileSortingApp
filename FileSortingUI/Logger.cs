using System;
using System.Windows.Forms;
using fileSortingApp;

namespace FileSortingUI
{
    public class Logger : ILogger
    {
        private readonly TextBox _textBox;
        public Logger(TextBox textBox)
        {
            _textBox = textBox;
        }

        public void LogString(string message)
        {
            if (string.IsNullOrWhiteSpace(_textBox.Text))
            {
                _textBox.AppendText(message);
            }
            else
            {
                _textBox.AppendText(Environment.NewLine + message);
            }
        }
    }
}
 
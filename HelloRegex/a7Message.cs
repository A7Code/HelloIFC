using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloRegex
{
    static class a7Message
    {
        static RichTextBox _showBox;
        public static void SetShowBox(RichTextBox _inShowBox)
        {
            _showBox = _inShowBox;
        }

        public static void ShowMessage(string _inMessage)
        {
            _showBox.Text += _inMessage;
        }
    }
}

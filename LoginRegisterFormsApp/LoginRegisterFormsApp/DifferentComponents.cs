using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegisterFormsApp
{
    class DifferentComponents
    {
        public bool IsTextBoxEmptyOrWhiteSpace(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text);
        }

        public bool TextBoxContainsSpace(TextBox textBox)
        {
            return textBox.Text.Contains(" ");
        }
    }
}

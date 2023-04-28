using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Файтинг
{
    static class CheckText
    {
        static public bool CheckSignText(TextBox textBox)
        {
            return textBox.Text.Length >= 3;
        }
    }
}

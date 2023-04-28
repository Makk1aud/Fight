using System;
using System.Windows.Forms;

namespace Файтинг
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
        }

        private void RulesForm_Load(object sender, EventArgs e)
        {

        }

        private void ChangeFocus(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}

using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Файтинг
{
    public partial class Board : Form
    {        
        public Board()
        {
            InitializeComponent();
        }

        private void Board_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.LoadBoard(this);
            table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(CheckText.CheckSignText(search))
            {               
                reserTable_Click(sender, e);
                for (int i = 0; i < table.Rows.Count - 1; i++)
                    table.Rows[i].Visible = table[1, i].Value.ToString() == search.Text;
            }           
        }

        private void reserTable_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Rows.Count - 1; i++)
                table.Rows[i].Visible = true;
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}

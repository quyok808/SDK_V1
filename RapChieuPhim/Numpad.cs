using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Numpad : Form
    {
        public Numpad()
        {
            InitializeComponent();
        }
        public int gtri = -1;

        private void NumPadDialog_Deactivate(object sender, EventArgs e) => Close();
        private void btnNumberClick(object sender, EventArgs e)
        {
            gtri = int.Parse((sender as Button).Text);
            Close();
        }
        private void button_cancel_Click(object sender, EventArgs e) => Close();

        private void NumPadDialog_Load(object sender, EventArgs e)
        {

        }

    }
}

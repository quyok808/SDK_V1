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
        #region Phục vụ việc chỉ hiển thị 1 form duy nhất trong main
        private static Numpad instance = null;
        public static Numpad Instance
        {
            get
            {
                if (Numpad.instance == null || Numpad.instance.IsDisposed)
                {
                    Numpad.instance = new Numpad();
                }
                return Numpad.instance;
            }
        }
        #endregion
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

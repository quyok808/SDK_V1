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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region button event
        private void Create_Matrix_Click(object sender, EventArgs e)
        {
            gtri = 1;
            GenerateMap();
        }
        int gtri;
        private void O1_Click(object sender, MouseEventArgs e)
        {
            Numpad np = new Numpad();
            np.Show();
            Button btn = sender as Button;
            np.FormClosed += (object s, FormClosedEventArgs ea) =>
            {
                if (np.gtri != -1)
                {
                    gtri = np.gtri;
                    if (gtri != np.gtri)
                    {
                        
                    }
                    groupBox1.Refresh();
                    btn.Text = gtri.ToString();
                }
                np.Dispose();
            };   
        }
        private void button_check_Click(object sender, EventArgs e)
        {
            for (int i =0; i < n*n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    var btnText = btns[i, j].Text;
                    if (btnText != map[i, j].ToString())
                    {
                        MessageBox.Show("Sai roi!!! ");
                        return;
                    }
                }
            }
            MessageBox.Show("Dung roi !!!");
        }
        private void button_exit_Click(object sender, EventArgs e) => Close();
        #endregion

        const int n = 3;
        public int[,] map = new int[n*n,n*n];
        public Button[,] btns = new Button[n*n,n*n];
        #region Tao bang sudoku
        public void GenerateMap()
        {
            for (int i = 0;i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    map[i,j] = (i*n+i/n+j) % (n*n)+1;
                    btns[i, j] = new Button();
                }
            }
            Random rd = new Random();
            for (int i = 0; i < 40; i++)
            {
                SuffleMap(rd.Next(0, 5));
            }
            CreateMap();
            HideCell();
        }
        public void CreateMap()
        {
            groupBox1.Controls.Clear();
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    Button btn = new System.Windows.Forms.Button();
                    btns[i, j] =btn;
                    btn.BackColor = System.Drawing.Color.White;
                    btn.FlatStyle = FlatStyle.Popup;

                    btn.Name = (j * 9 + i + 1).ToString();
                    btn.Size = new System.Drawing.Size(39, 34);
                    btn.TabIndex = 0;
                    btn.Text = map[i,j].ToString();

                    btn.UseVisualStyleBackColor = false;
                    btn.MouseClick += O1_Click;

                    btn.Location = new System.Drawing.Point(17 + i * 47, 22 + j * 40);
                    groupBox1.Controls.Add(btn);
                }
            }
        }
        public void SuffleMap(int i)
        {
            switch (i)
            {
                case 0:
                    MatrixTransposition();
                    break;
                case 1:
                    SwapRowInBlock();
                    break;
                case 2:
                    SwapColInBlock();
                    break;
                case 3:
                    SwapBlocksInRow();
                    break;
                case 4:
                    SwapBlocksInCol();
                    break;
                default:
                    MatrixTransposition();
                    break;

            }
        }
        #region Doi cho lm cho cac o khong trung gia tri
        public void MatrixTransposition()
        {
            int[,] tmap = new int[n * n, n * n];
            for (int i = 0; i < n*n; i++) 
            {
                for (int j = 0; j < n*n; j++)
                {
                    tmap[i,j] = map[j,i];
                }
            }
            map = tmap;
        }
        public void SwapRowInBlock()
        {
            Random rd = new Random();
            var Block = rd.Next(0, n);
            var row1 = rd.Next(0,n);
            var line1 = Block * n + row1;
            var row2 = rd.Next(0, n);
            while (row1 == row2)
            {
                row2 = rd.Next(0, n);
            }
            var line2 = Block * n + row2;
            for (int i = 0; i < n*n;i++)
            {
                var temp = map[line1, i];
                map[line1,i] = map[line2,i];
                map[line2,i] = temp;
            }
        }

        public void SwapColInBlock()
        {
            Random rd = new Random();
            var Block = rd.Next(0, n);
            var row1 = rd.Next(0, n);
            var line1 = Block * n + row1;
            var row2 = rd.Next(0, n);
            while (row1 == row2)
            {
                row2 = rd.Next(0, n);
            }
            var line2 = Block * n + row2;
            for (int i = 0; i < n * n; i++)
            {
                var temp = map[i, line1];
                map[ i, line1] = map[i,line2];
                map[i,line2] = temp;
            }
        }

        public void SwapBlocksInRow()
        {
            Random rd = new Random();
            var Block1 = rd.Next(0, n);
            var Block2 = rd.Next(0, n);
            while(Block1 == Block2)
            {
                Block2 = rd.Next(0, n);
            }
            Block1 *= n;
            Block2 *= n;
            for (int i = 0; i < n*n; i++)
            {
                var k = Block2;
                for (int j = Block1; j < Block1 + n; j++)
                {
                    var temp = map[j, i];
                    map[j,i] = map[k, i];
                    map[k,i] = temp;
                    k++;
                }
            }
        }

        public void SwapBlocksInCol()
        {
            Random rd = new Random();
            var Block1 = rd.Next(0, n);
            var Block2 = rd.Next(0, n);
            while (Block1 == Block2)
            {
                Block2 = rd.Next(0, n);
            }
            Block1 *= n;
            Block2 *= n;
            for (int i = 0; i < n * n; i++)
            {
                var k = Block2;
                for (int j = Block1; j < Block1 + n; j++)
                {
                    var temp = map[i,j];
                    map[i,j] = map[i,k];
                    map[i,k] = temp;
                    k++;
                }
            }
        }
        #endregion
        public void HideCell()
        {
            int N = 40;
            Random rd = new Random();
            while (N > 0)
            {
                for (int i = 0; i < n * n; i++)
                {
                    for (int j = 0;j < n * n; j++)
                    {
                        if (!string.IsNullOrEmpty(btns[i,j].Text))
                        {
                            int a = rd.Next(0, 5);
                            btns[i, j].Text = a == 0 ? "": btns[i, j].Text; 
                            btns[i,j].Enabled = a == 0 ? true : false;
                            if (a == 0)
                            {
                                N--;
                            }
                            if (N <=0)
                            {
                                break;
                            }
                        }
                        if (N <= 0)
                        {
                            break;
                        }
                    }
                }
            }
            
        } //lam lung lo mot vai vtri trong bang 
        #endregion  
    }
}

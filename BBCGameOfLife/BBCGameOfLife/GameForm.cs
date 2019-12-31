using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBCGameOfLife
{
    public partial class GameForm : Form
    {
        Grid grid;
        string seed;
        Graphics g;
        public GameForm(string seedInput)
        {
            seed = seedInput;
            InitializeComponent();
            System.Threading.Thread.Sleep(100);
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            if(grid == null)
            {
                grid = new Grid(seed, (this.Width / 10), (this.Height / 10));
            }
            timer.Start();
            g = e.Graphics;
            grid.updateAllCells();
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);
            for (int i = 0; i < (this.Width / 10); i++)
            {
                g.DrawLine(pen, i * 10, 0, i * 10, this.Height);
            }
            for (int i = 0; i < (this.Height / 10); i++)
            {
                g.DrawLine(pen, 0, i * 10, this.Width, i * 10);
            }
            pen.Dispose();
            for (int i = 0; i < this.Width / 10; i++)
            {
                for (int j = 0; j < this.Height / 10; j++)
                {
                    if (grid.getCellStatus(i, j))
                    {
                        g.DrawString("•", new Font("Arial", 24), brush, ((i * 10)-5), ((j * 10)-13)/*, (i * 10) + 15, (j * 10) + 15*/);
                    }
                }
            }
            brush.Dispose();
            System.Threading.Thread.Sleep(100);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}

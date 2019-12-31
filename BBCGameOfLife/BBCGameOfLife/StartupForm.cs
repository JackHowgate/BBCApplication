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
    public partial class StartupForm : Form
    {
        GameForm gameForm;
        public StartupForm()
        {
            InitializeComponent();
        }

        private void generateSeedButton_Click(object sender, EventArgs e)
        {
            string seed = "";
            Random rnd = new Random();
            for(int i = 0; i < 1000; i++)
            {
                seed = seed + rnd.Next(0, 2);
            }
            seedBox.Text = seed;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Program.game = new GameOfLife(seedBox.Text);
            this.Hide();
        }
    }
}

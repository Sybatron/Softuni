using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class Difficulty : Form
    {
        Form1 game = new Form1();
        public Difficulty()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            gameStart(250,250);
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            gameStart(350,350);
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            gameStart(450,450);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void gameStart(int width,int height)
        {
            game.Show();
            game.Width = width;
            game.Height = height;
            this.MinimizeBox = true;
        }
    }
}

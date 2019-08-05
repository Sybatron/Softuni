using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BilliardBall
{
    
    public partial class Form1 : Form
    {
        public Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var freq = 1;
            var g = e.Graphics;
            var pen = new Pen(Color.Black, 10);

            g.FillRectangle(Brushes.Green, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            g.DrawRectangle(pen, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);

            
            var x = rand.Next() % ClientSize.Width;
            var y = rand.Next() % ClientSize.Height;
            var changeX = 5;
            var changeY = 5;

            while (true)
            {
                g.FillEllipse(Brushes.Black, x - 10, y - 10, 20, 20);
                System.Threading.Thread.Sleep(freq);
                g.FillEllipse(Brushes.Green, x - 10, y - 10, 20, 20);
                if (x <= 15 || x >= ClientSize.Width - 16) changeX = -changeX;
                if (y <= 15 || y >= ClientSize.Height - 16) changeY = -changeY;
                g.DrawRectangle(pen, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
                x += changeX; y += changeY;
            }
        }
    }
}

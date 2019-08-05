using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics_133_134_16_Apr_19
{
    public partial class P134_3 : Form
    {
        public P134_3()
        {
            InitializeComponent();
        }

        private void P134_3_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var p = new Pen(Color.Black, 1);
            var side = 200;
            int x1 = 50, y1 = 500;
            int x2 = x1 + side, y2 = y1;
            var x3 = (x1 + x2) / 2;
            var h = (int)(side * Math.Sqrt(3) / 2);
            var y3 = y1 - h;
            g.DrawLine(p, x1, y1, x2, y2);
            g.DrawLine(p, x2, y2, x3, y3);
            g.DrawLine(p, x3, y3, x1, y1);

            for (int i = 0; i < 80; i++)
            {
                x1 += 10;
                x2 = x1 + side;
                x3 = (x1 + x2) / 2;
            g.DrawLine(p, x1, y1, x2, y2);
            g.DrawLine(p, x2, y2, x3, y3);
            g.DrawLine(p, x3, y3, x1, y1);
            }

        }
    }
}

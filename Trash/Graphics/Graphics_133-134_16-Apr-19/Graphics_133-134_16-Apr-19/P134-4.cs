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
    public partial class P134_4 : Form
    {
        Random rand = new Random();

        public P134_4()
        {
            InitializeComponent();
        }

        private void P134_4_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            int y = 100;
            for (int i = 0; i < 10; i++)
            {
                var width = rand.Next() % 20 + 10;
                var p = new Pen(Color.FromArgb(rand.Next() % 255, rand.Next() % 255, rand.Next() % 255, rand.Next() % 255), width);
                g.DrawLine(p, 100, y, 600, y);
                y += width;
            }

        }
    }
}

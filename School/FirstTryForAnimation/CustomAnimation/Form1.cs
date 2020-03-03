using CustomAnimation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CustomAnimation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            int freq = 100;
            var shop = new Shop(new Point(200, 100), new Size(500, 300), new SolidBrush(Color.SaddleBrown), ref g);
            DrawShop(g, shop);
            var path = new Rectangle(new Point(ClientSize.Width / 2 - 50, shop.Original.Y + shop.Original.Height)
                                    , new Size(125, ClientSize.Height));
            g.FillRectangle(new SolidBrush(Color.Gray), path);

            shop.OpenDoors(ref g, freq);
            Thread.Sleep(50);
            shop.CloseDoors(ref g, freq);
        }

        private static void DrawShop(Graphics g, Shop shop)
        {
            shop.AddWindow(new Window(50, new SolidBrush(Color.Aqua)));
            shop.ChangeWindowPosition(1, 50, 50);

            shop.AddWindow(new Window(50, new SolidBrush(Color.Aqua)));
            shop.ChangeWindowPosition(2, shop.Original.Width - 50 * 2, 50);

            g.FillRectangle(shop.Windows[0].Brush, new Rectangle(shop.Windows[0].Position, shop.Windows[0].Size));
            g.FillRectangle(shop.Windows[1].Brush, new Rectangle(shop.Windows[1].Position, shop.Windows[1].Size));

            shop.AddDoor(new Door(50, 100, new SolidBrush(Color.Goldenrod)));
            shop.ChangeDoorPosition(1, 0, 0);

            shop.AddDoor(new Door(50, 100, new SolidBrush(Color.DarkGoldenrod)));
            shop.ChangeDoorPosition(2, 50, 0);

            g.FillRectangle(shop.Doors[0].Brush, new Rectangle(shop.Doors[0].Position, shop.Doors[0].Size));
            g.FillRectangle(shop.Doors[1].Brush, new Rectangle(shop.Doors[1].Position, shop.Doors[1].Size));
        }
    }
}

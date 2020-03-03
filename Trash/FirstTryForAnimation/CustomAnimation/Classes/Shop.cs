using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CustomAnimation.Classes
{
    public class Shop
    {
        public List<Window> windows = new List<Window>();
        public List<Door> doors = new List<Door>();
        public Rectangle original;

        public Shop(Point posOrig, Size sizeOrig, SolidBrush brush, ref Graphics g)
        {
            original = new Rectangle(posOrig, sizeOrig);
            g.FillRectangle(brush, original);
        }
        public void addWindow(Window window)
        {
            windows.Add(window);
        }
        public void addDoor(Door door)
        {
            doors.Add(door);
        }
        public void OpenDoors(ref Graphics g, int freq)
        {
            if (doors.Count == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    doors[0].position.X -= 10;
                    doors[1].position.X += 10;
                    g.FillRectangle(doors[0].brush, new Rectangle(doors[0].position, doors[0].size));
                    g.FillRectangle(doors[1].brush, new Rectangle(doors[1].position, doors[1].size));
                    g.FillRectangle(Brushes.Gold,
                        new Rectangle(new Point(doors[0].position.X + doors[0].size.Width, doors[0].position.Y),
                            new Size(doors[1].position.X, doors[1].position.Y)));
                    System.Threading.Thread.Sleep(freq);
                }
            }
        }
        public void CloseDoors(ref Graphics g, int freq)
        {
            if (doors.Count == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    doors[0].position.X += 10;
                    doors[1].position.X -= 10;
                    g.FillRectangle(doors[0].brush, new Rectangle(doors[0].position, doors[0].size));
                    g.FillRectangle(doors[1].brush, new Rectangle(doors[1].position, doors[1].size));
                    g.FillRectangle(Brushes.Gold,
                        new Rectangle(new Point(doors[0].position.X + doors[0].size.Width, doors[0].position.Y),
                            new Size(doors[1].position.X, doors[1].position.Y)));
                    System.Threading.Thread.Sleep(freq);
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CustomAnimation.Classes
{
    public class Shop
    {
        private List<Window> windows;
        private List<Door> doors;
        private Rectangle original;
        private SolidBrush brush;

        public List<Window> Windows { get => windows; set => windows = value; }
        public List<Door> Doors { get => doors; set => doors = value; }
        public Rectangle Original { get => original; set => original = value; }

        public Shop(Point position, Size size, SolidBrush brush, ref Graphics g)
        {
            original = new Rectangle(position, size);
            g.FillRectangle(brush, original);
            this.brush = brush;
            windows = new List<Window>();
            doors = new List<Door>();
        }

        public void AddWindow(Window window)
        {
            windows.Add(window);
        }
        public void ChangeWindowPosition(int window, int xAdd, int yAdd)
        {
            windows[window - 1].Position = new Point(original.X + xAdd, original.Y + yAdd);
        }

        public void AddDoor(Door door)
        {
            doors.Add(door);
        }
        public void ChangeDoorPosition(int door, int xAdd, int yAdd)
        {
            doors[door - 1].Position =
                new Point(original.X + original.Width / 2 - doors[door - 1].Size.Width + xAdd
                , original.Y + original.Height - doors[door - 1].Size.Height + yAdd);
        }
        public void OpenDoors(ref Graphics g, int freq)
        {
            if (doors.Count == 2)
            {
                for (int i = 0; i < 5; i++)
                {
                    doors[0].Position = new Point(doors[0].Position.X - 10, doors[0].Position.Y);
                    doors[1].Position = new Point(doors[1].Position.X + 10, doors[1].Position.Y);
                    g.FillRectangle(doors[0].Brush, new Rectangle(doors[0].Position, doors[0].Size));
                    g.FillRectangle(doors[1].Brush, new Rectangle(doors[1].Position, doors[1].Size));
                    g.FillRectangle(Brushes.Pink,
                        new Rectangle(new Point(doors[0].Position.X + doors[0].Size.Width, doors[0].Position.Y),
                            new Size(doors[1].Position.X - (doors[0].Position.X + doors[0].Size.Width)
                            , doors[0].Size.Height)));
                    System.Threading.Thread.Sleep(freq);
                }
            }
        }
        public void CloseDoors(ref Graphics g, int freq)
        {
            if (doors.Count == 2)
            {
                for (int i = 0; i < 5; i++)
                {
                    doors[0].Position = new Point(doors[0].Position.X + 10, doors[0].Position.Y);
                    doors[1].Position = new Point(doors[1].Position.X - 10, doors[1].Position.Y);
                    g.FillRectangle(brush,
                        new Rectangle(
                            new Point(original.X, original.Y + original.Height - doors[0].Size.Height)
                            , new Size(original.Width, doors[0].Size.Height)));
                    g.FillRectangle(Brushes.Pink,
                        new Rectangle(new Point(doors[0].Position.X + doors[0].Size.Width, doors[0].Position.Y),
                            new Size(doors[1].Position.X - (doors[0].Position.X + doors[0].Size.Width)
                            , doors[0].Size.Height)));
                    g.FillRectangle(doors[0].Brush, new Rectangle(doors[0].Position, doors[0].Size));
                    g.FillRectangle(doors[1].Brush, new Rectangle(doors[1].Position, doors[1].Size));
                    System.Threading.Thread.Sleep(freq);
                }
            }
        }

    }
}

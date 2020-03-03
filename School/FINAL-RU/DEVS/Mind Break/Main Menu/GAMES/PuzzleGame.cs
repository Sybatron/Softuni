using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace PuzzleGame
{
    public partial class PuzzleGame : Form
    {
        bool allowed = true;
        Point EmptyPoint;
        ArrayList images = new ArrayList();
        int mins = 0;
        int sec = 0;
        Image original;

        //Testing helps
        bool isTest = false;
        string rightCode = "ABC";
        string code = "";
        Button BTN;
        Button prevBTN;
        public PuzzleGame()
        {
            EmptyPoint.X = 300;
            EmptyPoint.Y = 300;
            InitializeComponent();
            //finalPiece.Visible = false;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            startGameButton.Enabled = false;
            //".\\Akeno_Himejima.jpg"
            foreach (Button b in panel1.Controls) b.Enabled = true;
            try
            {
                original = Image.FromFile(randomPic());
            }
            catch (Exception)
            {
                original = Image.FromFile(".\\Pictures\\AC.jpg");
            }
            CropImageToImages(original, 450, 450);

            AddImagesToButtons(images);
            timer1.Enabled = true;
        }
        private void новаИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(".\\TEXT\\FormToOpen.txt", "Puzzle");
            File.WriteAllText(".\\TEXT\\isNewGame.txt", "true");
            File.WriteAllText(".\\TEXT\\isClosing.txt", "false");
            Application.Restart();
        }
        private void къмМенютоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(".\\TEXT\\isClosing.txt", "false");
            Application.Restart();
        }
        private void PuzzleGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec >= 60)
            {
                sec -= 60;
                mins++;
            }
            timeLabel.Text = mins + " : " + sec;
        }

        string randomPic()
        {
            Random rand = new Random();
            int num = rand.Next(1, 13);

            switch (num)
            {
                case 1:
                    return ".\\Pictures\\AOT.jpg";
                case 2:
                    return ".\\Pictures\\DeathNote.jpg";
                case 3:
                    return ".\\Pictures\\DragonMaid.jpg";
                case 4:
                    return ".\\Pictures\\DXD.jpg";
                case 5:
                    return ".\\Pictures\\HI.jpg";
                case 6:
                    return ".\\Pictures\\KNK.jpg";
                case 7:
                    return ".\\Pictures\\MNY.jpg";
                case 8:
                    return ".\\Pictures\\ReZero.jpg";
                case 9:
                    return ".\\Pictures\\SAO.jpg";
                case 10:
                    return ".\\Pictures\\TokyoGhoul.jpg";
                case 11:
                    return ".\\Pictures\\YoujoSenki.jpg";
                case 12:
                    return ".\\Pictures\\ZeroTwo.jpg";
                default:
                    return ".\\Pictures\\TLR.jpg";
            }
        }
        void CropImageToImages(Image original, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(original, 0, 0, w, h);
            graphic.Dispose();

            int movr = 0, movd = 0;
            for (int x = 0; x < 9; x++)
            {
                Bitmap piece = new Bitmap(150, 150);

                for (int i = 0; i < 150; i++)
                    for (int j = 0; j < 150; j++)
                        piece.SetPixel(i, j, bmp.GetPixel(i + movr, j + movd));

                images.Add(piece);
                movr += 150;

                if (movr == 450)
                {
                    movr = 0;
                    movd += 150;
                }
            }

        }
        void AddImagesToButtons(ArrayList images)
        {
            int i = 0;
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };
            arr = suffle(arr);
            foreach (Button b in panel1.Controls)
            {
                if (b != finalPiece)
                    if (i < arr.Length)
                    {
                        b.Image = (Image)images[arr[i]];
                        i++;
                    }
            }
            
        }
        private int[] suffle(int[] arr)
        {
            Random rand = new Random();
            arr = arr.OrderBy(x => rand.Next()).ToArray();

            return arr;
        }

        private void pic1_Click(object sender, EventArgs e)
        {

            if (allowed)
            {
                Button btn = (Button)sender;
                if (
                    ((btn.Location.X == EmptyPoint.X - 150 || btn.Location.X == EmptyPoint.X + 150)
                    && btn.Location.Y == EmptyPoint.Y)
                    ||
                ((btn.Location.Y == EmptyPoint.Y - 150 || btn.Location.Y == EmptyPoint.Y + 150)
                    && btn.Location.X == EmptyPoint.X)
                    )
                {
                    Point swap = btn.Location;
                    btn.Location = EmptyPoint;
                    EmptyPoint = swap;
                    finalPiece.Location = swap;
                }

                if (EmptyPoint.X == 200 && EmptyPoint.Y == 200)
                {
                    CheckValid();
                }

                if (isTest)
                {
                    Button BTN = (Button)sender;
                }
            }
        }
        private void CheckValid()
        {
            int count = 0, index;
            foreach (Button btn in panel1.Controls)
            {
                if (btn != finalPiece)
                {
                    index = (btn.Location.Y / 150) * 3 + btn.Location.X / 150;
                    if (images[index] == btn.Image)
                    {
                        count++;
                    }
                    if (count == 7)
                    {
                        timer1.Enabled = false;
                        finalPiece.Visible = true;
                        allowed = false;
                        MessageBox.Show("Выигрыш!");
                        break;
                    }
                }
            }
        }

        private void finalPiece_MouseLeave(object sender, EventArgs e)
        {
            finalPiece.Image = null;
        }

        private void finalPiece_Click(object sender, EventArgs e)
        {
            finalPiece.Image = (Image)images[8];
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mind_Break
{
    public partial class Form1 : Form
    {
        Information infoForm = new Information();
        int oldScroll = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void normalColor_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightGray;
        }

        private void onMouseColor_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.SlateGray;
        }
        //CGpanel 215;105 || Movable 250:115 Location 12;210
        private void CGScrollBar_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar nowScroll = (ScrollBar)sender;
            int changeValue = 0;
            if (nowScroll.Value != oldScroll)
            {
                changeValue = nowScroll.Value - oldScroll;
                changeValue *= -1;
            }
            try
            {
                foreach (Button btn in CGpanel.Controls)
                {
                    btn.Location = new Point(btn.Location.X, btn.Location.Y + changeValue);
                }
            }
            catch (Exception)
            {
            }
            oldScroll = nowScroll.Value;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            infoForm.Show();
        }

        private void CGButton_Click(object sender, EventArgs e)
        {
            CG_MovablePanel.Location = new Point(12, 210);
        }


        private void hangmanButton_Click(object sender, EventArgs e)
        {

        }

        private void tictactoeButton_Click(object sender, EventArgs e)
        {

        }

        private void puzzleButton_Click(object sender, EventArgs e)
        {

        }

        private void pingpongButton_Click(object sender, EventArgs e)
        {

        }

        private void killmoleButton_Click(object sender, EventArgs e)
        {

        }

        private void numGameButton_Click(object sender, EventArgs e)
        {

        }

        private void snakeButton_Click(object sender, EventArgs e)
        {

        }
    }
}

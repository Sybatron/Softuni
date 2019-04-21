using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mind_Break.GAMES.Quiz
{
    public partial class QuizEndGame : Form
    {
        public QuizEndGame()
        {
            InitializeComponent();
            Rewardlabel.Text = File.ReadAllText(".\\TEXT\\takenMoney.txt") + "Рубли";

        }

        private void QuizEndGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Application.Exit();
        }

        private void NewGamebutton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(".\\TEXT\\FormToOpen.txt", "Quiz");
            File.WriteAllText(".\\TEXT\\isNewGame.txt", "true");
            File.WriteAllText(".\\TEXT\\isClosing.txt", "false");
            Application.Restart();
        }

        private void BackToMenubutton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(".\\TEXT\\isClosing.txt", "false");
            Application.Restart();
        }
    }
}

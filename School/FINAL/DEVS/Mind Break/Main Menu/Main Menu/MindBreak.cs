using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mind_Break
{
    public partial class MindBreak : Form
    {
        //Games Forms
        Hangman.Hangman Hangman_Form = new Hangman.Hangman();
        PuzzleGame.PuzzleGame PuzzleGame_Form = new PuzzleGame.PuzzleGame();
        SnakeGame.SnakeClass SnakeGame_Form = new SnakeGame.SnakeClass();
        sudoku_cs.Sudoku SudokuGame_Form = new sudoku_cs.Sudoku();
        ReflectionIT.Minesweeper.MinesweeperForm MinesweeperGame_Form = new ReflectionIT.Minesweeper.MinesweeperForm();
        Mind_Break.GAMES.Quiz.QuizGame QuizGame_Form = new Mind_Break.GAMES.Quiz.QuizGame();

        //Main Menu Code
        Information infoForm = new Information();

        public string isNewGame;
        public MindBreak()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutButton_Click(object sender, EventArgs e)
        {
            infoForm.Show();
        }

        //Changing Colors when you are over the button and when you leave the button
        private void normalColor_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightGray;
        }
        private void onMouseColor_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightSteelBlue;
        }
        //CGpanel 215;105 || Movable 250:115 Location 12;210

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            openForm();
        }
        public void openForm()
        {
            isNewGame = File.ReadAllText(".\\TEXT\\isNewGame.txt");
            if (isNewGame == "true")
            {
                isNewGame = "false";
                string name = File.ReadAllText(".\\TEXT\\FormToOpen.txt");
                switch (name)
                {
                    case "Hangman":
                        Hangman_Form.Show();
                        break;
                    case "Puzzle":
                        PuzzleGame_Form.Show();
                        break;
                    case "Snake":
                        SnakeGame_Form.Show();
                        break;
                    case "Sudoku":
                        SudokuGame_Form.Show();
                        break;
                    case "Quiz":
                        QuizGame_Form.Show();
                        break;
                    case "Minesweeper":
                        MinesweeperGame_Form.Show();
                        break;
                }
                File.WriteAllText(".\\TEXT\\FormToOpen.txt", "");
                File.WriteAllText(".\\TEXT\\isNewGame.txt", "false");
                Hide();
            }
        }

        private void snakeButton_Click(object sender, EventArgs e)
        {
            SnakeGame_Form.Show();
            Hide();
        }
        private void puzzleButton_Click(object sender, EventArgs e)
        {
            PuzzleGame_Form.Show();
            Hide();
        }
        private void hangmanButton_Click(object sender, EventArgs e)
        {
            Hangman_Form.Show();
            Hide();
        }
        private void sudokuButton_Click(object sender, EventArgs e)
        {
            SudokuGame_Form.Show();
            Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            string isClosing = File.ReadAllText(".\\TEXT\\isClosing.txt");
            if (isClosing == "true")
            {
                Hide();
                MessageBox.Show("Надяваме се да ви е харесало приложението");
                Application.Exit();
            }
            else File.WriteAllText(".\\TEXT\\isClosing.txt", "true");
        }

        private void Minesweeperbutton_Click(object sender, EventArgs e)
        {
            MinesweeperGame_Form.Show();
            Hide();
        }

        private void BeMillionairebutton_Click(object sender, EventArgs e)
        {
            QuizGame_Form.Show();
            Hide();
        }
    }
}

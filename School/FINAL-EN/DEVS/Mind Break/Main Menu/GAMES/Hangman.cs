using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Hangman : Form
    {
        List<string> words = new List<string>();
        List<Label> labels = new List<Label>();
        string word;
        int wrongCounter = 0;

        public Hangman()
        {
            InitializeComponent();
        }

        private void новаИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(".\\TEXT\\FormToOpen.txt", "Hangman");
            File.WriteAllText(".\\TEXT\\isNewGame.txt", "true");
            File.WriteAllText(".\\TEXT\\isClosing.txt", "false");
            Application.Restart();
        }
        private void къмМенютоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(".\\TEXT\\isClosing.txt", "false");
            Application.Restart();
        }
        private void Hangman_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Application.Exit();
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawHangmanPost();
            ReadFromFile();
            CreateLabels();

        }
        enum BodyParts
        {
            Head,
            Body,
            Right_Arm,
            Left_Arm,
            Left_Leg,
            Right_Leg,
            Left_Eye,
            Right_Eye,
            Mouth
        }
        void DrawHangmanPost()
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Brown, 10);
            g.DrawLine(p, new Point(180, 10), new Point(180, 190));
            g.DrawLine(p, new Point(180, 15), new Point(90, 15));
            g.DrawLine(p, new Point(90, 10), new Point(90, 40));

            /*
            //Draw the human
            DrawBodyPart(BodyParts.Head);
            DrawBodyPart(BodyParts.Right_Eye);
            DrawBodyPart(BodyParts.Left_Eye);
            DrawBodyPart(BodyParts.Mouth);
            DrawBodyPart(BodyParts.Body);
            DrawBodyPart(BodyParts.Left_Arm);
            DrawBodyPart(BodyParts.Right_Arm);
            DrawBodyPart(BodyParts.Left_Leg);
            DrawBodyPart(BodyParts.Right_Leg);
            */
        }
        void DrawBodyPart(BodyParts bp)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black, 2);
            SolidBrush s = new SolidBrush(Color.Brown);
            switch (bp)
            {
                case BodyParts.Head:
                    g.DrawEllipse(p, 73, 39, 35, 45);
                    break;
                case BodyParts.Left_Eye:
                    g.FillEllipse(s, 80, 50, 5, 5);
                    break;
                case BodyParts.Right_Eye:
                    g.FillEllipse(s, 95, 50, 5, 5);
                    break;
                case BodyParts.Mouth:
                    g.DrawArc(new Pen(Color.Tomato, 2), new Rectangle(83, 70, 15, 10), 0, -180);
                    break;

                case BodyParts.Body:
                    g.DrawLine(p, new Point(90, 85), new Point(90, 130));
                    break;

                case BodyParts.Left_Arm:
                    g.DrawLine(p, new Point(90, 95), new Point(75, 115));
                    break;
                case BodyParts.Right_Arm:
                    g.DrawLine(p, new Point(90, 95), new Point(105, 115));
                    break;

                case BodyParts.Left_Leg:
                    g.DrawLine(p, new Point(90, 129), new Point(80, 170));
                    break;
                case BodyParts.Right_Leg:
                    g.DrawLine(p, new Point(90, 129), new Point(100, 170));
                    break;
            }
        }

        string GetRandomWord()
        {
            int length = words.Count;
            if (length <= 0)
                return "";
            Random random = new Random();
            int index = random.Next(0, length - 1);
            return words[index];
        }

        void ReadFromFile()
        {
            if (!File.Exists(".\\words.txt"))
                return;

            StreamReader streamReader = new StreamReader(".\\words.txt");

            if (streamReader == null)
                return;

            while (!streamReader.EndOfStream)
            {
                words.Add(streamReader.ReadLine());
            }

            streamReader.Close();
        }
        void CreateLabels()
        {
            word = GetRandomWord();
            char[] chars = word.ToCharArray();
            int between = 334 / chars.Length - 1;
            for (int i = 0; i <= chars.Length - 1; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * between) + 10, 50);
                labels[i].Text = "_";
                labels[i].Font = new Font("Arial", 12);
                labels[i].BackColor = Color.Transparent;
                labels[i].Parent = WordsGroupBox;
                labels[i].BringToFront();
                labels[i].CreateControl();
            }
            int length = chars.Length;
            WordLenghtLabel.Text = WordLenghtLabel.Text + " " + length.ToString();
        }

        private void SubmitLetterButton_Click(object sender, EventArgs e)
        {
            char letter;
            try
            {
                letter = LetterTextBox.Text.ToLower().ToCharArray()[0];
            }
            catch (Exception)
            {
                MessageBox.Show("You can enter only latin letters", "ERROR!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LetterTextBox.Text = "";
            if (!char.IsLetter(letter) || (letter >= 'А' && letter <= 'я'))
            {
                MessageBox.Show("You can enter only latin letters", "ERROR!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (word.Contains(letter))
            {
                char[] letters = word.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == letter)
                    {
                        labels[i].Text = letter.ToString();
                    }
                }
                foreach (Label l in labels)
                {
                    if (l.Text == "_")
                    {
                        return;
                    }
                }
                EndOfGame(10);
            }
            else
            {
                MessageBox.Show("The letter you entered isn't in the word", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DrawBodyPart((BodyParts)wrongCounter);
                missedLetters.Text = missedLetters.Text + letter.ToString() + ",";
                EndOfGame(wrongCounter);
                wrongCounter++;
            }


        }

        private void SubmitWordButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < WordTextBox.Text.Length; i++)
            {
                if (!char.IsLetter(WordTextBox.Text[i]) || (WordTextBox.Text[i] >= 'А' && WordTextBox.Text[i] <= 'я'))
                {
                    MessageBox.Show("You can enter only latin letters", "ERROR!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (WordTextBox.Text == word)
            {
                EndOfGame(10);
            }
            else
            {
                MessageBox.Show("The word you entered isn't the right word", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DrawBodyPart((BodyParts)wrongCounter);
                EndOfGame(wrongCounter);
                wrongCounter++;
                WordTextBox.Text = "";
            }
        }

        void EndOfGame(int counter)
        {
            if (counter == 8)
            {
                MessageBox.Show("You lost!\nThe word is: " + word.ToString(), "End of game!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SubmitWordsGroupBox.Enabled = false;
            }
            else if (counter == 10)
            {
                MessageBox.Show("You won!\nYou guessed the word: " + word.ToString(), "Congratulations!");
                SubmitWordsGroupBox.Enabled = false;
            }
        }

        private void Hangman_MouseUp(object sender, MouseEventArgs e)
        {
            DrawHangmanPost();
            for (int i = 0; i < wrongCounter; i++)
            {
                DrawBodyPart((BodyParts)i);
            }
        }
    }
}

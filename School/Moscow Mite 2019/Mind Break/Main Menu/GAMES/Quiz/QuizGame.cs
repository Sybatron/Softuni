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
    public partial class QuizGame : Form
    {
        string nowQuestion;
        int sec = 0;
        bool wrong = false;

        double nowReward = 0;
        public double knownReward = 0;
        public double taken;
        double rightAnswers = 0;
        List<Label> rewardslabels = new List<Label>();
        int i = 1;
        Random rand = new Random();

        string questions;
        public QuizGame()
        {
            InitializeComponent();
            label21.Visible = false;
        }
        private void QuizGame_Load(object sender, EventArgs e)
        {

            int a = rand.Next(1, 3);
            switch (a)
            {
                case 1:
                    QuestiontextBox.Text = "Какво прави сомелиерът?";
                    Answer1button.Text = "дегустира вина";
                    Answer2button.Text = "лови сомове";
                    Answer3button.Text = "селектира семена";
                    Answer4button.Text = "приготвя сосове за риба";
                    break;
                case 2:
                    QuestiontextBox.Text = "Колко деца има английската кралица Елизабет?";
                    Answer1button.Text = "1";
                    Answer2button.Text = "4";
                    Answer3button.Text = "6";
                    Answer4button.Text = "8";
                    break;
                case 3:
                    QuestiontextBox.Text = "Къде се намира седалището на Световната здравна организация?";
                    Answer1button.Text = "в Париж";
                    Answer2button.Text = "в Берн";
                    Answer3button.Text = "в Женева";
                    Answer4button.Text = "във Виена";
                    break;
            }
            nowQuestion = QuestiontextBox.Text;
            int formula = 0;
            foreach (Label lab in RewardsgroupBox.Controls)
            {
                rewardslabels.Add(lab);
            }
            for (int j = 23; j >= 0; j--)
            {
                formula += (int)(Math.Ceiling(i / 4.0) * 500);
                rewardslabels[j].Text = formula.ToString();
                i++;
            }
            i = 22;
            rewardslabels[23].BackColor = Color.LightBlue;
        }

        private void QuizGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Application.Exit();
        }
        private void новаИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(".\\TEXT\\FormToOpen.txt", "Quiz");
            File.WriteAllText(".\\TEXT\\isNewGame.txt", "true");
            File.WriteAllText(".\\TEXT\\isClosing.txt", "false");
            Application.Restart();
        }
        private void къмМенютоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(".\\TEXT\\isClosing.txt", "false");
            Application.Restart();
        }

        void Check(Button btn)
        {

            nowQuestion = QuestiontextBox.Text;

            switch (QuestiontextBox.Text)
            {
                case "Какво са гоблените?":
                case "Кой е най-старият тенис турнир, основан през 1877г.?":
                case "Каква зодия е Микеланджело ди Лудовико Буонароти Симони, роден на 6 март 1475г.?":
                case "Какво означава думата \"блескавица\"(диалект)?":
                case "Как се нарича миграцията на населението от селата в градовете, обусловена от социалноикономически условия?":
                case "През коя година е открит паметникът на връх Свети Никола(Шипка)?":
                case "Кой е най-големият морски бозайник?":
                case "Къде се празнува ежегодно Никулден на 6.12?":
                case "През коя година е основана известната социална мрежа Twitter?":
                    btn.BackColor = Color.Red;
                    Answer1button.BackColor = Color.Green;
                    break;

                case "Колко деца има английската кралица Елизабет?":
                case "Кой орган липсва при жените?":
                case "Коя от страните не е членка на Европейския съюз?":
                case "Колко ядра има всяко ново Чехълче(тип Ресничести)?":
                case "През коя година е роден френският писател Александър Дюма-баща?":
                case "Колко са смъртните грехове споменати в Библията?":
                case "Кой актьор играе ролята на Кевин Маккалистър във филма \"Сам вкъщи\" 1 и \"Сам вкъщи\" 2?":
                case "Коя от следните игри НЕ се играе с карти?":
                case "Коя е столицата на Швеция?":
                    btn.BackColor = Color.Red;
                    Answer2button.BackColor = Color.Green;
                    break;

                case "Какво прави сомелиерът?":
                case "Къде се намира седалището на Световната здравна организация?":
                case "Колко метра е била висока статуята на Зевс, изваяна от скулптора Фидий, едно от седемте чудеса на света?":
                case "Кой от изброените български градове НЕ е разположен по брега на Черно море?":
                case "Как се придвижва медузата?":
                case "За кой спорт се отнася следното: \"Игран от милиони, наблюдаван от милиарди\"?":
                case "През коя година е създадена България?":
                    btn.BackColor = Color.Red;
                    Answer3button.BackColor = Color.Green;
                    break;

                case "Коя програма е най-гледаната от българите през 2012 година?":
                case "Колко скулптури на лъвове има на Орлов мост в София?":
                case "Кой от изброените няма общо със семейството на Тодор Живков?":
                case "Две тела са в топлинно равновесие едно от друго, ако имат еднаква:":
                case "Какво е името на Румънеца от рап дуото Румънеца и Енчев?":
                case "През кой век е изчезнала и последната птица Додо?":
                    btn.BackColor = Color.Red;
                    Answer4button.BackColor = Color.Green;
                    break;
            }
            Answer1button.Enabled = false;
            Answer2button.Enabled = false;
            Answer3button.Enabled = false;
            Answer4button.Enabled = false;
            NextQuestiontimer.Enabled = true;
        }

        void NextQuestion(int num)
        {
            int num2 = rand.Next(1, 3);

            switch (num)
            {
                #region inside
                case 1:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Кой орган липсва при жените?";
                            Answer1button.Text = "панкреас";
                            Answer2button.Text = "простата";
                            Answer3button.Text = "щитовидна жлеза";
                            Answer4button.Text = "сърце";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Коя от страните не е членка на Европейския съюз?";
                            Answer1button.Text = "Естония";
                            Answer2button.Text = "Исландия";
                            Answer3button.Text = "Малта";
                            Answer4button.Text = "Словения";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Какво са гоблените?";
                            Answer1button.Text = "картини от конци";
                            Answer2button.Text = "глинени фигури";
                            Answer3button.Text = "нито едно от изброените";
                            Answer4button.Text = "восъчни скулптури";
                            break;
                    }
                    break;
                case 2:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Колко ядра има всяко ново Чехълче(тип Ресничести)?";
                            Answer1button.Text = "1";
                            Answer2button.Text = "2";
                            Answer3button.Text = "3";
                            Answer4button.Text = "4";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Коя програма е най-гледаната от българите през 2012 година?";
                            Answer1button.Text = "ТВ 7";
                            Answer2button.Text = "Нова";
                            Answer3button.Text = "БНТ";
                            Answer4button.Text = "БТВ";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Кой е най-старият тенис турнир, основан през 1877г.?";
                            Answer1button.Text = "Уимбълдън";
                            Answer2button.Text = "Откритото първенство на САЩ";
                            Answer3button.Text = "Откритото първенство на Франция";
                            Answer4button.Text = "Откритото първенство на Австралия";
                            break;
                    }
                    break;
                case 3:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Колко метра е била висока статуята на Зевс, изваяна от скулптора Фидий, едно от седемте чудеса на света?";
                            Answer1button.Text = "5";
                            Answer2button.Text = "9";
                            Answer3button.Text = "12";
                            Answer4button.Text = "20";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Каква зодия е Микеланджело ди Лудовико Буонароти Симони, роден на 6 март 1475г.?";
                            Answer1button.Text = "Риби";
                            Answer2button.Text = "Рак";
                            Answer3button.Text = "Овен";
                            Answer4button.Text = "Телец";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Какво означава думата \"блескавица\"(диалект)?";
                            Answer1button.Text = "светкавица,мълния";
                            Answer2button.Text = "факел";
                            Answer3button.Text = "тиган";
                            Answer4button.Text = "великан";
                            break;
                    }
                    break;
                case 4:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Как се нарича миграцията на населението от селата в градовете, обусловена от социалноикономически условия?";
                            Answer1button.Text = "урбанизация";
                            Answer2button.Text = "емиграция";
                            Answer3button.Text = "деградация";
                            Answer4button.Text = "глобализация";
                            break;
                        case 2:
                            QuestiontextBox.Text = "През коя година е роден френският писател Александър Дюма-баща?";
                            Answer1button.Text = "1809";
                            Answer2button.Text = "1802";
                            Answer3button.Text = "1925";
                            Answer4button.Text = "1896";
                            break;
                        case 3:
                            QuestiontextBox.Text = "През коя година е открит паметникът на връх Свети Никола(Шипка)?";
                            Answer1button.Text = "1934";
                            Answer2button.Text = "1990";
                            Answer3button.Text = "1876";
                            Answer4button.Text = "1856";
                            break;
                    }
                    break;
                case 5:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Колко са смъртните грехове споменати в Библията?";
                            Answer1button.Text = "3";
                            Answer2button.Text = "7";
                            Answer3button.Text = "10";
                            Answer4button.Text = "Нито един от изброените";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Кой е най-големият морски бозайник?";
                            Answer1button.Text = "кит";
                            Answer2button.Text = "морж";
                            Answer3button.Text = "ламантин";
                            Answer4button.Text = "делфин";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Кой актьор играе ролята на Кевин Маккалистър във филма \"Сам вкъщи\" 1 и \"Сам вкъщи\" 2?";
                            Answer1button.Text = "Алекс Линц";
                            Answer2button.Text = "Макколи Кълкин";
                            Answer3button.Text = "Вин Дизел";
                            Answer4button.Text = "Алън Макрей";
                            break;
                    }
                    break;
                case 6:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Колко скулптури на лъвове има на Орлов мост в София?";
                            Answer1button.Text = "2";
                            Answer2button.Text = "3";
                            Answer3button.Text = "4";
                            Answer4button.Text = "0";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Кой от изброените български градове НЕ е разположен по брега на Черно море?";
                            Answer1button.Text = "Поморие";
                            Answer2button.Text = "Обзор";
                            Answer3button.Text = "Камено";
                            Answer4button.Text = "Ахтопол";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Къде се празнува ежегодно Никулден на 6.12?";
                            Answer1button.Text = "България";
                            Answer2button.Text = "Мексико";
                            Answer3button.Text = "САЩ";
                            Answer4button.Text = "Русия";
                            break;
                    }
                    break;
                case 7:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Кой от изброените няма общо със семейството на Тодор Живков?";
                            Answer1button.Text = "Мара Малеева";
                            Answer2button.Text = "Любомир Стойчев";
                            Answer3button.Text = "Тодор Славков";
                            Answer4button.Text = "Георги Парцалев";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Две тела са в топлинно равновесие едно от друго, ако имат еднаква:";
                            Answer1button.Text = "кинетична енергия";
                            Answer2button.Text = "обем";
                            Answer3button.Text = "маса";
                            Answer4button.Text = "температура";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Как се придвижва медузата?";
                            Answer1button.Text = "с ръцете си";
                            Answer2button.Text = "с плваниците си";
                            Answer3button.Text = "с изтласкване на засмуканата вода";
                            Answer4button.Text = "както се движи змията";
                            break;
                    }
                    break;
                case 8:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Коя от следните игри НЕ се играе с карти?";
                            Answer1button.Text = "война";
                            Answer2button.Text = "морски шах";
                            Answer3button.Text = "3,5,8";
                            Answer4button.Text = "канаста";
                            break;
                        case 2:
                            QuestiontextBox.Text = "За кой спорт се отнася следното: \"Игран от милиони, наблюдаван от милиарди\"?";
                            Answer1button.Text = "волейбол";
                            Answer2button.Text = "бейзбол";
                            Answer3button.Text = "футбол";
                            Answer4button.Text = "ръгби";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Какво е името на Румънеца от рап дуото Румънеца и Енчев?";
                            Answer1button.Text = "Траян Бъсеску";
                            Answer2button.Text = "Козмин Еминеску";
                            Answer3button.Text = "Атанас Захиров";
                            Answer4button.Text = "Адриан Рачев";
                            break;
                    }
                    break;
                case 9:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Коя е столицата на Швеция?";
                            Answer1button.Text = "Брюксел";
                            Answer2button.Text = "Стокхолм";
                            Answer3button.Text = "Берн";
                            Answer4button.Text = "Цюрих";
                            break;
                        case 2:
                            QuestiontextBox.Text = "През коя година е основана известната социална мрежа Twitter?";
                            Answer1button.Text = "2006";
                            Answer2button.Text = "2000";
                            Answer3button.Text = "2010";
                            Answer4button.Text = "2012";
                            break;
                        case 3:
                            QuestiontextBox.Text = "През кой век е изчезнала и последната птица Додо?";
                            Answer1button.Text = "21";
                            Answer2button.Text = "14";
                            Answer3button.Text = "20";
                            Answer4button.Text = "17";
                            break;
                        case 4:
                            QuestiontextBox.Text = "През коя година е създадена България?";
                            Answer1button.Text = "700";
                            Answer2button.Text = "630";
                            Answer3button.Text = "681";
                            Answer4button.Text = "689";
                            break;
                    }
                    break;
                    #endregion
            }
            if (questions == QuestiontextBox.Text)
            {
                NextQuestion(new Random().Next(1, 9));
            }
            else
                questions = QuestiontextBox.Text;
        }

        private void Answer1button_Click(object sender, EventArgs e)
        {
            Check(Answer1button);
        }
        private void Answer2button_Click(object sender, EventArgs e)
        {
            Check(Answer2button);
        }
        private void Answer3button_Click(object sender, EventArgs e)
        {
            Check(Answer3button);
        }
        private void Answer4button_Click(object sender, EventArgs e)
        {
            Check(Answer4button);
        }

        private void NextQuestiontimer_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 1)
            {
                sec = 0;
                foreach (Button btn in AnswersgroupBox.Controls)
                {
                    if (btn.BackColor == Color.Red)
                    {
                        wrong = true;
                    }
                }
                if (!wrong)
                {
                    int num_1 = rand.Next(1, 9);
                    Answer1button.BackColor = Color.Gainsboro;
                    Answer2button.BackColor = Color.Gainsboro;
                    Answer3button.BackColor = Color.Gainsboro;
                    Answer4button.BackColor = Color.Gainsboro;
                    Answer1button.Enabled = true;
                    Answer2button.Enabled = true;
                    Answer3button.Enabled = true;
                    Answer4button.Enabled = true;
                    NextQuestion(num_1);
                    rightAnswers++;
                    nowReward += (int)(Math.Ceiling(rightAnswers / 4.0) * 500);
                    if (rightAnswers % 4 == 0)
                    {
                        knownReward = nowReward;
                        taken = knownReward;
                        WriteTaken();
                        WinQuiz WinRewardQuiz_Form = new WinQuiz();
                        WinRewardQuiz_Form.Show();
                    }
                    rewardslabels[i].BackColor = Color.LightBlue;
                    rewardslabels[i + 1].BackColor = Color.Gainsboro;
                    i--;

                    if (rightAnswers == 23)
                    {
                        taken = nowReward;
                        WriteTaken();
                        QuizEndGame EndGame_Form = new QuizEndGame();
                        EndGame_Form.Show();
                        Hide();
                    }
                }
                else
                {
                    taken = knownReward;
                    WriteTaken();
                    QuizEndGame EndGame_Form = new QuizEndGame();
                    EndGame_Form.Show();
                    Hide();
                }
                NextQuestiontimer.Enabled = false;
            }
        }

        private void Takebutton_Click(object sender, EventArgs e)
        {
            taken = nowReward;
            WriteTaken();
            QuizEndGame EndGame_Form = new QuizEndGame();
            EndGame_Form.Show();
            Hide();
        }

        void WriteTaken()
        {
            File.WriteAllText(".\\TEXT\\takenMoney.txt", taken.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

        string questions;
        Random rand = new Random();
        public QuizGame()
        {
            InitializeComponent();
            label21.Visible = false;
        }
        private void QuizGame_Load(object sender, EventArgs e)
        {
            int a = rand.Next() % 3 + 1;
            switch (a)
            {
                case 1:
                    QuestiontextBox.Text = "Чем занимается сомелье?";
                    Answer1button.Text = "дегустирует вина";
                    Answer2button.Text = "ловит сомы";
                    Answer3button.Text = "селектирует семена";
                    Answer4button.Text = "готовит соусы";
                    break;
                case 2:
                    QuestiontextBox.Text = "Сколько детей у английской королевы Елизабет?";
                    Answer1button.Text = "1";
                    Answer2button.Text = "4";
                    Answer3button.Text = "6";
                    Answer4button.Text = "8";
                    break;
                case 3:
                    QuestiontextBox.Text = "Где находится штаб-квартира Всемирной организации здравоохранения?";
                    Answer1button.Text = "в Париже";
                    Answer2button.Text = "в Берне";
                    Answer3button.Text = "в Женеве";
                    Answer4button.Text = "в Вене";
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
                case "Что это гобелены?":
                case "Какой из перечисленных тенис-турниров самый старый?":
                case "Знаете ли вы знак зодиака Микеланджело ди Лудовико Буонароти Симони, который родился 6 март 1475г.?":
                case "Что означает диалектное слово \"блескавица\"":
                case "Какой термин используется для обозначения миграции населения из деревни в город?":
                case "В каком году был открыт памятник на вершине Шипка?":
                case "Самое большое морское млекопитающее это?":
                case "В какой стране ежегодно 6-ого декабря празднуют День Святого Николая?":
                case "Когда создана социальная сеть Twitter?":
                    btn.BackColor = Color.Red;
                    Answer1button.BackColor = Color.Green;
                    break;

                case "Сколько детей у английской королевы Елизабет?":
                case "Какой орган отсутствует у женщин?":
                case "Какая из перечисленных стран не является членом Европейского союза?":
                case "Сколько ядер у каждого нового одноклеточного \"Инфузории туфельки\"?":
                case "В каком году родился французский писатель Александър Дюма-отец?":
                case "О скольких смертных грехах упоминается в библии?":
                case "Какой актер сыграл роль Кевина Маккалистера в фильме \"Один дома 1\" и  \"Один дома 2\"? ":
                case "Какая из перечисленных игр не является игрой в карты?":
                case "Какой город столица Швеции?":
                    btn.BackColor = Color.Red;
                    Answer2button.BackColor = Color.Green;
                    break;

                case "Чем занимается сомелье?":
                case "Где находится штаб-квартира Всемирной организации здравоохранения?":
                case "Статуя Зевса скульптура Фидия – одно из семи чудес мира. Какая ее высота?":
                case "Какой из перечисленных болгарских городов НЕ находится на Черном море?":
                case "Как передвигается медуза?":
                case "К какому спорту относится: \"Играется миллионами, наблюдается миллиардами\"?":
                case "В каком году создана Болгария?":
                    btn.BackColor = Color.Red;
                    Answer3button.BackColor = Color.Green;
                    break;

                case "Какая программа самая популярная в Болгарии за 2012 год?":
                case "Сколько статуй львов на Орловом мосту в Софии?":
                case "Кто из перечисленных не связан с семьей Тодора Живкова?":
                case "Две тела находятся в термодинамическом равновесии,если у них?":
                case "Какое настоящее имя исполнителя Румынеца /рап дуо Румынеца и Енчев/?":
                case "В каком веке исчезла последняя птица Додо?":
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

            int num2 = rand.Next() % 3 + 1;

            switch (num)
            {
                #region inside
                case 1:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Какой орган отсутствует у женщин?";
                            Answer1button.Text = "поджелу́дочная железа";
                            Answer2button.Text = "предстательная железа";
                            Answer3button.Text = "щитовидная железа";
                            Answer4button.Text = "сердце";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Какая из перечисленных стран не является членом Европейского союза?";
                            Answer1button.Text = "Естония";
                            Answer2button.Text = "Исландия";
                            Answer3button.Text = "Малта";
                            Answer4button.Text = "Словения";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Что это \"гобелены\"?";
                            Answer1button.Text = "вышитые картини";
                            Answer2button.Text = "глиняные фигуры";
                            Answer3button.Text = "ни одно из перечисленного";
                            Answer4button.Text = "восковые скульптуры";
                            break;
                    }
                    break;
                case 2:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Сколько ядер у каждого нового одноклеточного \"Инфузории туфельки\" ?";
                            Answer1button.Text = "1";
                            Answer2button.Text = "2";
                            Answer3button.Text = "3";
                            Answer4button.Text = "4";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Какая программа самая популярная в Болгарии за 2012 год?";
                            Answer1button.Text = "ТВ 7";
                            Answer2button.Text = "Нова";
                            Answer3button.Text = "БНТ";
                            Answer4button.Text = "БТВ";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Какой из перечисленных тенис-турниров самый старый?";
                            Answer1button.Text = "Уимблдон";
                            Answer2button.Text = "Открытый чемпионат США";
                            Answer3button.Text = "Открытый чемпионат Франции";
                            Answer4button.Text = "Открытый чемпионат Австралии";
                            break;
                    }
                    break;
                case 3:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Статуя Зевса скульптура Фидия – одно из семи чудес мира. Какая ее высота?";
                            Answer1button.Text = "5";
                            Answer2button.Text = "9";
                            Answer3button.Text = "12";
                            Answer4button.Text = "20";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Знаете ли вы знак зодиака Микеланджело ди Лудовико Буонароти Симони, который родился 6 март 1475г.?";
                            Answer1button.Text = "Рыбы";
                            Answer2button.Text = "Рак";
                            Answer3button.Text = "Овен";
                            Answer4button.Text = "Телец";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Что означает диалектное слово \"блескавица\"?";
                            Answer1button.Text = "молния";
                            Answer2button.Text = "факел";
                            Answer3button.Text = "сковорода";
                            Answer4button.Text = "великан";
                            break;
                    }
                    break;
                case 4:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Какой термин используется для обозначения миграции населения из деревни в город?";
                            Answer1button.Text = "урбанизация";
                            Answer2button.Text = "эмиграция";
                            Answer3button.Text = "деградация";
                            Answer4button.Text = "глобализация";
                            break;
                        case 2:
                            QuestiontextBox.Text = "В каком году родился французский писатель Александър Дюма-отец?";
                            Answer1button.Text = "1809";
                            Answer2button.Text = "1802";
                            Answer3button.Text = "1925";
                            Answer4button.Text = "1896";
                            break;
                        case 3:
                            QuestiontextBox.Text = "В каком году был открыт памятник на вершине Шипка?";
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
                            QuestiontextBox.Text = "О скольких смертных грехах упоминается в библии?";
                            Answer1button.Text = "3";
                            Answer2button.Text = "7";
                            Answer3button.Text = "10";
                            Answer4button.Text = "Ни одно из перечисленного";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Самое большое морское млекопитающее это?";
                            Answer1button.Text = "кит";
                            Answer2button.Text = "морж";
                            Answer3button.Text = "ламантин";
                            Answer4button.Text = "дельфин";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Какой актер сыграл роль Кевина Маккалистера в фильме \"Один дома 1\" и  \"Один дома 2\"?";
                            Answer1button.Text = "Алекс Линц";
                            Answer2button.Text = "Маколей Калкин";
                            Answer3button.Text = "Вин Дизель";
                            Answer4button.Text = "Алан Макрей ";
                            break;
                    }
                    break;
                case 6:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Сколько статуй львов на Орловом мосту в Софии?";
                            Answer1button.Text = "2";
                            Answer2button.Text = "3";
                            Answer3button.Text = "4";
                            Answer4button.Text = "0";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Какой из перечисленных болгарских городов НЕ находится на Черном море?";
                            Answer1button.Text = "Поморие";
                            Answer2button.Text = "Обзор";
                            Answer3button.Text = "Камено";
                            Answer4button.Text = "Ахтопол";
                            break;
                        case 3:
                            QuestiontextBox.Text = "В какой стране ежегодно 6-ого декабря празднуют День Святого Николая";
                            Answer1button.Text = "Болгария";
                            Answer2button.Text = "Мехико";
                            Answer3button.Text = "США";
                            Answer4button.Text = "Россия";
                            break;
                    }
                    break;
                case 7:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Кто из перечисленных не связан с семьей Тодора Живкова?";
                            Answer1button.Text = "Мара Малеева";
                            Answer2button.Text = "Любомир Стойчев";
                            Answer3button.Text = "Тодор Славков";
                            Answer4button.Text = "Георги Парцалев";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Две тела находятся в термодинамическом равновесии,если у них";
                            Answer1button.Text = "одинаковая кинетическая энергия";
                            Answer2button.Text = "одинаковый объем";
                            Answer3button.Text = "одинаковая масса";
                            Answer4button.Text = "одинаковая температура";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Как передвигается медуза?";
                            Answer1button.Text = "руками";
                            Answer2button.Text = "ластами";
                            Answer3button.Text = "выталкивая воду сокращением купола";
                            Answer4button.Text = "как змея";
                            break;
                    }
                    break;
                case 8:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Какая из перечисленных игр не является игрой в карты?";
                            Answer1button.Text = "Война";
                            Answer2button.Text = "Крестики нолики";
                            Answer3button.Text = "3,5,8";
                            Answer4button.Text = "Канаста";
                            break;
                        case 2:
                            QuestiontextBox.Text = "К какому спорту относится:\"Играется миллионами, наблюдается миллиардами\"?";
                            Answer1button.Text = "волейбол";
                            Answer2button.Text = "бейсбол";
                            Answer3button.Text = "футбол";
                            Answer4button.Text = "регби-футбол";
                            break;
                        case 3:
                            QuestiontextBox.Text = "Какое настоящее имя исполнителя Румынеца /рап дуо Румынеца и Енчев/?";
                            Answer1button.Text = "Траян Бэсеску";
                            Answer2button.Text = "Козмин Эминеску";
                            Answer3button.Text = "Атанас Захиров";
                            Answer4button.Text = "Адриан Рачев";
                            break;
                    }
                    break;
                case 9:
                    switch (num2)
                    {
                        case 1:
                            QuestiontextBox.Text = "Какой город столица Швеции?";
                            Answer1button.Text = "Брюссель";
                            Answer2button.Text = "Стокгольм";
                            Answer3button.Text = "Берн";
                            Answer4button.Text = "Цюрих";
                            break;
                        case 2:
                            QuestiontextBox.Text = "Когда создана социальная сеть Twitter?";
                            Answer1button.Text = "2006";
                            Answer2button.Text = "2000";
                            Answer3button.Text = "2010";
                            Answer4button.Text = "2012";
                            break;
                        case 3:
                            QuestiontextBox.Text = "В каком веке исчезла последняя птица Додо?";
                            Answer1button.Text = "21";
                            Answer2button.Text = "14";
                            Answer3button.Text = "20";
                            Answer4button.Text = "17";
                            break;
                        case 4:
                            QuestiontextBox.Text = "В каком году создана Болгария?";
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
                NextQuestion(new Random().Next() % 9 + 1);
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
                    int num_1 = rand.Next() % 9 + 1;
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

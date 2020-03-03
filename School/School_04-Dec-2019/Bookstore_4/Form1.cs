using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bookstore_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitType(genres);
            LoadType(genreComboBox);
            refButton.Enabled = false;
            addButton.Enabled = false;
            newTitleButton.Enabled = false;
            salePriceLabel.Text = string.Empty;
            saleSumPriceLabel.Text = string.Empty;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (refButton.Enabled == true && !flagsave)
            {
                DialogResult result = MessageBox.Show(
                "Излизане от програмата и данните не са записани!" +
                $"{Environment.NewLine}Да се запише ли във файл?",
                "Внимание!",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button3);

                if (result == DialogResult.No) return;

                if (result == DialogResult.Yes)
                {
                    saveButton_Click(this, new EventArgs());
                    return;
                }

                if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        Book[] books = new Book[100];
        string[] genres = new string[13];
        double sellPrice = 0;
        string title = string.Empty;
        int titleCounter = 0;

        bool flagsave = false;

        private void InitType(string[] Type)
        {
            genres[0] = "Хуманитарна литература";
            genres[1] = "Художествена литература";
            genres[2] = "Психология";
            genres[3] = "Компютри";
            genres[4] = "Чужди езици";
            genres[5] = "Техника";
            genres[6] = "Медицина";
            genres[7] = "Икономика";
            genres[8] = "Справочна литература";
            genres[9] = "Право";
            genres[10] = "Хоби";
            genres[11] = "Детска литература";
            genres[12] = "Друг";
        }

        private void LoadType(ComboBox comboBox)
        {
            for (int i = 0; i < 13; i++)
            {
                comboBox.Items.Add(genres[i]);
            }
        }

        #region AddBook
        private void newTitleButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            titleTextBox.Enabled = true;
            publisherTextBox.Enabled = true;
            authorTextBox.Enabled = true;
            countTextBox.Enabled = true;
            priceTextBox.Enabled = true;
            genreComboBox.Enabled = true;

            titleTextBox.Clear();
            publisherTextBox.Clear();
            authorTextBox.Clear();
            genreComboBox.Text = "";
            priceTextBox.Clear();
            countTextBox.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "" &&
                authorTextBox.Text != "" &&
                publisherTextBox.Text != "" &&
                priceTextBox.Text != "" &&
                countTextBox.Text != "" &&
                genreComboBox.Text != "")
            {
                books[titleCounter] = new Book()
                {
                    Title = titleTextBox.Text,
                    Author = authorTextBox.Text,
                    Publisher = publisherTextBox.Text,
                    Price = double.Parse(priceTextBox.Text),
                    Count = int.Parse(countTextBox.Text),
                    Genre = genreComboBox.SelectedIndex
                };
                books[titleCounter].RealCount = books[titleCounter].Count;

                titlesComboBox.Items.Add(books[titleCounter].Title);
                saleTitlesComboBox.Items.Add(books[titleCounter].Title);
                titleCounter++;
                titleCountLabel.Text = titleCounter.ToString();
            }
            flagsave = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (var writerBooks = new StreamWriter("books.txt"))
            {
                for (int i = 0; i < titleCounter; i++)
                {
                    writerBooks.WriteLine(books[i].Title);
                    writerBooks.WriteLine(books[i].Publisher);
                    writerBooks.WriteLine(books[i].Author);
                    writerBooks.WriteLine(genres[books[i].Genre]);
                    writerBooks.WriteLine(books[i].Price.ToString("0.00"));
                    writerBooks.WriteLine(books[i].Count);
                }
            }
            flagsave = true;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            titleCounter = 0;
            using (var readerBooks = new StreamReader("books.txt"))
            {
                while ((title = readerBooks.ReadLine()) != null)
                {
                    books[titleCounter] = new Book()
                    {
                        Title = title,
                        Publisher = readerBooks.ReadLine(),
                        Author = readerBooks.ReadLine()
                    };

                    titlesComboBox.Items.Add(books[titleCounter].Title);
                    saleTitlesComboBox.Items.Add(books[titleCounter].Title);

                    var genreTemp = readerBooks.ReadLine();
                    switch (genreTemp)
                    {
                        case "Хуманитарна литература": books[titleCounter].Genre = 0; break;
                        case "Художествена литература": books[titleCounter].Genre = 1; break;
                        case "Психология": books[titleCounter].Genre = 2; break;
                        case "Компютри": books[titleCounter].Genre = 3; break;
                        case "Чужди езици": books[titleCounter].Genre = 4; break;
                        case "Техника": books[titleCounter].Genre = 5; break;
                        case "Медицина": books[titleCounter].Genre = 6; break;
                        case "Икономика": books[titleCounter].Genre = 7; break;
                        case "Справочна литература": books[titleCounter].Genre = 8; break;
                        case "Право": books[titleCounter].Genre = 9; break;
                        case "Хоби": books[titleCounter].Genre = 10; break;
                        case "Детска литература": books[titleCounter].Genre = 11; break;
                        default: books[titleCounter].Genre = 12; break;
                    }

                    books[titleCounter].Price = double.Parse(readerBooks.ReadLine());
                    books[titleCounter].Count = int.Parse(readerBooks.ReadLine());
                    books[titleCounter].RealCount = books[titleCounter].Count;
                    titleCounter++;
                }
            }

            titleCountLabel.Text = titleCounter.ToString();
            titlesComboBox.Enabled = true;
            refButton.Enabled = true;
            loadButton.Enabled = false;
            newTitleButton.Enabled = true;
            saleAddButton.Enabled = true;
            saleTitlesComboBox.Enabled = true;
            saleCountTextBox.Enabled = true;
        }

        private void refButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            var index = -1;
            index = titlesComboBox.SelectedIndex;
            if (index != -1)
            {
                titleTextBox.Text = books[index].Title;
                publisherTextBox.Text = books[index].Publisher;
                authorTextBox.Text = books[index].Author;
                genreComboBox.Text = genres[books[index].Genre];
                priceTextBox.Text = books[index].Price.ToString("0.00");
                countTextBox.Text = books[index].Count.ToString();

                titleTextBox.Enabled = false;
                publisherTextBox.Enabled = false;
                authorTextBox.Enabled = false;
                countTextBox.Enabled = false;
                priceTextBox.Enabled = false;
                genreComboBox.Enabled = false;
            }
        }
        #endregion

        #region Sale
        private void saleAddButton_Click(object sender, EventArgs e)
        {
            var selectedBookCount = -1;
            var selectedIndex = saleTitlesComboBox.SelectedIndex;

            try
            {
                selectedBookCount = int.Parse(saleCountTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Проблем! Не сте въвели бройка!", "Внимание!");
            }

            if ((selectedBookCount != -1) && (selectedBookCount <= books[selectedIndex].Count))
            {
                books[selectedIndex].Count -= selectedBookCount;

                sellPrice += selectedBookCount * books[selectedIndex].Price;
                saleSumPriceLabel.Text = sellPrice.ToString("0.00");
                saleCartListBox.Items
                    .Add($"{books[selectedIndex].Title} {selectedBookCount} x {books[selectedIndex].Price.ToString("0.00")}");
                saleClearButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Проблем! Няма достатъчно книги!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                saleCountTextBox.Clear();
            }

            flagsave = false;
        }

        private void saleClearButton_Click(object sender, EventArgs e)
        {
            saleCartListBox.Items.Clear();

            for (int i = 0; i < titleCounter; i++)
            {
                books[i].Count = books[i].RealCount;
            }

            saleSumPriceLabel.Text = "0.00";
            sellPrice = 0;
            saleCountTextBox.Clear();
        }

        private void salePayButton_Click(object sender, EventArgs e)
        {
            saleCartListBox.Items.Clear();
            for (var i = 0; i < titleCounter; i++)
            {
                books[i].RealCount = books[i].Count;
            }

            saleSumPriceLabel.Text = "0.00";
            sellPrice = 0;
            saleCountTextBox.Clear();
        }

        private void saleTitlesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexBook = saleTitlesComboBox.SelectedIndex;
            salePriceLabel.Text = books[indexBook].Price.ToString("0.00");
        }
        #endregion
    }
}
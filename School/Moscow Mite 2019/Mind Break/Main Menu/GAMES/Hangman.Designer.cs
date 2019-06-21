namespace Hangman
{
    partial class Hangman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hangman));
            this.HangManGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WordsGroupBox = new System.Windows.Forms.GroupBox();
            this.WordLenghtLabel = new System.Windows.Forms.Label();
            this.missedLetters = new System.Windows.Forms.Label();
            this.SubmitWordsGroupBox = new System.Windows.Forms.GroupBox();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.LetterTextBox = new System.Windows.Forms.TextBox();
            this.SubmitWordButton = new System.Windows.Forms.Button();
            this.SubmitLetterButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.къмМенютоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HangManGroupBox.SuspendLayout();
            this.WordsGroupBox.SuspendLayout();
            this.SubmitWordsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HangManGroupBox
            // 
            this.HangManGroupBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HangManGroupBox.Controls.Add(this.panel1);
            this.HangManGroupBox.Location = new System.Drawing.Point(412, 31);
            this.HangManGroupBox.Name = "HangManGroupBox";
            this.HangManGroupBox.Size = new System.Drawing.Size(200, 220);
            this.HangManGroupBox.TabIndex = 0;
            this.HangManGroupBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 201);
            this.panel1.TabIndex = 0;
            // 
            // WordsGroupBox
            // 
            this.WordsGroupBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.WordsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WordsGroupBox.Controls.Add(this.WordLenghtLabel);
            this.WordsGroupBox.Controls.Add(this.missedLetters);
            this.WordsGroupBox.Location = new System.Drawing.Point(12, 31);
            this.WordsGroupBox.Name = "WordsGroupBox";
            this.WordsGroupBox.Size = new System.Drawing.Size(394, 125);
            this.WordsGroupBox.TabIndex = 1;
            this.WordsGroupBox.TabStop = false;
            // 
            // WordLenghtLabel
            // 
            this.WordLenghtLabel.AutoSize = true;
            this.WordLenghtLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordLenghtLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.WordLenghtLabel.Location = new System.Drawing.Point(241, 105);
            this.WordLenghtLabel.Name = "WordLenghtLabel";
            this.WordLenghtLabel.Size = new System.Drawing.Size(133, 15);
            this.WordLenghtLabel.TabIndex = 0;
            this.WordLenghtLabel.Text = "Дължина на думата:";
            // 
            // missedLetters
            // 
            this.missedLetters.AutoSize = true;
            this.missedLetters.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.missedLetters.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.missedLetters.Location = new System.Drawing.Point(6, 106);
            this.missedLetters.Name = "missedLetters";
            this.missedLetters.Size = new System.Drawing.Size(119, 14);
            this.missedLetters.TabIndex = 1;
            this.missedLetters.Text = "Липсващи букви: ";
            // 
            // SubmitWordsGroupBox
            // 
            this.SubmitWordsGroupBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SubmitWordsGroupBox.Controls.Add(this.WordTextBox);
            this.SubmitWordsGroupBox.Controls.Add(this.LetterTextBox);
            this.SubmitWordsGroupBox.Controls.Add(this.SubmitWordButton);
            this.SubmitWordsGroupBox.Controls.Add(this.SubmitLetterButton);
            this.SubmitWordsGroupBox.Location = new System.Drawing.Point(12, 162);
            this.SubmitWordsGroupBox.Name = "SubmitWordsGroupBox";
            this.SubmitWordsGroupBox.Size = new System.Drawing.Size(334, 89);
            this.SubmitWordsGroupBox.TabIndex = 2;
            this.SubmitWordsGroupBox.TabStop = false;
            // 
            // WordTextBox
            // 
            this.WordTextBox.Location = new System.Drawing.Point(117, 61);
            this.WordTextBox.MaxLength = 20;
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(123, 20);
            this.WordTextBox.TabIndex = 3;
            // 
            // LetterTextBox
            // 
            this.LetterTextBox.Location = new System.Drawing.Point(117, 22);
            this.LetterTextBox.MaxLength = 1;
            this.LetterTextBox.Name = "LetterTextBox";
            this.LetterTextBox.Size = new System.Drawing.Size(31, 20);
            this.LetterTextBox.TabIndex = 2;
            // 
            // SubmitWordButton
            // 
            this.SubmitWordButton.Location = new System.Drawing.Point(6, 59);
            this.SubmitWordButton.Name = "SubmitWordButton";
            this.SubmitWordButton.Size = new System.Drawing.Size(105, 23);
            this.SubmitWordButton.TabIndex = 1;
            this.SubmitWordButton.Text = "Предложи дума";
            this.SubmitWordButton.UseVisualStyleBackColor = true;
            this.SubmitWordButton.Click += new System.EventHandler(this.SubmitWordButton_Click);
            // 
            // SubmitLetterButton
            // 
            this.SubmitLetterButton.Location = new System.Drawing.Point(6, 19);
            this.SubmitLetterButton.Name = "SubmitLetterButton";
            this.SubmitLetterButton.Size = new System.Drawing.Size(105, 23);
            this.SubmitLetterButton.TabIndex = 0;
            this.SubmitLetterButton.Text = "Предложи буква";
            this.SubmitLetterButton.UseVisualStyleBackColor = true;
            this.SubmitLetterButton.Click += new System.EventHandler(this.SubmitLetterButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаИграToolStripMenuItem,
            this.къмМенютоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новаИграToolStripMenuItem
            // 
            this.новаИграToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.новаИграToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.новаИграToolStripMenuItem.Name = "новаИграToolStripMenuItem";
            this.новаИграToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.новаИграToolStripMenuItem.Text = "Нова Игра";
            this.новаИграToolStripMenuItem.Click += new System.EventHandler(this.новаИграToolStripMenuItem_Click);
            // 
            // къмМенютоToolStripMenuItem
            // 
            this.къмМенютоToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.къмМенютоToolStripMenuItem.Name = "къмМенютоToolStripMenuItem";
            this.къмМенютоToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.къмМенютоToolStripMenuItem.Text = "Към менюто";
            this.къмМенютоToolStripMenuItem.Click += new System.EventHandler(this.къмМенютоToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(615, 265);
            this.Controls.Add(this.SubmitWordsGroupBox);
            this.Controls.Add(this.WordsGroupBox);
            this.Controls.Add(this.HangManGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Hangman";
            this.Text = "Бесеница";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hangman_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.HangManGroupBox.ResumeLayout(false);
            this.WordsGroupBox.ResumeLayout(false);
            this.WordsGroupBox.PerformLayout();
            this.SubmitWordsGroupBox.ResumeLayout(false);
            this.SubmitWordsGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox HangManGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox WordsGroupBox;
        private System.Windows.Forms.GroupBox SubmitWordsGroupBox;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.TextBox LetterTextBox;
        private System.Windows.Forms.Button SubmitWordButton;
        private System.Windows.Forms.Button SubmitLetterButton;
        private System.Windows.Forms.Label WordLenghtLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label missedLetters;
        private System.Windows.Forms.ToolStripMenuItem новаИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem къмМенютоToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}


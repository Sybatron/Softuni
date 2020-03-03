namespace PuzzleGame
{
    partial class PuzzleGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuzzleGame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.finalPiece = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pic2 = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.къмМенютоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.finalPiece);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pic2);
            this.panel1.Controls.Add(this.pic1);
            this.panel1.Location = new System.Drawing.Point(16, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 554);
            this.panel1.TabIndex = 0;
            // 
            // finalPiece
            // 
            this.finalPiece.Enabled = false;
            this.finalPiece.Location = new System.Drawing.Point(400, 369);
            this.finalPiece.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finalPiece.Name = "finalPiece";
            this.finalPiece.Size = new System.Drawing.Size(200, 185);
            this.finalPiece.TabIndex = 8;
            this.finalPiece.UseVisualStyleBackColor = true;
            this.finalPiece.Click += new System.EventHandler(this.finalPiece_Click);
            this.finalPiece.MouseLeave += new System.EventHandler(this.finalPiece_MouseLeave);
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(200, 369);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(200, 185);
            this.button9.TabIndex = 7;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.pic1_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(400, 185);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 185);
            this.button8.TabIndex = 6;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.pic1_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(200, 185);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 185);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.pic1_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(0, 369);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 185);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.pic1_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(0, 185);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 185);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.pic1_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(400, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 185);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic2
            // 
            this.pic2.Enabled = false;
            this.pic2.Location = new System.Drawing.Point(200, 0);
            this.pic2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(200, 185);
            this.pic2.TabIndex = 1;
            this.pic2.UseVisualStyleBackColor = true;
            this.pic2.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic1
            // 
            this.pic1.Enabled = false;
            this.pic1.Location = new System.Drawing.Point(0, 0);
            this.pic1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(200, 185);
            this.pic1.TabIndex = 0;
            this.pic1.UseVisualStyleBackColor = true;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameButton.Location = new System.Drawing.Point(216, 642);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(200, 43);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Начать игру";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаИграToolStripMenuItem,
            this.къмМенютоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(645, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новаИграToolStripMenuItem
            // 
            this.новаИграToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.новаИграToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.новаИграToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.новаИграToolStripMenuItem.Name = "новаИграToolStripMenuItem";
            this.новаИграToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.новаИграToolStripMenuItem.Text = "Новая игра";
            this.новаИграToolStripMenuItem.Click += new System.EventHandler(this.новаИграToolStripMenuItem_Click);
            // 
            // къмМенютоToolStripMenuItem
            // 
            this.къмМенютоToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.къмМенютоToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.къмМенютоToolStripMenuItem.Name = "къмМенютоToolStripMenuItem";
            this.къмМенютоToolStripMenuItem.Size = new System.Drawing.Size(168, 29);
            this.къмМенютоToolStripMenuItem.Text = "Обратно к меню";
            this.къмМенютоToolStripMenuItem.Click += new System.EventHandler(this.къмМенютоToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.timeLabel.Location = new System.Drawing.Point(16, 652);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(63, 26);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "TIME";
            // 
            // PuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(645, 690);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "PuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пазлы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PuzzleGame_FormClosed);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button pic2;
        private System.Windows.Forms.Button pic1;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаИграToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button finalPiece;
        private System.Windows.Forms.ToolStripMenuItem къмМенютоToolStripMenuItem;
    }
}


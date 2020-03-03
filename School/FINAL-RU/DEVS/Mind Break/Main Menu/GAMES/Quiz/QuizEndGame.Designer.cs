namespace Mind_Break.GAMES.Quiz
{
    partial class QuizEndGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizEndGame));
            this.BackToMenubutton = new System.Windows.Forms.Button();
            this.NewGamebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Rewardlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToMenubutton
            // 
            this.BackToMenubutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackToMenubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMenubutton.ForeColor = System.Drawing.Color.Black;
            this.BackToMenubutton.Location = new System.Drawing.Point(81, 165);
            this.BackToMenubutton.Margin = new System.Windows.Forms.Padding(4);
            this.BackToMenubutton.Name = "BackToMenubutton";
            this.BackToMenubutton.Size = new System.Drawing.Size(204, 39);
            this.BackToMenubutton.TabIndex = 0;
            this.BackToMenubutton.Text = "Обратно к меню";
            this.BackToMenubutton.UseVisualStyleBackColor = false;
            this.BackToMenubutton.Click += new System.EventHandler(this.BackToMenubutton_Click);
            // 
            // NewGamebutton
            // 
            this.NewGamebutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NewGamebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGamebutton.ForeColor = System.Drawing.Color.Black;
            this.NewGamebutton.Location = new System.Drawing.Point(119, 117);
            this.NewGamebutton.Margin = new System.Windows.Forms.Padding(4);
            this.NewGamebutton.Name = "NewGamebutton";
            this.NewGamebutton.Size = new System.Drawing.Size(129, 39);
            this.NewGamebutton.TabIndex = 1;
            this.NewGamebutton.Text = "Новая игра";
            this.NewGamebutton.UseVisualStyleBackColor = false;
            this.NewGamebutton.Click += new System.EventHandler(this.NewGamebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вы выиграли сумму";
            // 
            // Rewardlabel
            // 
            this.Rewardlabel.AutoSize = true;
            this.Rewardlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Rewardlabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rewardlabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Rewardlabel.Location = new System.Drawing.Point(138, 68);
            this.Rewardlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rewardlabel.Name = "Rewardlabel";
            this.Rewardlabel.Size = new System.Drawing.Size(90, 32);
            this.Rewardlabel.TabIndex = 3;
            this.Rewardlabel.Text = "Рубли";
            this.Rewardlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuizEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(378, 224);
            this.Controls.Add(this.Rewardlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewGamebutton);
            this.Controls.Add(this.BackToMenubutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "QuizEndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конец игры";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuizEndGame_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMenubutton;
        private System.Windows.Forms.Button NewGamebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Rewardlabel;
    }
}
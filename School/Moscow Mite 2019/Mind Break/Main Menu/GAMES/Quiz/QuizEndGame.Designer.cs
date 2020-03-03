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
            this.BackToMenubutton.ForeColor = System.Drawing.Color.Black;
            this.BackToMenubutton.Location = new System.Drawing.Point(79, 136);
            this.BackToMenubutton.Name = "BackToMenubutton";
            this.BackToMenubutton.Size = new System.Drawing.Size(91, 23);
            this.BackToMenubutton.TabIndex = 0;
            this.BackToMenubutton.Text = "Към менюто";
            this.BackToMenubutton.UseVisualStyleBackColor = false;
            this.BackToMenubutton.Click += new System.EventHandler(this.BackToMenubutton_Click);
            // 
            // NewGamebutton
            // 
            this.NewGamebutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NewGamebutton.ForeColor = System.Drawing.Color.Black;
            this.NewGamebutton.Location = new System.Drawing.Point(79, 97);
            this.NewGamebutton.Name = "NewGamebutton";
            this.NewGamebutton.Size = new System.Drawing.Size(91, 23);
            this.NewGamebutton.TabIndex = 1;
            this.NewGamebutton.Text = "Нова игра";
            this.NewGamebutton.UseVisualStyleBackColor = false;
            this.NewGamebutton.Click += new System.EventHandler(this.NewGamebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вие спечелихте";
            // 
            // Rewardlabel
            // 
            this.Rewardlabel.AutoSize = true;
            this.Rewardlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Rewardlabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rewardlabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Rewardlabel.Location = new System.Drawing.Point(101, 57);
            this.Rewardlabel.Name = "Rewardlabel";
            this.Rewardlabel.Size = new System.Drawing.Size(46, 24);
            this.Rewardlabel.TabIndex = 3;
            this.Rewardlabel.Text = "ЛВ.";
            this.Rewardlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuizEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(249, 169);
            this.Controls.Add(this.Rewardlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewGamebutton);
            this.Controls.Add(this.BackToMenubutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizEndGame";
            this.Text = "Край на играта";
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
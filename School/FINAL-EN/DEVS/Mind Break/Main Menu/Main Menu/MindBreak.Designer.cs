namespace Mind_Break
{
    partial class MindBreak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MindBreak));
            this.aboutButton = new System.Windows.Forms.Button();
            this.sudokuButton = new System.Windows.Forms.Button();
            this.snakeButton = new System.Windows.Forms.Button();
            this.puzzleButton = new System.Windows.Forms.Button();
            this.hangmanButton = new System.Windows.Forms.Button();
            this.Minesweeperbutton = new System.Windows.Forms.Button();
            this.BeMillionairebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aboutButton
            // 
            resources.ApplyResources(this.aboutButton, "aboutButton");
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            this.aboutButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.aboutButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // sudokuButton
            // 
            resources.ApplyResources(this.sudokuButton, "sudokuButton");
            this.sudokuButton.Name = "sudokuButton";
            this.sudokuButton.UseVisualStyleBackColor = true;
            this.sudokuButton.Click += new System.EventHandler(this.sudokuButton_Click);
            this.sudokuButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.sudokuButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // snakeButton
            // 
            resources.ApplyResources(this.snakeButton, "snakeButton");
            this.snakeButton.Name = "snakeButton";
            this.snakeButton.UseVisualStyleBackColor = true;
            this.snakeButton.Click += new System.EventHandler(this.snakeButton_Click);
            this.snakeButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.snakeButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // puzzleButton
            // 
            resources.ApplyResources(this.puzzleButton, "puzzleButton");
            this.puzzleButton.Name = "puzzleButton";
            this.puzzleButton.UseVisualStyleBackColor = true;
            this.puzzleButton.Click += new System.EventHandler(this.puzzleButton_Click);
            this.puzzleButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.puzzleButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // hangmanButton
            // 
            resources.ApplyResources(this.hangmanButton, "hangmanButton");
            this.hangmanButton.Name = "hangmanButton";
            this.hangmanButton.UseVisualStyleBackColor = true;
            this.hangmanButton.Click += new System.EventHandler(this.hangmanButton_Click);
            this.hangmanButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.hangmanButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // Minesweeperbutton
            // 
            resources.ApplyResources(this.Minesweeperbutton, "Minesweeperbutton");
            this.Minesweeperbutton.Name = "Minesweeperbutton";
            this.Minesweeperbutton.UseVisualStyleBackColor = true;
            this.Minesweeperbutton.Click += new System.EventHandler(this.Minesweeperbutton_Click);
            // 
            // BeMillionairebutton
            // 
            resources.ApplyResources(this.BeMillionairebutton, "BeMillionairebutton");
            this.BeMillionairebutton.Name = "BeMillionairebutton";
            this.BeMillionairebutton.UseVisualStyleBackColor = true;
            this.BeMillionairebutton.Click += new System.EventHandler(this.BeMillionairebutton_Click);
            // 
            // MindBreak
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.BeMillionairebutton);
            this.Controls.Add(this.Minesweeperbutton);
            this.Controls.Add(this.sudokuButton);
            this.Controls.Add(this.snakeButton);
            this.Controls.Add(this.puzzleButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.hangmanButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MindBreak";
            this.Activated += new System.EventHandler(this.MainMenu_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button snakeButton;
        private System.Windows.Forms.Button puzzleButton;
        private System.Windows.Forms.Button hangmanButton;
        private System.Windows.Forms.Button sudokuButton;
        private System.Windows.Forms.Button Minesweeperbutton;
        private System.Windows.Forms.Button BeMillionairebutton;
    }
}


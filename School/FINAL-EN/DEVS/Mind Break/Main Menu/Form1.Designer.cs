namespace Mind_Break
{
    partial class Form1
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
            this.CGButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.CGpanel = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.snakeButton = new System.Windows.Forms.Button();
            this.numGameButton = new System.Windows.Forms.Button();
            this.pingpongButton = new System.Windows.Forms.Button();
            this.tictactoeButton = new System.Windows.Forms.Button();
            this.killmoleButton = new System.Windows.Forms.Button();
            this.puzzleButton = new System.Windows.Forms.Button();
            this.hangmanButton = new System.Windows.Forms.Button();
            this.CGScrollBar = new System.Windows.Forms.VScrollBar();
            this.CG_MovablePanel = new System.Windows.Forms.Panel();
            this.CGpanel.SuspendLayout();
            this.CG_MovablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CGButton
            // 
            this.CGButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CGButton.Location = new System.Drawing.Point(12, 12);
            this.CGButton.Name = "CGButton";
            this.CGButton.Size = new System.Drawing.Size(120, 60);
            this.CGButton.TabIndex = 0;
            this.CGButton.Text = "Избери Игра";
            this.CGButton.UseVisualStyleBackColor = true;
            this.CGButton.Click += new System.EventHandler(this.CGButton_Click);
            this.CGButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.CGButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutButton.Location = new System.Drawing.Point(12, 78);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(120, 60);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "Отностно приложението";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            this.aboutButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.aboutButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(12, 144);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 60);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Изход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // CGpanel
            // 
            this.CGpanel.Controls.Add(this.button11);
            this.CGpanel.Controls.Add(this.snakeButton);
            this.CGpanel.Controls.Add(this.numGameButton);
            this.CGpanel.Controls.Add(this.pingpongButton);
            this.CGpanel.Controls.Add(this.tictactoeButton);
            this.CGpanel.Controls.Add(this.killmoleButton);
            this.CGpanel.Controls.Add(this.puzzleButton);
            this.CGpanel.Controls.Add(this.hangmanButton);
            this.CGpanel.Location = new System.Drawing.Point(3, 3);
            this.CGpanel.Name = "CGpanel";
            this.CGpanel.Size = new System.Drawing.Size(215, 105);
            this.CGpanel.TabIndex = 3;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(109, 154);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 50);
            this.button11.TabIndex = 7;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.button11.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // snakeButton
            // 
            this.snakeButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snakeButton.Location = new System.Drawing.Point(3, 154);
            this.snakeButton.Name = "snakeButton";
            this.snakeButton.Size = new System.Drawing.Size(100, 50);
            this.snakeButton.TabIndex = 6;
            this.snakeButton.Text = "Змия";
            this.snakeButton.UseVisualStyleBackColor = true;
            this.snakeButton.Click += new System.EventHandler(this.snakeButton_Click);
            this.snakeButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.snakeButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // numGameButton
            // 
            this.numGameButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numGameButton.Location = new System.Drawing.Point(109, 104);
            this.numGameButton.Name = "numGameButton";
            this.numGameButton.Size = new System.Drawing.Size(100, 50);
            this.numGameButton.TabIndex = 5;
            this.numGameButton.Text = "Подреди числата";
            this.numGameButton.UseVisualStyleBackColor = true;
            this.numGameButton.Click += new System.EventHandler(this.numGameButton_Click);
            this.numGameButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.numGameButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // pingpongButton
            // 
            this.pingpongButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pingpongButton.Location = new System.Drawing.Point(110, 54);
            this.pingpongButton.Name = "pingpongButton";
            this.pingpongButton.Size = new System.Drawing.Size(100, 50);
            this.pingpongButton.TabIndex = 4;
            this.pingpongButton.Text = "Тенис на маса";
            this.pingpongButton.UseVisualStyleBackColor = true;
            this.pingpongButton.Click += new System.EventHandler(this.pingpongButton_Click);
            this.pingpongButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.pingpongButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // tictactoeButton
            // 
            this.tictactoeButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tictactoeButton.Location = new System.Drawing.Point(110, 4);
            this.tictactoeButton.Name = "tictactoeButton";
            this.tictactoeButton.Size = new System.Drawing.Size(100, 50);
            this.tictactoeButton.TabIndex = 3;
            this.tictactoeButton.Text = "Морски шах";
            this.tictactoeButton.UseVisualStyleBackColor = true;
            this.tictactoeButton.Click += new System.EventHandler(this.tictactoeButton_Click);
            this.tictactoeButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.tictactoeButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // killmoleButton
            // 
            this.killmoleButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.killmoleButton.Location = new System.Drawing.Point(3, 104);
            this.killmoleButton.Name = "killmoleButton";
            this.killmoleButton.Size = new System.Drawing.Size(100, 50);
            this.killmoleButton.TabIndex = 2;
            this.killmoleButton.Text = "Уцели къртицата";
            this.killmoleButton.UseVisualStyleBackColor = true;
            this.killmoleButton.Click += new System.EventHandler(this.killmoleButton_Click);
            this.killmoleButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.killmoleButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // puzzleButton
            // 
            this.puzzleButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.puzzleButton.Location = new System.Drawing.Point(4, 54);
            this.puzzleButton.Name = "puzzleButton";
            this.puzzleButton.Size = new System.Drawing.Size(100, 50);
            this.puzzleButton.TabIndex = 1;
            this.puzzleButton.Text = "Редене на пъзел";
            this.puzzleButton.UseVisualStyleBackColor = true;
            this.puzzleButton.Click += new System.EventHandler(this.puzzleButton_Click);
            this.puzzleButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.puzzleButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // hangmanButton
            // 
            this.hangmanButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hangmanButton.Location = new System.Drawing.Point(4, 4);
            this.hangmanButton.Name = "hangmanButton";
            this.hangmanButton.Size = new System.Drawing.Size(100, 50);
            this.hangmanButton.TabIndex = 0;
            this.hangmanButton.Text = "Бесеница";
            this.hangmanButton.UseVisualStyleBackColor = true;
            this.hangmanButton.Click += new System.EventHandler(this.hangmanButton_Click);
            this.hangmanButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.hangmanButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // CGScrollBar
            // 
            this.CGScrollBar.Location = new System.Drawing.Point(221, 3);
            this.CGScrollBar.Maximum = 120;
            this.CGScrollBar.Name = "CGScrollBar";
            this.CGScrollBar.Size = new System.Drawing.Size(23, 104);
            this.CGScrollBar.SmallChange = 5;
            this.CGScrollBar.TabIndex = 8;
            this.CGScrollBar.ValueChanged += new System.EventHandler(this.CGScrollBar_ValueChanged);
            // 
            // CG_MovablePanel
            // 
            this.CG_MovablePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CG_MovablePanel.Controls.Add(this.CGpanel);
            this.CG_MovablePanel.Controls.Add(this.CGScrollBar);
            this.CG_MovablePanel.Location = new System.Drawing.Point(330, 12);
            this.CG_MovablePanel.Name = "CG_MovablePanel";
            this.CG_MovablePanel.Size = new System.Drawing.Size(250, 115);
            this.CG_MovablePanel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(304, 341);
            this.Controls.Add(this.CG_MovablePanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.CGButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Главно Меню";
            this.CGpanel.ResumeLayout(false);
            this.CG_MovablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CGButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel CGpanel;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button snakeButton;
        private System.Windows.Forms.Button numGameButton;
        private System.Windows.Forms.Button pingpongButton;
        private System.Windows.Forms.Button tictactoeButton;
        private System.Windows.Forms.Button killmoleButton;
        private System.Windows.Forms.Button puzzleButton;
        private System.Windows.Forms.Button hangmanButton;
        private System.Windows.Forms.VScrollBar CGScrollBar;
        private System.Windows.Forms.Panel CG_MovablePanel;
    }
}


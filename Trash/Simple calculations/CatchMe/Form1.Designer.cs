namespace CatchMe
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
            this.components = new System.ComponentModel.Container();
            this.CatchMeButton = new System.Windows.Forms.Button();
            this.buttonSpawner = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CatchMeButton
            // 
            this.CatchMeButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatchMeButton.Location = new System.Drawing.Point(12, 12);
            this.CatchMeButton.Name = "CatchMeButton";
            this.CatchMeButton.Size = new System.Drawing.Size(109, 64);
            this.CatchMeButton.TabIndex = 0;
            this.CatchMeButton.Text = "Catch Me!!!";
            this.CatchMeButton.UseVisualStyleBackColor = true;
            this.CatchMeButton.Click += new System.EventHandler(this.CatchMeButton_Click);
            this.CatchMeButton.MouseEnter += new System.EventHandler(this.CatchMeButton_MouseEnter);
            // 
            // buttonSpawner
            // 
            this.buttonSpawner.Enabled = true;
            this.buttonSpawner.Interval = 200;
            this.buttonSpawner.Tick += new System.EventHandler(this.buttonSpawner_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CatchMeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CatchMeTheGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CatchMeButton;
        private System.Windows.Forms.Timer buttonSpawner;
    }
}


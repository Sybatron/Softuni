using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace ReflectionIT.Minesweeper
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MinesweeperForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private Game _game;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Label labelBombs;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem êúìÌåíþòîToolStripMenuItem;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MinesweeperForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinesweeperForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelBombs = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.êúìÌåíþòîToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(16, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 224);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(84, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.Black;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(211, 33);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(56, 23);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "0";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBombs
            // 
            this.labelBombs.BackColor = System.Drawing.Color.Black;
            this.labelBombs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBombs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBombs.ForeColor = System.Drawing.Color.Red;
            this.labelBombs.Location = new System.Drawing.Point(16, 33);
            this.labelBombs.Name = "labelBombs";
            this.labelBombs.Size = new System.Drawing.Size(56, 23);
            this.labelBombs.TabIndex = 3;
            this.labelBombs.Text = "0";
            this.labelBombs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.êúìÌåíþòîToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(288, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // êúìÌåíþòîToolStripMenuItem
            // 
            this.êúìÌåíþòîToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.êúìÌåíþòîToolStripMenuItem.Name = "êúìÌåíþòîToolStripMenuItem";
            this.êúìÌåíþòîToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.êúìÌåíþòîToolStripMenuItem.Text = "Back to menu";
            this.êúìÌåíþòîToolStripMenuItem.Click += new System.EventHandler(this.êúìÌåíþòîToolStripMenuItem_Click);
            // 
            // MinesweeperForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(288, 302);
            this.Controls.Add(this.labelBombs);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MinesweeperForm";
            this.Text = "Minesweeper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MinesweeperForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MinesweeperForm());
		}

		private void button1_Click(object sender, System.EventArgs e) {
			Cursor.Current = Cursors.WaitCursor;
			_game = new Game(this.panel1, 10, 10, 10);
			_game.Tick += new EventHandler(GameTick);
			_game.DismantledMinesChanged += new EventHandler(GameDismantledMinesChanged);
			_game.Start();
		}

		private void GameTick(object sender, EventArgs e) {
			labelTime.Text = _game.Time.ToString();
		}

		private void GameDismantledMinesChanged(object sender, EventArgs e) {
			labelBombs.Text = (_game.Mines - _game.DismantledMines).ToString();
		}

        private void êúìÌåíþòîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(".\\TEXT\\isClosing.txt", "false");
            Application.Restart();
        }

        private void MinesweeperForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Application.Exit();
        }
	}
}

namespace WindowsFormsApp2
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
            this.DataGrades = new System.Windows.Forms.DataGridView();
            this.SumUp = new System.Windows.Forms.Button();
            this.RowLabel = new System.Windows.Forms.Label();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.DataSpr = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Two = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Three = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Four = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Five = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Six = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgGradesDataSpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDataGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BelDataGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MathDataGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheDataGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INFDataGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITDataGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISTDataGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GEODataGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgGradesDataGrades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSpr)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrades
            // 
            this.DataGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameDataGrades,
            this.BelDataGrades,
            this.MathDataGrades,
            this.CheDataGrades,
            this.INFDataGrades,
            this.ITDataGrades,
            this.ISTDataGrades,
            this.GEODataGrades,
            this.AvgGradesDataGrades});
            this.DataGrades.Location = new System.Drawing.Point(12, 12);
            this.DataGrades.Name = "DataGrades";
            this.DataGrades.Size = new System.Drawing.Size(465, 258);
            this.DataGrades.TabIndex = 0;
            this.DataGrades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrades_CellClick);
            // 
            // SumUp
            // 
            this.SumUp.Location = new System.Drawing.Point(402, 276);
            this.SumUp.Name = "SumUp";
            this.SumUp.Size = new System.Drawing.Size(75, 23);
            this.SumUp.TabIndex = 1;
            this.SumUp.Text = "Изчисли";
            this.SumUp.UseVisualStyleBackColor = true;
            this.SumUp.Click += new System.EventHandler(this.SumUp_Click);
            // 
            // RowLabel
            // 
            this.RowLabel.AutoSize = true;
            this.RowLabel.Location = new System.Drawing.Point(12, 273);
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(32, 13);
            this.RowLabel.TabIndex = 2;
            this.RowLabel.Text = "Ред: ";
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Location = new System.Drawing.Point(12, 297);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(47, 13);
            this.ColumnLabel.TabIndex = 4;
            this.ColumnLabel.Text = "Колона:";
            // 
            // DataSpr
            // 
            this.DataSpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSpr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.Two,
            this.Three,
            this.Four,
            this.Five,
            this.Six,
            this.AvgGradesDataSpr});
            this.DataSpr.Location = new System.Drawing.Point(483, 12);
            this.DataSpr.Name = "DataSpr";
            this.DataSpr.Size = new System.Drawing.Size(470, 258);
            this.DataSpr.TabIndex = 5;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Предмет";
            this.Subject.Name = "Subject";
            // 
            // Two
            // 
            this.Two.HeaderText = "2";
            this.Two.Name = "Two";
            this.Two.Width = 50;
            // 
            // Three
            // 
            this.Three.HeaderText = "3";
            this.Three.Name = "Three";
            this.Three.Width = 50;
            // 
            // Four
            // 
            this.Four.HeaderText = "4";
            this.Four.Name = "Four";
            this.Four.Width = 50;
            // 
            // Five
            // 
            this.Five.HeaderText = "5";
            this.Five.Name = "Five";
            this.Five.Width = 50;
            // 
            // Six
            // 
            this.Six.HeaderText = "6";
            this.Six.Name = "Six";
            this.Six.Width = 50;
            // 
            // AvgGradesDataSpr
            // 
            this.AvgGradesDataSpr.HeaderText = "Ср.Успех";
            this.AvgGradesDataSpr.Name = "AvgGradesDataSpr";
            this.AvgGradesDataSpr.Width = 60;
            // 
            // NameDataGrades
            // 
            this.NameDataGrades.HeaderText = "Име";
            this.NameDataGrades.Name = "NameDataGrades";
            this.NameDataGrades.Width = 60;
            // 
            // BelDataGrades
            // 
            this.BelDataGrades.HeaderText = "БЕЛ";
            this.BelDataGrades.Name = "BelDataGrades";
            this.BelDataGrades.Width = 40;
            // 
            // MathDataGrades
            // 
            this.MathDataGrades.HeaderText = "МАТ";
            this.MathDataGrades.Name = "MathDataGrades";
            this.MathDataGrades.Width = 40;
            // 
            // CheDataGrades
            // 
            this.CheDataGrades.FillWeight = 30F;
            this.CheDataGrades.HeaderText = "ЧЕ";
            this.CheDataGrades.Name = "CheDataGrades";
            this.CheDataGrades.Width = 40;
            // 
            // INFDataGrades
            // 
            this.INFDataGrades.HeaderText = "ИНФ";
            this.INFDataGrades.Name = "INFDataGrades";
            this.INFDataGrades.Width = 40;
            // 
            // ITDataGrades
            // 
            this.ITDataGrades.HeaderText = "ИТ";
            this.ITDataGrades.Name = "ITDataGrades";
            this.ITDataGrades.Width = 40;
            // 
            // ISTDataGrades
            // 
            this.ISTDataGrades.HeaderText = "ИСТ";
            this.ISTDataGrades.Name = "ISTDataGrades";
            this.ISTDataGrades.Width = 40;
            // 
            // GEODataGrades
            // 
            this.GEODataGrades.HeaderText = "ГЕО";
            this.GEODataGrades.Name = "GEODataGrades";
            this.GEODataGrades.Width = 40;
            // 
            // AvgGradesDataGrades
            // 
            this.AvgGradesDataGrades.HeaderText = "Ср.Успех";
            this.AvgGradesDataGrades.Name = "AvgGradesDataGrades";
            this.AvgGradesDataGrades.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 398);
            this.Controls.Add(this.DataSpr);
            this.Controls.Add(this.ColumnLabel);
            this.Controls.Add(this.RowLabel);
            this.Controls.Add(this.SumUp);
            this.Controls.Add(this.DataGrades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSpr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrades;
        private System.Windows.Forms.Button SumUp;
        private System.Windows.Forms.Label RowLabel;
        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.DataGridView DataSpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Two;
        private System.Windows.Forms.DataGridViewTextBoxColumn Three;
        private System.Windows.Forms.DataGridViewTextBoxColumn Four;
        private System.Windows.Forms.DataGridViewTextBoxColumn Five;
        private System.Windows.Forms.DataGridViewTextBoxColumn Six;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgGradesDataSpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDataGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn BelDataGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn MathDataGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheDataGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn INFDataGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITDataGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISTDataGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn GEODataGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgGradesDataGrades;
    }
}


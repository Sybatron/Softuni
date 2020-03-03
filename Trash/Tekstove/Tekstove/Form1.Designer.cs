namespace WindowsFormsApplication1
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
            this.doIt = new System.Windows.Forms.Button();
            this.radioLower = new System.Windows.Forms.RadioButton();
            this.radioUpper = new System.Windows.Forms.RadioButton();
            this.radioCount = new System.Windows.Forms.RadioButton();
            this.radioSearch = new System.Windows.Forms.RadioButton();
            this.radioReplace = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.replace = new System.Windows.Forms.TextBox();
            this.countSav = new System.Windows.Forms.Label();
            this.countDum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doIt
            // 
            this.doIt.Location = new System.Drawing.Point(378, 167);
            this.doIt.Name = "doIt";
            this.doIt.Size = new System.Drawing.Size(75, 23);
            this.doIt.TabIndex = 0;
            this.doIt.Text = "Извърши";
            this.doIt.UseVisualStyleBackColor = true;
            this.doIt.Click += new System.EventHandler(this.doIt_Click);
            // 
            // radioLower
            // 
            this.radioLower.AutoSize = true;
            this.radioLower.Location = new System.Drawing.Point(378, 28);
            this.radioLower.Name = "radioLower";
            this.radioLower.Size = new System.Drawing.Size(90, 17);
            this.radioLower.TabIndex = 1;
            this.radioLower.TabStop = true;
            this.radioLower.Text = "Малки букви";
            this.radioLower.UseVisualStyleBackColor = true;
            // 
            // radioUpper
            // 
            this.radioUpper.AutoSize = true;
            this.radioUpper.Location = new System.Drawing.Point(378, 52);
            this.radioUpper.Name = "radioUpper";
            this.radioUpper.Size = new System.Drawing.Size(95, 17);
            this.radioUpper.TabIndex = 2;
            this.radioUpper.TabStop = true;
            this.radioUpper.Text = "Големи букви";
            this.radioUpper.UseVisualStyleBackColor = true;
            // 
            // radioCount
            // 
            this.radioCount.AutoSize = true;
            this.radioCount.Location = new System.Drawing.Point(378, 93);
            this.radioCount.Name = "radioCount";
            this.radioCount.Size = new System.Drawing.Size(78, 17);
            this.radioCount.TabIndex = 3;
            this.radioCount.TabStop = true;
            this.radioCount.Text = "Брой думи";
            this.radioCount.UseVisualStyleBackColor = true;
            // 
            // radioSearch
            // 
            this.radioSearch.AutoSize = true;
            this.radioSearch.Location = new System.Drawing.Point(378, 117);
            this.radioSearch.Name = "radioSearch";
            this.radioSearch.Size = new System.Drawing.Size(85, 17);
            this.radioSearch.TabIndex = 4;
            this.radioSearch.TabStop = true;
            this.radioSearch.Text = "Част от низ";
            this.radioSearch.UseVisualStyleBackColor = true;
            // 
            // radioReplace
            // 
            this.radioReplace.AutoSize = true;
            this.radioReplace.Location = new System.Drawing.Point(378, 141);
            this.radioReplace.Name = "radioReplace";
            this.radioReplace.Size = new System.Drawing.Size(100, 17);
            this.radioReplace.TabIndex = 5;
            this.radioReplace.TabStop = true;
            this.radioReplace.Text = "Замяна на низ";
            this.radioReplace.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 186);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(97, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Брой Съвпадения";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(16, 33);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(274, 20);
            this.input.TabIndex = 7;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(16, 111);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(270, 20);
            this.search.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Резултат:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Въведете низ:";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.Info;
            this.output.Location = new System.Drawing.Point(16, 72);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(270, 20);
            this.output.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Низ за търсене";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Низ за заместване";
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(16, 150);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(270, 20);
            this.replace.TabIndex = 15;
            // 
            // countSav
            // 
            this.countSav.AutoSize = true;
            this.countSav.Location = new System.Drawing.Point(116, 186);
            this.countSav.Name = "countSav";
            this.countSav.Size = new System.Drawing.Size(35, 13);
            this.countSav.TabIndex = 16;
            this.countSav.Text = "label1";
            // 
            // countDum
            // 
            this.countDum.AutoSize = true;
            this.countDum.Location = new System.Drawing.Point(116, 211);
            this.countDum.Name = "countDum";
            this.countDum.Size = new System.Drawing.Size(35, 13);
            this.countDum.TabIndex = 18;
            this.countDum.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Брой Думи";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 245);
            this.Controls.Add(this.countDum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.countSav);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label);
            this.Controls.Add(this.radioReplace);
            this.Controls.Add(this.radioSearch);
            this.Controls.Add(this.radioCount);
            this.Controls.Add(this.radioUpper);
            this.Controls.Add(this.radioLower);
            this.Controls.Add(this.doIt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Низове";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doIt;
        private System.Windows.Forms.RadioButton radioLower;
        private System.Windows.Forms.RadioButton radioUpper;
        private System.Windows.Forms.RadioButton radioCount;
        private System.Windows.Forms.RadioButton radioSearch;
        private System.Windows.Forms.RadioButton radioReplace;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox replace;
        private System.Windows.Forms.Label countSav;
        private System.Windows.Forms.Label countDum;
        private System.Windows.Forms.Label label6;
    }
}


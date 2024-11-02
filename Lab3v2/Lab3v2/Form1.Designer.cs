﻿namespace Lab3v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelMenuTitle = new Label();
            buttonLearn = new Button();
            buttonTest = new Button();
            buttonWords = new Button();
            checkBoxReverse = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonQuit = new Button();
            buttonHistory = new Button();
            SuspendLayout();
            // 
            // labelMenuTitle
            // 
            labelMenuTitle.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenuTitle.Location = new Point(299, 45);
            labelMenuTitle.Name = "labelMenuTitle";
            labelMenuTitle.Size = new Size(162, 37);
            labelMenuTitle.TabIndex = 0;
            labelMenuTitle.Text = "Learn English";
            labelMenuTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLearn
            // 
            buttonLearn.BackColor = Color.FromArgb(254, 202, 87);
            buttonLearn.FlatAppearance.BorderSize = 0;
            buttonLearn.FlatStyle = FlatStyle.Flat;
            buttonLearn.Font = new Font("Segoe UI", 13.8F);
            buttonLearn.ForeColor = Color.Snow;
            buttonLearn.Location = new Point(284, 94);
            buttonLearn.Name = "buttonLearn";
            buttonLearn.Size = new Size(177, 70);
            buttonLearn.TabIndex = 1;
            buttonLearn.Text = " Learn";
            buttonLearn.UseVisualStyleBackColor = false;
            buttonLearn.Click += buttonLearn_Click;
            // 
            // buttonTest
            // 
            buttonTest.BackColor = Color.FromArgb(75, 123, 236);
            buttonTest.FlatAppearance.BorderSize = 0;
            buttonTest.FlatStyle = FlatStyle.Flat;
            buttonTest.Font = new Font("Segoe UI", 13.8F);
            buttonTest.ForeColor = SystemColors.ButtonHighlight;
            buttonTest.Location = new Point(284, 170);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(177, 70);
            buttonTest.TabIndex = 2;
            buttonTest.Text = "Test";
            buttonTest.UseVisualStyleBackColor = false;
            buttonTest.Click += buttonTest_Click;
            // 
            // buttonWords
            // 
            buttonWords.BackColor = Color.FromArgb(255, 159, 243);
            buttonWords.FlatAppearance.BorderSize = 0;
            buttonWords.FlatStyle = FlatStyle.Flat;
            buttonWords.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonWords.ForeColor = SystemColors.ButtonHighlight;
            buttonWords.Location = new Point(611, 216);
            buttonWords.Name = "buttonWords";
            buttonWords.Size = new Size(177, 70);
            buttonWords.TabIndex = 3;
            buttonWords.Text = "Dictionary";
            buttonWords.UseVisualStyleBackColor = false;
            buttonWords.Click += buttonWords_Click;
            // 
            // checkBoxReverse
            // 
            checkBoxReverse.AutoSize = true;
            checkBoxReverse.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            checkBoxReverse.Location = new Point(622, 12);
            checkBoxReverse.Name = "checkBoxReverse";
            checkBoxReverse.Size = new Size(166, 25);
            checkBoxReverse.TabIndex = 4;
            checkBoxReverse.Text = "english -> polish";
            checkBoxReverse.UseVisualStyleBackColor = true;
            // 
            // buttonQuit
            // 
            buttonQuit.BackColor = Color.FromArgb(255, 107, 107);
            buttonQuit.FlatAppearance.BorderSize = 0;
            buttonQuit.FlatStyle = FlatStyle.Flat;
            buttonQuit.Font = new Font("Segoe UI", 13.8F);
            buttonQuit.ForeColor = SystemColors.ButtonHighlight;
            buttonQuit.Location = new Point(611, 368);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(177, 70);
            buttonQuit.TabIndex = 5;
            buttonQuit.Text = "Quit";
            buttonQuit.UseVisualStyleBackColor = false;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // buttonHistory
            // 
            buttonHistory.BackColor = Color.FromArgb(15, 185, 177);
            buttonHistory.FlatAppearance.BorderSize = 0;
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonHistory.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonHistory.ForeColor = SystemColors.ButtonHighlight;
            buttonHistory.Location = new Point(611, 292);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(177, 70);
            buttonHistory.TabIndex = 6;
            buttonHistory.Text = "History";
            buttonHistory.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 214, 229);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHistory);
            Controls.Add(buttonQuit);
            Controls.Add(checkBoxReverse);
            Controls.Add(buttonWords);
            Controls.Add(buttonTest);
            Controls.Add(buttonLearn);
            Controls.Add(labelMenuTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenuTitle;
        private Button buttonLearn;
        private Button buttonTest;
        private Button buttonWords;
        private CheckBox checkBoxReverse;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonQuit;
        private Button buttonHistory;
    }
}

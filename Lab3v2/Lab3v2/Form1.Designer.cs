namespace Lab3v2
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
            SuspendLayout();
            // 
            // labelMenuTitle
            // 
            labelMenuTitle.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenuTitle.Location = new Point(314, 55);
            labelMenuTitle.Name = "labelMenuTitle";
            labelMenuTitle.Size = new Size(162, 37);
            labelMenuTitle.TabIndex = 0;
            labelMenuTitle.Text = "Learn English";
            labelMenuTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLearn
            // 
            buttonLearn.Location = new Point(345, 163);
            buttonLearn.Name = "buttonLearn";
            buttonLearn.Size = new Size(94, 29);
            buttonLearn.TabIndex = 1;
            buttonLearn.Text = " Learn";
            buttonLearn.UseVisualStyleBackColor = true;
            buttonLearn.Click += buttonLearn_Click;
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(345, 211);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(94, 29);
            buttonTest.TabIndex = 2;
            buttonTest.Text = "Test";
            buttonTest.UseVisualStyleBackColor = true;
            // 
            // buttonWords
            // 
            buttonWords.Location = new Point(345, 107);
            buttonWords.Name = "buttonWords";
            buttonWords.Size = new Size(94, 29);
            buttonWords.TabIndex = 3;
            buttonWords.Text = "Words";
            buttonWords.UseVisualStyleBackColor = true;
            buttonWords.Click += buttonWords_Click;
            // 
            // checkBoxReverse
            // 
            checkBoxReverse.AutoSize = true;
            checkBoxReverse.Location = new Point(495, 107);
            checkBoxReverse.Name = "checkBoxReverse";
            checkBoxReverse.Size = new Size(142, 24);
            checkBoxReverse.TabIndex = 4;
            checkBoxReverse.Text = "english -> polish";
            checkBoxReverse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxReverse);
            Controls.Add(buttonWords);
            Controls.Add(buttonTest);
            Controls.Add(buttonLearn);
            Controls.Add(labelMenuTitle);
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
    }
}

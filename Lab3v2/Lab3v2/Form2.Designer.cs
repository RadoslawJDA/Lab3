namespace Lab3v2
{
    partial class Form2
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
            labelMenuTitle = new Label();
            labelWord = new Label();
            textBoxAnswer = new TextBox();
            buttonCheck = new Button();
            checkBoxReverse = new CheckBox();
            SuspendLayout();
            // 
            // labelMenuTitle
            // 
            labelMenuTitle.Dock = DockStyle.Top;
            labelMenuTitle.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenuTitle.Location = new Point(0, 0);
            labelMenuTitle.Name = "labelMenuTitle";
            labelMenuTitle.Size = new Size(800, 37);
            labelMenuTitle.TabIndex = 1;
            labelMenuTitle.Text = "Learn";
            labelMenuTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelMenuTitle.Click += labelMenuTitle_Click;
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.Location = new Point(270, 65);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(50, 20);
            labelWord.TabIndex = 2;
            labelWord.Text = "label1";
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Location = new Point(270, 124);
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(125, 27);
            textBoxAnswer.TabIndex = 3;
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(270, 190);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(94, 29);
            buttonCheck.TabIndex = 4;
            buttonCheck.Text = "Check";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // checkBoxReverse
            // 
            checkBoxReverse.AutoSize = true;
            checkBoxReverse.Location = new Point(88, 64);
            checkBoxReverse.Name = "checkBoxReverse";
            checkBoxReverse.Size = new Size(142, 24);
            checkBoxReverse.TabIndex = 5;
            checkBoxReverse.Text = "english -> polish";
            checkBoxReverse.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxReverse);
            Controls.Add(buttonCheck);
            Controls.Add(textBoxAnswer);
            Controls.Add(labelWord);
            Controls.Add(labelMenuTitle);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenuTitle;
        private Label labelWord;
        private TextBox textBoxAnswer;
        private Button buttonCheck;
        private CheckBox checkBoxReverse;
    }
}
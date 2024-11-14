namespace Lab3v2
{
    partial class Test
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
            checkBoxReverse = new CheckBox();
            buttonCheck = new Button();
            textBoxAnswer = new TextBox();
            labelWord = new Label();
            labelCounter = new Label();
            SuspendLayout();
            // 
            // checkBoxReverse
            // 
            checkBoxReverse.AutoSize = true;
            checkBoxReverse.Location = new Point(134, 52);
            checkBoxReverse.Margin = new Padding(3, 2, 3, 2);
            checkBoxReverse.Name = "checkBoxReverse";
            checkBoxReverse.Size = new Size(115, 19);
            checkBoxReverse.TabIndex = 9;
            checkBoxReverse.Text = "english -> polish";
            checkBoxReverse.UseVisualStyleBackColor = true;
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(293, 146);
            buttonCheck.Margin = new Padding(3, 2, 3, 2);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(82, 22);
            buttonCheck.TabIndex = 8;
            buttonCheck.Text = "Check";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click_1;
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Location = new Point(293, 97);
            textBoxAnswer.Margin = new Padding(3, 2, 3, 2);
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(110, 23);
            textBoxAnswer.TabIndex = 7;
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.Location = new Point(293, 53);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(38, 15);
            labelWord.TabIndex = 6;
            labelWord.Text = "label1";
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Location = new Point(38, 27);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(13, 15);
            labelCounter.TabIndex = 10;
            labelCounter.Text = "1";
            labelCounter.Click += labelCounter_Click;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(labelCounter);
            Controls.Add(checkBoxReverse);
            Controls.Add(buttonCheck);
            Controls.Add(textBoxAnswer);
            Controls.Add(labelWord);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Test";
            Text = "Test";
            Load += Test_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxReverse;
        private Button buttonCheck;
        private TextBox textBoxAnswer;
        private Label labelWord;
        private Label labelCounter;
    }
}
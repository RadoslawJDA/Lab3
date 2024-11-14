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
            checkBoxReverse.Font = new Font("Century Gothic", 18F);
            checkBoxReverse.Location = new Point(43, 388);
            checkBoxReverse.Name = "checkBoxReverse";
            checkBoxReverse.Size = new Size(251, 41);
            checkBoxReverse.TabIndex = 9;
            checkBoxReverse.Text = "English > Polish";
            checkBoxReverse.UseVisualStyleBackColor = true;
            // 
            // buttonCheck
            // 
            buttonCheck.BackColor = Color.YellowGreen;
            buttonCheck.FlatAppearance.BorderSize = 0;
            buttonCheck.FlatStyle = FlatStyle.Flat;
            buttonCheck.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonCheck.ForeColor = Color.Cornsilk;
            buttonCheck.Location = new Point(309, 251);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(177, 69);
            buttonCheck.TabIndex = 8;
            buttonCheck.Text = "Check";
            buttonCheck.UseVisualStyleBackColor = false;
            buttonCheck.Click += buttonCheck_Click_1;
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxAnswer.Location = new Point(253, 149);
            textBoxAnswer.Multiline = true;
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(297, 73);
            textBoxAnswer.TabIndex = 7;
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.Font = new Font("Century Gothic", 18F);
            labelWord.Location = new Point(335, 83);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(105, 37);
            labelWord.TabIndex = 6;
            labelWord.Text = "label1";
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelCounter.Location = new Point(12, 9);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(32, 38);
            labelCounter.TabIndex = 10;
            labelCounter.Text = "1";
            labelCounter.Click += labelCounter_Click;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 214, 229);
            ClientSize = new Size(800, 451);
            Controls.Add(labelCounter);
            Controls.Add(checkBoxReverse);
            Controls.Add(buttonCheck);
            Controls.Add(textBoxAnswer);
            Controls.Add(labelWord);
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
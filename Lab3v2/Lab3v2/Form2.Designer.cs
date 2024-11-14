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
            labelMenuTitle.Font = new Font("Sans Serif Collection", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenuTitle.Location = new Point(0, 0);
            labelMenuTitle.Name = "labelMenuTitle";
            labelMenuTitle.Size = new Size(800, 88);
            labelMenuTitle.TabIndex = 1;
            labelMenuTitle.Text = "Learn";
            labelMenuTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelMenuTitle.Click += labelMenuTitle_Click;
            // 
            // labelWord
            // 
            labelWord.AutoSize = true;
            labelWord.Dock = DockStyle.Top;
            labelWord.Font = new Font("Century Gothic", 18F);
            labelWord.Location = new Point(0, 88);
            labelWord.Name = "labelWord";
            labelWord.Size = new Size(105, 37);
            labelWord.TabIndex = 2;
            labelWord.Text = "label1";
            labelWord.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.BorderStyle = BorderStyle.None;
            textBoxAnswer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBoxAnswer.Location = new Point(297, 165);
            textBoxAnswer.Multiline = true;
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(179, 57);
            textBoxAnswer.TabIndex = 3;
            textBoxAnswer.Text = "test";
            // 
            // buttonCheck
            // 
            buttonCheck.BackColor = Color.YellowGreen;
            buttonCheck.FlatAppearance.BorderSize = 0;
            buttonCheck.FlatStyle = FlatStyle.Flat;
            buttonCheck.Font = new Font("Segoe UI", 13.8F);
            buttonCheck.ForeColor = Color.Cornsilk;
            buttonCheck.Location = new Point(297, 277);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(177, 69);
            buttonCheck.TabIndex = 4;
            buttonCheck.Text = "Check";
            buttonCheck.UseVisualStyleBackColor = false;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // checkBoxReverse
            // 
            checkBoxReverse.AutoSize = true;
            checkBoxReverse.Font = new Font("Segoe UI", 18F);
            checkBoxReverse.Location = new Point(536, 393);
            checkBoxReverse.Name = "checkBoxReverse";
            checkBoxReverse.Size = new Size(249, 45);
            checkBoxReverse.TabIndex = 5;
            checkBoxReverse.Text = "English > Polish";
            checkBoxReverse.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 214, 229);
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
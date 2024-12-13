using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3v2
{
    public partial class Form2 : Form
    {
        private Dictionary<string, string> wordDictionary;
        private KeyValuePair<string, string> currentWord;
        private Form1 parentForm;
        public Form2(Dictionary<string, string> dictionary, Form1 parent)
        {
            InitializeComponent();
            wordDictionary = dictionary;
            parentForm = parent;
            LoadNewWord();
        }
        private void LoadNewWord()
        {
            var random = new Random();
            currentWord = wordDictionary.ElementAt(random.Next(wordDictionary.Count));

            // Sprawdzamy stan checkboxa, aby określić kierunek tłumaczenia
            if (checkBoxReverse.Checked)
            {
                // Tryb tłumaczenia angielski -> polski
                labelWord.Text = "Podaj tłumaczenie słowa: " + currentWord.Value;
            }
            else
            {
                // Tryb tłumaczenia polski -> angielski
                labelWord.Text = "Podaj tłumaczenie słowa: " + currentWord.Key;
            }

            textBoxAnswer.Clear();
        }

        private void labelMenuTitle_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string answer = textBoxAnswer.Text.Trim();
            string historyEntry;

            if (checkBoxReverse.Checked)
            {
                if (answer.Equals(currentWord.Key, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Dobrze!", "Wynik");
                    historyEntry = $"{currentWord.Value} -> {currentWord.Key} (poprawnie)";
                }
                else
                {
                    MessageBox.Show($"Błąd. Poprawna odpowiedź to: {currentWord.Key}", "Wynik");
                    historyEntry = $"{currentWord.Value} -> {currentWord.Key} (błędnie: {answer})";
                }
            }
            else
            {
                if (answer.Equals(currentWord.Value, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Dobrze!", "Wynik");
                    historyEntry = $"{currentWord.Key} -> {currentWord.Value} (poprawnie)";
                }
                else
                {
                    MessageBox.Show($"Błąd. Poprawna odpowiedź to: {currentWord.Value}", "Wynik");
                    historyEntry = $"{currentWord.Key} -> {currentWord.Value} (błędnie: {answer})";
                }
            }

            parentForm.AddToHistory(historyEntry); // dodajemy wpis do historii
            LoadNewWord(); // Wczytujemy nowe słowo do przetłumaczenia
        }
    
    }
}

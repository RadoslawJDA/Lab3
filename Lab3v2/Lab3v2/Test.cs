using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Lab3v2
{
    public partial class Test : Form
    {
        private Dictionary<string, string> wordDictionary;
        private List<KeyValuePair<string, string>> testWords; // Lista 10 wylosowanych słów do testu
        private int currentIndex;
        private int correctAnswers;
        private int incorrectAnswers;
        private bool isPolishToEnglish; // Określa kierunek testu
        private KeyValuePair<string, string> currentWord; // Przechowuje aktualne słowo do testu

        public Test(Dictionary<string, string> dictionary)
        {
            InitializeComponent();
            wordDictionary = dictionary;
            testWords = new List<KeyValuePair<string, string>>();
            currentIndex = 0;
            correctAnswers = 0;
            incorrectAnswers = 0;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            // Ustawienie trybu testu na podstawie checkboxa
            isPolishToEnglish = !checkBoxReverse.Checked;

            // Losowanie 10 unikalnych słów do testu
            SelectRandomWords();
            DisplayCurrentWord();
        }
        private void SelectRandomWords()
        {
            // Użycie HashSet do zapewnienia unikalności słów
            var selectedWords = new HashSet<KeyValuePair<string, string>>();
            var random = new Random();

            while (selectedWords.Count < 10 && selectedWords.Count < wordDictionary.Count)
            {
                var word = wordDictionary.ElementAt(random.Next(wordDictionary.Count));
                selectedWords.Add(word);
            }

            testWords = selectedWords.ToList();
        }

        private void DisplayCurrentWord()
        {
            if (currentIndex >= testWords.Count)
            {
                // Koniec testu, wyświetlamy wyniki
                MessageBox.Show($"Test zakończony!\nPoprawne odpowiedzi: {correctAnswers}\nBłędne odpowiedzi: {incorrectAnswers}", "Wyniki");
                this.Close();
                return;
            }

            currentWord = testWords[currentIndex];

            // Aktualizujemy etykietę, aby wyświetlić numer pytania
            labelCounter.Text = $"Pytanie {currentIndex + 1} z 10";

            // Wyświetlamy słowo do przetłumaczenia
            labelWord.Text = isPolishToEnglish ? currentWord.Key : currentWord.Value;
            textBoxAnswer.Clear();
        }


        private void buttonCheck_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxReverse_CheckedChanged(object sender, EventArgs e)
        {
            // Zmiana trybu testu przy zmianie stanu checkboxa
            isPolishToEnglish = !checkBoxReverse.Checked;
            currentIndex = 0;
            correctAnswers = 0;
            incorrectAnswers = 0;
            SelectRandomWords();
            DisplayCurrentWord();
        }

        private void buttonCheck_Click_1(object sender, EventArgs e)
        {
            string answer = textBoxAnswer.Text.Trim();
            string historyEntry;

            bool isCorrect;
            if (isPolishToEnglish)
            {
                isCorrect = answer.Equals(currentWord.Value, StringComparison.OrdinalIgnoreCase);
                historyEntry = $"{currentWord.Value} -> {currentWord.Key} (poprawnie)";
            }
            else
            {
                isCorrect = answer.Equals(currentWord.Key, StringComparison.OrdinalIgnoreCase);
                historyEntry = $"{currentWord.Value} -> {currentWord.Key} (błędnie: {answer})";
            }

            if (isCorrect)
            {
                MessageBox.Show("Dobrze!", "Wynik");
                historyEntry = $"{currentWord.Key} -> {currentWord.Value} (poprawnie)";
                correctAnswers++;
            }
            else
            {
                string correctAnswer = isPolishToEnglish ? currentWord.Value : currentWord.Key;
                MessageBox.Show($"Błąd. Poprawna odpowiedź to: {correctAnswer}", "Wynik");
                historyEntry = $"{currentWord.Key} -> {currentWord.Value} (błędnie: {answer})";
                incorrectAnswers++;
            }

            currentIndex++;
            DisplayCurrentWord(); // Przechodzimy do następnego słowa
        }

        private void labelCounter_Click(object sender, EventArgs e)
        {

        }
    }
}

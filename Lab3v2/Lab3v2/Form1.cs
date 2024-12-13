namespace Lab3v2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> wordDictionary;
        private Queue<string> translationHistory;
        public Form1()
        {
            InitializeComponent();

            // Inicjalizacja s³ownika z 15 s³owami
            wordDictionary = new Dictionary<string, string>
            {
                {"kot", "cat"},
                {"pies", "dog"},
                {"dom", "house"},
                {"samochód", "car"},
                {"zabójca", "killer"},
                {"ksi¹¿ka", "book"},
                {"krzes³o", "chair"},
                {"stó³", "table"},
                {"drzewo", "tree"},
                {"kwiat", "flower"},
                {"s³oñce", "sun"},
                {"ksiê¿yc", "moon"},
                {"morze", "sea"},
                {"jezioro", "lake"},
                {"góry", "mountains"},
                {"miasto", "city"},
                {"wioska", "village"}
            };

            translationHistory = new Queue<string>();
        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(wordDictionary, this); // Przekazujemy 'this' jako referencjê do Form1
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void buttonWords_Click(object sender, EventArgs e)
        {
            string result;

            // Sprawdzamy stan checkboxa, aby okreœliæ kierunek t³umaczenia i sortowania
            if (checkBoxReverse.Checked)
            {
                result = "Angielskie -> Polskie:\n";
                // Sortowanie po angielskich s³owach i wyœwietlanie
                var sortedWords = wordDictionary.OrderBy(x => x.Value);
                foreach (var word in sortedWords)
                {
                    result += $"{word.Value} - {word.Key}\n";
                }
            }
            else
            {
                result = "Polskie -> Angielskie:\n";
                // Sortowanie po polskich s³owach i wyœwietlanie
                var sortedWords = wordDictionary.OrderBy(x => x.Key);
                foreach (var word in sortedWords)
                {
                    result += $"{word.Key} - {word.Value}\n";
                }
            }

            MessageBox.Show(result, "Lista S³ów");
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test test = new Test(wordDictionary);
            test.ShowDialog();
            test = null;
            this.Show();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            if (translationHistory.Count > 0)
            {
                string history = string.Join("\n", translationHistory);
                MessageBox.Show(history, "Historia T³umaczeñ");
            }
            else
            {
                MessageBox.Show("Brak historii t³umaczeñ.", "Historia T³umaczeñ");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string polishWord = Microsoft.VisualBasic.Interaction.InputBox("Podaj polskie s³owo:", "Dodaj s³owo", "");
            string englishWord = Microsoft.VisualBasic.Interaction.InputBox("Podaj angielskie t³umaczenie:", "Dodaj t³umaczenie", "");

            if (!string.IsNullOrWhiteSpace(polishWord) && !string.IsNullOrWhiteSpace(englishWord))
            {
                if (!wordDictionary.ContainsKey(polishWord))
                {
                    wordDictionary.Add(polishWord, englishWord);
                    MessageBox.Show("S³owo dodane pomyœlnie.", "Dodawanie s³ów");
                }
                else
                {
                    MessageBox.Show("To s³owo ju¿ istnieje w s³owniku.", "B³¹d");
                }
            }
            else
            {
                MessageBox.Show("Oba pola musz¹ byæ wype³nione.", "B³¹d");
            }
        }

        // Dodawanie wpisu do historii (przyk³ad wywo³ania w kodzie Form2)
        public void AddToHistory(string entry)
        {
            if (translationHistory.Count >= 10) // ograniczenie historii do 10 ostatnich t³umaczeñ
            {
                translationHistory.Dequeue();
            }
            translationHistory.Enqueue(entry);
        }
    }
}

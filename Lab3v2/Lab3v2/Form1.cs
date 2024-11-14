namespace Lab3v2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> wordDictionary;
        private Queue<string> translationHistory;
        public Form1()
        {
            InitializeComponent();

            // Inicjalizacja s�ownika z 15 s�owami
            wordDictionary = new Dictionary<string, string>
            {
                {"kot", "cat"},
                {"pies", "dog"},
                {"dom", "house"},
                {"samoch�d", "car"},
                {"zab�jca", "killer"},
                {"ksi��ka", "book"},
                {"krzes�o", "chair"},
                {"st�", "table"},
                {"drzewo", "tree"},
                {"kwiat", "flower"},
                {"s�o�ce", "sun"},
                {"ksi�yc", "moon"},
                {"morze", "sea"},
                {"jezioro", "lake"},
                {"g�ry", "mountains"},
                {"miasto", "city"},
                {"wioska", "village"}
            };

            translationHistory = new Queue<string>();
        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(wordDictionary, this); // Przekazujemy 'this' jako referencj� do Form1
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }

        private void buttonWords_Click(object sender, EventArgs e)
        {
            string result;

            // Sprawdzamy stan checkboxa, aby okre�li� kierunek t�umaczenia i sortowania
            if (checkBoxReverse.Checked)
            {
                result = "Angielskie -> Polskie:\n";
                // Sortowanie po angielskich s�owach i wy�wietlanie
                var sortedWords = wordDictionary.OrderBy(x => x.Value);
                foreach (var word in sortedWords)
                {
                    result += $"{word.Value} - {word.Key}\n";
                }
            }
            else
            {
                result = "Polskie -> Angielskie:\n";
                // Sortowanie po polskich s�owach i wy�wietlanie
                var sortedWords = wordDictionary.OrderBy(x => x.Key);
                foreach (var word in sortedWords)
                {
                    result += $"{word.Key} - {word.Value}\n";
                }
            }

            MessageBox.Show(result, "Lista S��w");
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
                MessageBox.Show(history, "Historia T�umacze�");
            }
            else
            {
                MessageBox.Show("Brak historii t�umacze�.", "Historia T�umacze�");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string polishWord = Microsoft.VisualBasic.Interaction.InputBox("Podaj polskie s�owo:", "Dodaj s�owo", "");
            string englishWord = Microsoft.VisualBasic.Interaction.InputBox("Podaj angielskie t�umaczenie:", "Dodaj t�umaczenie", "");

            if (!string.IsNullOrWhiteSpace(polishWord) && !string.IsNullOrWhiteSpace(englishWord))
            {
                if (!wordDictionary.ContainsKey(polishWord))
                {
                    wordDictionary.Add(polishWord, englishWord);
                    MessageBox.Show("S�owo dodane pomy�lnie.", "Dodawanie s��w");
                }
                else
                {
                    MessageBox.Show("To s�owo ju� istnieje w s�owniku.", "B��d");
                }
            }
            else
            {
                MessageBox.Show("Oba pola musz� by� wype�nione.", "B��d");
            }
        }

        // Dodawanie wpisu do historii (przyk�ad wywo�ania w kodzie Form2)
        public void AddToHistory(string entry)
        {
            if (translationHistory.Count >= 10) // ograniczenie historii do 10 ostatnich t�umacze�
            {
                translationHistory.Dequeue();
            }
            translationHistory.Enqueue(entry);
        }
    }
}

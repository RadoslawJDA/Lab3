namespace Lab3v2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> wordDictionary;
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
                {"miasto", "city"}
            };
        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(wordDictionary);
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

        }

        private void buttonQuit_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
    }
}

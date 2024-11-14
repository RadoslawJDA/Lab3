namespace Lab3v2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> wordDictionary;
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

        }

        private void buttonQuit_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
    }
}

using System.Data;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<char, int> частотніТаблиціGetLetterFrequencies(string text)
        {
            // Видалення всіх символів, залишаючи тільки літери та перетворення на нижній регістр
            string onlyLetters = Regex.Replace(text, @"[^a-zA-Zа-яА-Я]", "").ToLower();

            // Підрахунок частоти кожної літери
            Dictionary<char, int> frequencies = new Dictionary<char, int>();
            foreach (char letter in onlyLetters)
            {
                if (frequencies.ContainsKey(letter))
                {
                    frequencies[letter]++;
                }
                else
                {
                    frequencies[letter] = 1;
                }
            }

            return frequencies;
        }

        private void частотніТаблиціWriteFrequenciesToFile(Dictionary<char, int> frequencies, string filePath)
        {
            string json = JsonConvert.SerializeObject(frequencies, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private void частотніТаблиціDisplayFrequenciesInDataGridView(Dictionary<char, int> frequencies)
        {

            DataTable table = new DataTable();

            table.Columns.Add("Літера", typeof(char));
            table.Columns.Add("Частота", typeof(int));

            foreach (var pair in frequencies)
            {
                table.Rows.Add(pair.Key, pair.Value);
            }
            
            частотніТаблиціdataGridView1.DataSource = table;

            частотніТаблиціdataGridView1.ScrollBars = ScrollBars.Vertical;

            this.Controls.Add(частотніТаблиціdataGridView1);
        }

        private void частотніТаблиціRead()
        {
            string text = частотніТаблиціtextBox.Text;

            Dictionary<char, int> frequencies = частотніТаблиціGetLetterFrequencies(text);

            string fileName = "Dict.json";
            string directoryPath = @"D:\ЛНУ\2 курс 2 семестр\Криптологія\Program\Program\Files";
            string filePath = Path.Combine(directoryPath, fileName);

            частотніТаблиціWriteFrequenciesToFile(frequencies, filePath);

            частотніТаблиціDisplayFrequenciesInDataGridView(frequencies);
        }

        private void частотніТаблиціRun(object sender, EventArgs e)
        {

            частотніТаблиціRead();
        }





        private void частотніТаблиціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip menuStrip = menuStrip1;

            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] != menuStrip)
                {
                    Controls.RemoveAt(i);
                }
            }
            

            

            // Додаємо DataGridView до контролів форми
            Controls.Add(частотніТаблиціdataGridView1);
            частотніТаблиціbuttonRun.Visible = true;
            частотніТаблиціbtnSave.Visible = true;
            частотніТаблиціtextBox.Visible = true; // Робимо текстовий бокс видимим
            Controls.Add(частотніТаблиціtextBox); // Додавання нового елемента
            Controls.Add(частотніТаблиціbuttonRun);
            Controls.Add(частотніТаблиціbtnSave);
        }
        private void частотніТаблиціbtnSave_Click(object sender, EventArgs e)
        {
            // Створюємо діалогове вікно для вибору місця збереження файлу
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            saveFileDialog.Title = "Зберегти файл JSON";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Зчитуємо дані з файлу JSON
                string json = File.ReadAllText(@"D:\ЛНУ\2 курс 2 семестр\Криптологія\Program\Program\Files\Dict.json");
                Dictionary<string, int> dict = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);

                // Зберігаємо дані у файл JSON за вибраним користувачем місцем
                string newJson = JsonConvert.SerializeObject(dict, Formatting.Indented);
                File.WriteAllText(filePath, newJson);

                MessageBox.Show("Дані збережено у файл JSON.");
            }
        }






        private void шифрПростоїЗаміниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip menuStrip = menuStrip1;

            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] != menuStrip)
                {
                    Controls.RemoveAt(i);
                }
            }
            //частотніТаблиціbuttonRun.Visible = true;
            //частотніТаблиціtextBox.Visible = true; // Робимо текстовий бокс видимим
            //Controls.Add(частотніТаблиціtextBox); // Додавання нового елемента
            //Controls.Add(частотніТаблиціbuttonRun);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Встановлюємо початкові розміри та розташування елементів при завантаженні форми

        }
        class KeyComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return x.CompareTo(y);
            }
        }

        private void частотніТаблиціdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
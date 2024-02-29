using System.Data;
using System.Globalization;
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

        private Dictionary<char, double> Lab1GetLetterProbabilities(string text)
        {
            // Видалення всіх символів, залишаючи тільки літери та перетворення на нижній регістр
            string onlyLetters = Regex.Replace(text, @"[^a-zA-Zа-яА-ЯіїєґІЇЄҐ]", "").ToLower(new CultureInfo("uk-UA"));

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

            // Обчислення загальної кількості літер
            int totalLetters = onlyLetters.Length;

            // Обчислення ймовірності для кожної літери
            Dictionary<char, double> probabilities = new Dictionary<char, double>();
            foreach (var kvp in frequencies)
            {
                double probability = Math.Round((double)kvp.Value / totalLetters * 100, 2);
                probabilities[kvp.Key] = probability;
            }

            return probabilities;
        }
        private void проРозробникаToolStripMenuItem_Click(object sender, EventArgs e)

        {
            MenuStrip menuStrip = menuStrip1;

            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] != menuStrip)
                {
                    Controls.RemoveAt(i);
                }
            }
            MessageBox.Show(" Криптосистема\n Розробник: Фарійон Богдан\n Група: ПМА-23\n Рік: 2024");
        }

        private void Lab1ReadFrequenciesFromFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            openFileDialog.Title = "Виберіть файл JSON для зчитування";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Зчитуємо JSON з файлу
                string json = File.ReadAllText(filePath);

                // Десеріалізуємо JSON в словник
                Dictionary<char, double> frequencies = JsonConvert.DeserializeObject<Dictionary<char, double>>(json);

                // Викликаємо вашу функцію для відображення частот у DataGridView
                Lab1DisplayFrequenciesInDataGridView(frequencies);
            }
        }




        private void Lab1DisplayFrequenciesInDataGridView(Dictionary<char, double> frequencies)
        {

            DataTable table = new DataTable();

            table.Columns.Add("Символ", typeof(char));
            table.Columns.Add("Частота", typeof(double));

            foreach (var pair in frequencies)
            {
                table.Rows.Add(pair.Key, pair.Value);
            }
            
            Lab1dataGridView1.DataSource = table;

            Lab1dataGridView1.ScrollBars = ScrollBars.Vertical;

            this.Controls.Add(Lab1dataGridView1);
        }

        private void Lab1Read()
        {
            string text = Lab1textBox.Text;


            Lab1frequencies = Lab1GetLetterProbabilities(text);

            string fileName = "Dict.json";
            string directoryPath = @"D:\ЛНУ\2 курс 2 семестр\Криптологія\Cryptology\Program\Program\Files";
            string filePath = Path.Combine(directoryPath, fileName);



            Lab1DisplayFrequenciesInDataGridView(Lab1frequencies);
        }

        private void Lab1Run(object sender, EventArgs e)
        {

            Lab1Read();
        }





        private void Lab1ToolStripMenuItem_Click(object sender, EventArgs e)
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
            Controls.Add(Lab1dataGridView1);
            Lab1buttonRun.Visible = true;
            Lab1btnLoad.Visible = true;
            Lab1btnSave.Visible = true;
            Lab1textBox.Visible = true; // Робимо текстовий бокс видимим
            Controls.Add(Lab1textBox); // Додавання нового елемента
            Controls.Add(Lab1buttonRun);
            Controls.Add(Lab1btnLoad);
            Controls.Add(Lab1btnSave);
        }
        private void Lab1btnSave_Click(object sender, EventArgs e)
        {
            // Створюємо діалогове вікно для вибору місця збереження файлу
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            saveFileDialog.Title = "Зберегти файл JSON";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                
                string newJson = JsonConvert.SerializeObject(Lab1frequencies, Formatting.Indented);
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
            
            
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Отримуємо розмір екрану
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Отримуємо нові розміри форми
            int newWidth = this.Width;
            int newHeight = this.Height;

            // Оновлюємо розміри елементів пропорційно до нового розміру форми
            Lab1textBox.Width = newWidth / 3; // наприклад, ширина текстового поля - третина ширини форми
            Lab1textBox.Height = newHeight*3/4; // наприклад, висота текстового поля - половина висоти форми
            Lab1dataGridView1.Width = newWidth / 3;
            Lab1dataGridView1.Height = newHeight*3/4;

            // Встановлюємо розташування елементів
            Console.WriteLine("Width вікна: " + this.Width);

            Lab1buttonRun.Location = new Point((newWidth - Lab1buttonRun.Width) / 2, (newHeight - Lab1buttonRun.Height) / 2 - newHeight / 5);
            Lab1btnSave.Location = new Point((newWidth - Lab1btnSave.Width) / 2, (newHeight - Lab1btnSave.Height) / 2);
            Lab1btnLoad.Location = new Point((newWidth - Lab1btnSave.Width) / 2, (newHeight - Lab1btnSave.Height) / 2 + newHeight / 5);
            Lab1dataGridView1.Location = new Point(newWidth - Lab1dataGridView1.Width-35, 35); // зправа та в куті

            // і так далі...
        }


        class KeyComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return x.CompareTo(y);
            }
        }

        private void Lab1dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
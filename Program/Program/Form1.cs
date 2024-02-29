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
            // ��������� ��� �������, ��������� ����� ����� �� ������������ �� ����� ������
            string onlyLetters = Regex.Replace(text, @"[^a-zA-Z�-��-߳�������]", "").ToLower(new CultureInfo("uk-UA"));

            // ϳ�������� ������� ����� �����
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

            // ���������� �������� ������� ����
            int totalLetters = onlyLetters.Length;

            // ���������� ��������� ��� ����� �����
            Dictionary<char, double> probabilities = new Dictionary<char, double>();
            foreach (var kvp in frequencies)
            {
                double probability = Math.Round((double)kvp.Value / totalLetters * 100, 2);
                probabilities[kvp.Key] = probability;
            }

            return probabilities;
        }
        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)

        {
            MenuStrip menuStrip = menuStrip1;

            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] != menuStrip)
                {
                    Controls.RemoveAt(i);
                }
            }
            MessageBox.Show(" �������������\n ���������: ������ ������\n �����: ���-23\n г�: 2024");
        }

        private void Lab1ReadFrequenciesFromFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            openFileDialog.Title = "������� ���� JSON ��� ����������";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // ������� JSON � �����
                string json = File.ReadAllText(filePath);

                // ����������� JSON � �������
                Dictionary<char, double> frequencies = JsonConvert.DeserializeObject<Dictionary<char, double>>(json);

                // ��������� ���� ������� ��� ����������� ������ � DataGridView
                Lab1DisplayFrequenciesInDataGridView(frequencies);
            }
        }




        private void Lab1DisplayFrequenciesInDataGridView(Dictionary<char, double> frequencies)
        {

            DataTable table = new DataTable();

            table.Columns.Add("������", typeof(char));
            table.Columns.Add("�������", typeof(double));

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
            string directoryPath = @"D:\���\2 ���� 2 �������\����������\Cryptology\Program\Program\Files";
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
            

            

            // ������ DataGridView �� �������� �����
            Controls.Add(Lab1dataGridView1);
            Lab1buttonRun.Visible = true;
            Lab1btnLoad.Visible = true;
            Lab1btnSave.Visible = true;
            Lab1textBox.Visible = true; // ������ ��������� ���� �������
            Controls.Add(Lab1textBox); // ��������� ������ ��������
            Controls.Add(Lab1buttonRun);
            Controls.Add(Lab1btnLoad);
            Controls.Add(Lab1btnSave);
        }
        private void Lab1btnSave_Click(object sender, EventArgs e)
        {
            // ��������� �������� ���� ��� ������ ���� ���������� �����
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            saveFileDialog.Title = "�������� ���� JSON";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                
                string newJson = JsonConvert.SerializeObject(Lab1frequencies, Formatting.Indented);
                File.WriteAllText(filePath, newJson);


                MessageBox.Show("��� ��������� � ���� JSON.");
            }
        }






        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuStrip menuStrip = menuStrip1;

            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] != menuStrip)
                {
                    Controls.RemoveAt(i);
                }
            }
            //��������������buttonRun.Visible = true;
            //��������������textBox.Visible = true; // ������ ��������� ���� �������
            //Controls.Add(��������������textBox); // ��������� ������ ��������
            //Controls.Add(��������������buttonRun);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // �������� ����� ������
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // �������� ��� ������ �����
            int newWidth = this.Width;
            int newHeight = this.Height;

            // ��������� ������ �������� ����������� �� ������ ������ �����
            Lab1textBox.Width = newWidth / 3; // ���������, ������ ���������� ���� - ������� ������ �����
            Lab1textBox.Height = newHeight*3/4; // ���������, ������ ���������� ���� - �������� ������ �����
            Lab1dataGridView1.Width = newWidth / 3;
            Lab1dataGridView1.Height = newHeight*3/4;

            // ������������ ������������ ��������
            Console.WriteLine("Width ����: " + this.Width);

            Lab1buttonRun.Location = new Point((newWidth - Lab1buttonRun.Width) / 2, (newHeight - Lab1buttonRun.Height) / 2 - newHeight / 5);
            Lab1btnSave.Location = new Point((newWidth - Lab1btnSave.Width) / 2, (newHeight - Lab1btnSave.Height) / 2);
            Lab1btnLoad.Location = new Point((newWidth - Lab1btnSave.Width) / 2, (newHeight - Lab1btnSave.Height) / 2 + newHeight / 5);
            Lab1dataGridView1.Location = new Point(newWidth - Lab1dataGridView1.Width-35, 35); // ������ �� � ���

            // � ��� ���...
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
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

        private Dictionary<char, int> ��������������GetLetterFrequencies(string text)
        {
            // ��������� ��� �������, ��������� ����� ����� �� ������������ �� ����� ������
            string onlyLetters = Regex.Replace(text, @"[^a-zA-Z�-��-�]", "").ToLower();

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

            return frequencies;
        }

        private void ��������������WriteFrequenciesToFile(Dictionary<char, int> frequencies, string filePath)
        {
            string json = JsonConvert.SerializeObject(frequencies, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private void ��������������DisplayFrequenciesInDataGridView(Dictionary<char, int> frequencies)
        {

            DataTable table = new DataTable();

            table.Columns.Add("˳����", typeof(char));
            table.Columns.Add("�������", typeof(int));

            foreach (var pair in frequencies)
            {
                table.Rows.Add(pair.Key, pair.Value);
            }
            
            ��������������dataGridView1.DataSource = table;

            ��������������dataGridView1.ScrollBars = ScrollBars.Vertical;

            this.Controls.Add(��������������dataGridView1);
        }

        private void ��������������Read()
        {
            string text = ��������������textBox.Text;

            Dictionary<char, int> frequencies = ��������������GetLetterFrequencies(text);

            string fileName = "Dict.json";
            string directoryPath = @"D:\���\2 ���� 2 �������\����������\Cryptology\Program\Program\Files";
            string filePath = Path.Combine(directoryPath, fileName);

            ��������������WriteFrequenciesToFile(frequencies, filePath);

            ��������������DisplayFrequenciesInDataGridView(frequencies);
        }

        private void ��������������Run(object sender, EventArgs e)
        {

            ��������������Read();
        }





        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
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
            Controls.Add(��������������dataGridView1);
            ��������������buttonRun.Visible = true;
            ��������������btnSave.Visible = true;
            ��������������textBox.Visible = true; // ������ ��������� ���� �������
            Controls.Add(��������������textBox); // ��������� ������ ��������
            Controls.Add(��������������buttonRun);
            Controls.Add(��������������btnSave);
        }
        private void ��������������btnSave_Click(object sender, EventArgs e)
        {
            // ��������� �������� ���� ��� ������ ���� ���������� �����
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            saveFileDialog.Title = "�������� ���� JSON";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // ������� ��� � ����� JSON
                string json = File.ReadAllText(@"D:\���\2 ���� 2 �������\����������\Cryptology\Program\Program\Files\Dict.json");
                Dictionary<string, int> dict = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);

                // �������� ��� � ���� JSON �� �������� ������������ �����
                string newJson = JsonConvert.SerializeObject(dict, Formatting.Indented);
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
            ��������������textBox.Width = newWidth / 3; // ���������, ������ ���������� ���� - ������� ������ �����
            ��������������textBox.Height = newHeight*3/4; // ���������, ������ ���������� ���� - �������� ������ �����
            ��������������dataGridView1.Width = newWidth / 3;
            ��������������dataGridView1.Height = newHeight*3/4;

            // ������������ ������������ ��������
            Console.WriteLine("Width ����: " + this.Width);

            ��������������buttonRun.Location = new Point((newWidth - ��������������buttonRun.Width) / 2, (newHeight - ��������������buttonRun.Height) / 2 - newHeight / 5);
            ��������������btnSave.Location = new Point((newWidth - ��������������btnSave.Width) / 2, (newHeight - ��������������btnSave.Height) / 2);
            ��������������dataGridView1.Location = new Point(newWidth - ��������������dataGridView1.Width-35, 35); // ������ �� � ���

            // � ��� ���...
        }


        class KeyComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return x.CompareTo(y);
            }
        }

        private void ��������������dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Program2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataFromColumn1 = "";
            dataFromColumn2 = "";

            var lowerAlphabet = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToArray();
            var upperAlphabet = Enumerable.Range('A', 'Z' - 'A' + 1).Select(c => (char)c).ToArray();
            var alphabet = lowerAlphabet.Concat(upperAlphabet).ToArray();

            var random = new Random();
            var shuffledAlphabet = Shuffle(alphabet, random);

            for (int i = 0; i < alphabet.Length; i++)
            {
                dataGridView1.Rows.Add(alphabet[i], shuffledAlphabet[i]);
                dataFromColumn1 += alphabet[i] + Environment.NewLine;
                dataFromColumn2 += shuffledAlphabet[i] + Environment.NewLine;
            }
        }

        
        private T[] Shuffle<T>(T[] array, Random random)
        {
            
            var shuffledArray = (T[])array.Clone();

            
            for (int i = 0; i < shuffledArray.Length; i++)
            {
                int j = random.Next(i, shuffledArray.Length);
                T temp = shuffledArray[i];
                shuffledArray[i] = shuffledArray[j];
                shuffledArray[j] = temp;
            }

            return shuffledArray;
        }



        private void btnRun_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text;
            

            StringBuilder outputText = new StringBuilder(inputText);
            for (int i = 0; i < inputText.Length; i++)
            {
               
                if (dataFromColumn1.Contains(inputText[i]))
                {
                  
                    int index = dataFromColumn1.IndexOf(inputText[i]);
                    char replacement = dataFromColumn2[index].ToString()[0];
                    outputText[i] = replacement;
                }
              
            }

           
            textBoxOutput.Text = outputText.ToString();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text;

     
            StringBuilder outputText = new StringBuilder(inputText);
            for (int i = 0; i < inputText.Length; i++)
            {
          
                if (dataFromColumn2.Contains(inputText[i]))
                {
         
                    int index = dataFromColumn2.IndexOf(inputText[i]);
                    char replacement = dataFromColumn1[index].ToString()[0];
                    outputText[i] = replacement;
                }
            }

     
            textBoxOutput.Text = outputText.ToString();
        }
        private void Form2_Resize(object sender, EventArgs e)
        {
   
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            int newWidth = this.Width;
            int newHeight = this.Height;

     
            textBoxInput.Width = newWidth / 3; 
            textBoxInput.Height = newHeight /2; 
            textBoxOutput.Width = newWidth / 3;
            textBoxOutput.Height = newHeight /2;
            dataGridView1.Height = newHeight/4;

           
            Console.WriteLine("Width вікна: " + this.Width);

            btn_create.Location=  new Point((newWidth - btnDec.Width) / 2-70 , (newHeight - btnDec.Height) / 2 + newHeight / 4);
            btn_change.Location = new Point((newWidth - btnDec.Width) / 2 + 70, (newHeight - btnDec.Height) / 2 + newHeight / 4);
            btn_load.Location = new Point((newWidth - btnDec.Width) / 2 - 70, (newHeight - btnDec.Height) / 2 + newHeight / 4 + 60);
            btn_save.Location = new Point((newWidth - btnDec.Width) / 2 + 70, (newHeight - btnDec.Height) / 2 + newHeight / 4 + 60);
            btnRun.Location = new Point((newWidth - btnRun.Width) / 2, (newHeight - btnRun.Height) / 2 - newHeight / 6 - newHeight / 6);
            btnDec.Location = new Point((newWidth - btnDec.Width) / 2, (newHeight - btnDec.Height) / 2 - newHeight / 6);
            dataGridView1.Location = new Point((newWidth - btnDec.Width) / 2 - 55, (newHeight - btnDec.Height) / 2);
            textBoxOutput.Location = new Point(newWidth - textBoxOutput.Width - 35, 29); // зправа та в куті

           
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {

                int columnIndex1 = dataGridView1.SelectedCells[0].ColumnIndex;
                int columnIndex2 = dataGridView1.SelectedCells[1].ColumnIndex;

                dataFromColumn1 = string.Empty;
                dataFromColumn2 = string.Empty;



                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataFromColumn1 += row.Cells[columnIndex1].Value + Environment.NewLine;
                    dataFromColumn2 += row.Cells[columnIndex2].Value + Environment.NewLine;
                }

                MessageBox.Show("Зміни збережено");


            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть хоча б одну комірку в кожному стовпці.");
            }
        }
        public class TableData
        {
            public string Column1 { get; set; }
            public string Column2 { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            openFileDialog.Title = "Відкрити файл JSON";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Завантажуємо дані з файлу JSON
                string json = File.ReadAllText(filePath);
                var data = JsonConvert.DeserializeObject<dynamic>(json);

                // Записуємо дані у змінні
                dataFromColumn1 = data.Column1;
                dataFromColumn2 = data.Column2;

                // Відображаємо дані у таблиці
                dataGridView1.Rows.Clear();
                string[] column1Data = ((string)data.Column1).Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                string[] column2Data = ((string)data.Column2).Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < Math.Min(column1Data.Length, column2Data.Length); i++)
                {
                    dataGridView1.Rows.Add(column1Data[i], column2Data[i]);
                }

                MessageBox.Show("Дані завантажено з файлу JSON.");
            }
        }

    


    private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            saveFileDialog.Title = "Зберегти файл JSON";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Створюємо об'єкт для збереження даних з dataGridView1
                var dataToSave = new
                {
                    Column1 = dataFromColumn1,
                    Column2 = dataFromColumn2
                };

                // Перетворюємо дані у формат JSON та зберігаємо у файл
                string jsonData = JsonConvert.SerializeObject(dataToSave, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, jsonData);

                MessageBox.Show("Таблицю збережено у файл JSON.");
            }
        }
    }
}

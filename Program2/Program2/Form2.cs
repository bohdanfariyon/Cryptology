using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Перевірка чи обрана хоча б одна комірка
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Отримуємо індекси обраних стовпців
                int columnIndex1 = dataGridView1.SelectedCells[0].ColumnIndex;
                int columnIndex2 = dataGridView1.SelectedCells[1].ColumnIndex;

                dataFromColumn1=string.Empty;
                dataFromColumn2=string.Empty;
                

                // Зчитуємо дані з обраних стовпців і записуємо їх у змінні
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataFromColumn1 += row.Cells[columnIndex1].Value + Environment.NewLine;
                    dataFromColumn2 += row.Cells[columnIndex2].Value + Environment.NewLine;
                }

                MessageBox.Show("Дані збережено");

                // Тут ви можете робити що завгодно зі зчитаними даними (наприклад, записувати їх у змінні класу)
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть хоча б одну комірку в кожному стовпці.");
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text;

            // Замінити символи введеного тексту
            StringBuilder outputText = new StringBuilder(inputText);
            for (int i = 0; i < inputText.Length; i++)
            {
                // Перевірити, чи є поточний символ у списку символів з Column1
                if (dataFromColumn1.Contains(inputText[i]))
                {
                    // Замінити символ з Column1 на відповідний символ з Column2
                    int index = dataFromColumn1.IndexOf(inputText[i]);
                    char replacement = dataFromColumn2[index].ToString()[0];
                    outputText[i] = replacement;
                }
            }

            // Вивести змінений текст у textBoxOutput
            textBoxOutput.Text = outputText.ToString();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text;

            // Замінити символи введеного тексту
            StringBuilder outputText = new StringBuilder(inputText);
            for (int i = 0; i < inputText.Length; i++)
            {
                // Перевірити, чи є поточний символ у списку символів з Column1
                if (dataFromColumn2.Contains(inputText[i]))
                {
                    // Замінити символ з Column1 на відповідний символ з Column2
                    int index = dataFromColumn2.IndexOf(inputText[i]);
                    char replacement = dataFromColumn1[index].ToString()[0];
                    outputText[i] = replacement;
                }
            }

            // Вивести змінений текст у textBoxOutput
            textBoxOutput.Text = outputText.ToString();
        }
        private void Form2_Resize(object sender, EventArgs e)
        {
            // Отримуємо розмір екрану
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Отримуємо нові розміри форми
            int newWidth = this.Width;
            int newHeight = this.Height;

            // Оновлюємо розміри елементів пропорційно до нового розміру форми
            textBoxInput.Width = newWidth / 3; // наприклад, ширина текстового поля - третина ширини форми
            textBoxInput.Height = newHeight /2; // наприклад, висота текстового поля - половина висоти форми
            textBoxOutput.Width = newWidth / 3;
            textBoxOutput.Height = newHeight /2;
            dataGridView1.Height = newHeight/4;

            // Встановлюємо розташування елементів
            Console.WriteLine("Width вікна: " + this.Width);

            btn_create.Location= new Point((newWidth - btnDec.Width) / 2, (newHeight - btnDec.Height) / 2);
            btnRun.Location = new Point((newWidth - btnRun.Width) / 2, (newHeight - btnRun.Height) / 2 - newHeight / 6 - newHeight / 6);
            btnDec.Location = new Point((newWidth - btnDec.Width) / 2, (newHeight - btnDec.Height) / 2 - newHeight / 6);
            dataGridView1.Location = new Point((newWidth - btnDec.Width) / 2-65, (newHeight - btnDec.Height) / 2 + newHeight / 6);
            textBoxOutput.Location = new Point(newWidth - textBoxOutput.Width - 35, 29); // зправа та в куті

            // і так далі...
        }
    }
}

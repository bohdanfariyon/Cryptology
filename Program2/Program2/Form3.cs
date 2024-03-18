using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            openFileDialog.Title = "Виберіть файл JSON для зчитування";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

             
                string json = File.ReadAllText(filePath);

             
                Dictionary<char, double> frequencies = JsonConvert.DeserializeObject<Dictionary<char, double>>(json);

               
                DataTable table = new DataTable();

                table.Columns.Add("Символ", typeof(char));
                table.Columns.Add("Частота", typeof(double));

                foreach (var pair in frequencies)
                {
                    table.Rows.Add(pair.Key, pair.Value);
                }

                dataGridView3.DataSource = table;

                dataGridView3.ScrollBars = ScrollBars.Vertical;

                this.Controls.Add(dataGridView3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            openFileDialog.Title = "Виберіть файл JSON для зчитування";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

            
                string json = File.ReadAllText(filePath);

               
                Dictionary<char, double> frequencies = JsonConvert.DeserializeObject<Dictionary<char, double>>(json);

             
                DataTable table = new DataTable();

                table.Columns.Add("Символ", typeof(char));
                table.Columns.Add("Частота", typeof(double));

                foreach (var pair in frequencies)
                {
                    table.Rows.Add(pair.Key, pair.Value);
                }

                dataGridView2.DataSource = table;

                dataGridView2.ScrollBars = ScrollBars.Vertical;

                this.Controls.Add(dataGridView2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            
            dataFromColumn1 = "";
            dataFromColumn2 = "";

         
            string[] column1Data = new string[dataGridView2.Rows.Count];
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                column1Data[i] = dataGridView2.Rows[i].Cells[0].Value?.ToString() ?? "";
            }

         
            string[] column2Data = new string[dataGridView3.Rows.Count];
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                column2Data[i] = dataGridView3.Rows[i].Cells[0].Value?.ToString() ?? "";
            }

        
            int rowCount = Math.Max(column1Data.Length, column2Data.Length);

           
            for (int i = 0; i < rowCount; i++)
            {
                string column1Value = i < column1Data.Length ? column1Data[i] : "";
                string column2Value = i < column2Data.Length ? column2Data[i] : "";

                dataGridView1.Rows.Add(column2Value, column1Value);

                
                dataFromColumn1 += column1Value + Environment.NewLine;
                dataFromColumn2 += column2Value + Environment.NewLine;
            }
        }
        private void Form3_Resize(object sender, EventArgs e)
        {

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            int newWidth = this.Width;
            int newHeight = this.Height;


            textBoxInput.Width = newWidth / 3;
            textBoxInput.Height = newHeight / 2;
            textBoxOutput.Width = newWidth / 3;
            textBoxOutput.Height = newHeight / 2;
            


            Console.WriteLine("Width вікна: " + this.Width);

            btn_dec.Location = new Point((newWidth ) / 2 -70, (newHeight - btn_dec.Height) / 2-120);
            dataGridView2.Location = new Point((newWidth) / 2 + (newWidth) / 4, (newHeight - btn_dec.Height) / 2 +90);
            button2.Location = new Point((newWidth) / 2 + (newWidth) / 4+45, (newHeight - btn_dec.Height) / 2 + 220);
            dataGridView3.Location = new Point((newWidth) / 16, (newHeight - btn_dec.Height) / 2 + 90);
            button3.Location = new Point((newWidth) / 16 +45, (newHeight - btn_dec.Height) / 2 + 220);
            dataGridView1.Location = new Point((newWidth) / 2 -120, (newHeight - btn_dec.Height) / 2 );
            button1.Location = new Point((newWidth) / 2 - 70, (newHeight - btn_dec.Height) / 2 + 130);
            btn_save.Location = new Point((newWidth) / 2 - 70, (newHeight - btn_dec.Height) / 2 + 200);
            textBoxOutput.Location = new Point(newWidth - textBoxOutput.Width - 35, 29); // зправа та в куті


        }
        private void btn_dec_Click(object sender, EventArgs e)
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

        private void btn_save_Click(object sender, EventArgs e)
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
    }
}

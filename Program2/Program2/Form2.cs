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
            
            if (dataGridView1.SelectedCells.Count > 0)
            {
                
                int columnIndex1 = dataGridView1.SelectedCells[0].ColumnIndex;
                int columnIndex2 = dataGridView1.SelectedCells[1].ColumnIndex;

                dataFromColumn1=string.Empty;
                dataFromColumn2=string.Empty;
                

                
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataFromColumn1 += row.Cells[columnIndex1].Value + Environment.NewLine;
                    dataFromColumn2 += row.Cells[columnIndex2].Value + Environment.NewLine;
                }

                MessageBox.Show("Дані збережено");

                
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть хоча б одну комірку в кожному стовпці.");
            }
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

            btn_create.Location=  new Point((newWidth - btnDec.Width) / 2 , (newHeight - btnDec.Height) / 2 + newHeight / 4);
            btnRun.Location = new Point((newWidth - btnRun.Width) / 2, (newHeight - btnRun.Height) / 2 - newHeight / 6 - newHeight / 6);
            btnDec.Location = new Point((newWidth - btnDec.Width) / 2, (newHeight - btnDec.Height) / 2 - newHeight / 6);
            dataGridView1.Location = new Point((newWidth - btnDec.Width) / 2 - 55, (newHeight - btnDec.Height) / 2);
            textBoxOutput.Location = new Point(newWidth - textBoxOutput.Width - 35, 29); // зправа та в куті

           
        }
    }
}

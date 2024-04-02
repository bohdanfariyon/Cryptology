using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Program2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            var cipher = new VigenereCipher();
            var inputText = textBox1.Text;
           
            textBox2.Text += cipher.Encrypt(inputText, textBoxKey.Text);
        }
        private void Form4_Resize(object sender, EventArgs e)
        {

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            int newWidth = this.Width;
            int newHeight = this.Height;


            textBox1.Width = newWidth / 3;
            textBox1.Height = newHeight / 2;
            textBox2.Width = newWidth / 3;
            textBox2.Height = newHeight / 2;
            textBoxKey.Height = newHeight / 4;
            textBoxKey.Width = newWidth / 6;


            Console.WriteLine("Width вікна: " + this.Width);

            btn_load.Location = new Point((newWidth - btn_decrypt.Width) / 2 - 70, (newHeight - btn_decrypt.Height) / 2 + newHeight / 4);
            btn_save.Location = new Point((newWidth - btn_decrypt.Width) / 2 + 70, (newHeight - btn_decrypt.Height) / 2 + newHeight / 4);
            btn_create.Location = new Point((newWidth - btn_decrypt.Width) / 2 , (newHeight - btn_decrypt.Height) / 2 + newHeight / 4 + 60);
            
            btn_encrypt.Location = new Point((newWidth - btn_encrypt.Width) / 2, (newHeight - btn_encrypt.Height) / 2 - newHeight / 6 - newHeight / 6);
            btn_decrypt.Location = new Point((newWidth - btn_decrypt.Width) / 2, (newHeight - btn_decrypt.Height) / 2 - newHeight / 6);
            textBoxKey.Location = new Point((newWidth - btn_decrypt.Width) / 2 -30, (newHeight - btn_decrypt.Height) / 2);
            textBox2.Location = new Point(newWidth - textBox2.Width - 35, 29); 


        }

        private void btn_create_Click(object sender, EventArgs e)
        {   
            string number = Interaction.InputBox("Введіть, будь ласка, довжину ключа який ви хочете згенерувати", "Число");
            int count;
            try
            {
                count = Convert.ToInt32(number);
            }catch (Exception ex)
            {
                count = 0;
            }
            if (count > 0) 
            {
                Random random = new Random();
                StringBuilder sb = new StringBuilder();

                
                for (int i = 0; i < count; i++)
                {
                    char randomLetter = (char)('a' + random.Next(0, 26)); 
                    sb.Append(randomLetter);
                }

                textBoxKey.Text=sb.ToString();
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            var cipher = new VigenereCipher();
            var inputText = textBox1.Text;
            textBox2.Text += cipher.Decrypt(inputText, textBoxKey.Text);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt"; 

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    File.WriteAllText(sfd.FileName, textBoxKey.Text);
                    MessageBox.Show("Успішно збережено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка при збереженні даних: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt"; 

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    textBoxKey.Text = File.ReadAllText(ofd.FileName);
                    
                    MessageBox.Show("Ключ успішно завантажено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка при завантаженні ключа: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

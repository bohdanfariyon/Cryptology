using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Program2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Resize(object sender, EventArgs e)
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
            btn_create.Location = new Point((newWidth - btn_decrypt.Width) / 2, (newHeight - btn_decrypt.Height) / 2 + newHeight / 4 + 60);

            btn_encrypt.Location = new Point((newWidth - btn_encrypt.Width) / 2, (newHeight - btn_encrypt.Height) / 2 - newHeight / 6 - newHeight / 6);
            btn_decrypt.Location = new Point((newWidth - btn_decrypt.Width) / 2, (newHeight - btn_decrypt.Height) / 2 - newHeight / 6);
            textBoxKey.Location = new Point((newWidth - btn_decrypt.Width) / 2 - 30, (newHeight - btn_decrypt.Height) / 2);
            textBox2.Location = new Point(newWidth - textBox2.Width - 35, 50);


        }


        public static string Encrypt(string plainText, string key)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] encryptedBytes = new byte[plainBytes.Length];

            for (int i = 0; i < plainBytes.Length; i++)
            {
                
                encryptedBytes[i] = (byte)(plainBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return Convert.ToBase64String(encryptedBytes);
        }


        public static string Decrypt(string cipherText, string key)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] decryptedBytes = new byte[cipherBytes.Length];

            for (int i = 0; i < cipherBytes.Length; i++)
            {
                
                decryptedBytes[i] = (byte)(cipherBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return Encoding.UTF8.GetString(decryptedBytes);
        }


        private void btn_create_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            byte[] keyBytes = new byte[textBox1.Text.Length];

            random.NextBytes(keyBytes); 

            textBoxKey.Text = Encoding.UTF8.GetString(keyBytes);
        }





        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            string sampleString = textBox1.Text;
            string key = textBoxKey.Text;
            string encryptedString = Encrypt(sampleString, key);
            textBox2.Text = encryptedString;
        }
        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            string sampleString = textBox1.Text;
            string key = textBoxKey.Text;
            string encryptedString = Decrypt(sampleString, key);
            textBox2.Text = encryptedString;
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

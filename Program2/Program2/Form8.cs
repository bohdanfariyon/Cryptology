﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form8 : Form
    {
        List<string> result;
        public Form8()
        {
            InitializeComponent();
        }
        char[] characters = new char[] {
    // Стандартні ASCII символи
    
    ' ', '!', '"', '#', '$', '%', '&', '\'',
    '(', ')', '*', '+', ',', '-', '.', '/',
    '0', '1', '2', '3', '4', '5', '6', '7',
    '8', '9', ':', ';', '<', '=', '>', '?',
    '@', 'A', 'B', 'C', 'D', 'E', 'F', 'G',';',
    'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O',
    'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W',
    'X', 'Y', 'Z', '[', '\\', ']', '^', '_',
    '`', 'a', 'b', 'c', 'd', 'e', 'f', 'g',
    'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
    'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
    'x', 'y', 'z', '{', '|', '}', '~', '"', '"',
    // Додані українські букви
    'А', 'Б', 'В', 'Г', 'Ґ', 'Д', 'Е', 'Є',
    'Ж', 'З', 'И', 'І', 'Ї', 'Й', 'К', 'Л',
    'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У',
    'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ю',
    'Я', 'а', 'б', 'в', 'г', 'ґ', 'д', 'е',
    'є', 'ж', 'з', 'и', 'і', 'ї', 'й', 'к',
    'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т',
    'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь',
    'ю', 'я', 'Ы', 'ы', 'Э', 'э', 'Є', 'є',
    'І', 'і', 'Ї', 'ї', 'Й', 'й', 'Ю', 'ю',
    'Я', 'я', 'Ѣ', 'ѣ', 'Ѳ', 'ѳ', 'Ѵ', 'ѵ'
};


        private bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;

        }
        private List<string> RSA_Endoce(string s, long e, long n)
        {
            List<string> result = new List<string>();
            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);
                if (index == -1)
                {
                    throw new InvalidOperationException($"Character '{s[i]}' not found in the characters array.");
                }

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);
                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        private string RSA_Dedoce(List<string> input, long d, long n)
        {
            string result = "";

            BigInteger bi;
            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());
                if (index < 0 || index >= characters.Length)
                {
                    throw new InvalidOperationException($"Invalid index {index} out of bounds of characters array.");
                }
                result += characters[index].ToString();
            }

            return result;
        }

        private long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0))
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        private long Calculate_e(long d, long m)
        {
            long e = 2;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }


        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if ((textBox3.Text.Length > 0) && (textBox4.Text.Length > 0))
            {
                long p = Convert.ToInt64(textBox3.Text);
                long q = Convert.ToInt64(textBox4.Text);

                if (IsTheNumberSimple(p) && IsTheNumberSimple(q))
                {
                    string s = "";


                    for (int i = 0; i < textBox1.Lines.Length; i++)
                    {
                        s += textBox1.Lines[i]; // Використовуйте textBox1.Lines замість textBox1.Text
                    }





                    long n = p * q;
                    long m = (p - 1) * (q - 1);
                    long d = Calculate_d(m);
                    long e_ = Calculate_e(d, m);

                    List<string> result = RSA_Endoce(s, e_, n);

                    for (int i = 0; i < result.Count - 1; i++)
                    {
                        textBox2.Text += result[i] + Environment.NewLine;
                    }

                    textBox2.Text += result[result.Count - 1];

                    textBox5.Text = e_.ToString();
                    textBox6.Text = n.ToString();

                }
                else
                    MessageBox.Show("p або q не являються простими числами!");
            }
            else
                MessageBox.Show("Введіть p або q!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if ((textBox5.Text.Length > 0) && (textBox6.Text.Length > 0))
            {
                long d = Convert.ToInt64(textBox5.Text);
                long n = Convert.ToInt64(textBox6.Text);

                List<string> input = new List<string>();
                var text = textBox1.Text;
                var textList = text.Split('\n');

                for (int i = 0; i < textList.Length; i++)
                {
                    input.Add(textList[i]);
                }

                string result = RSA_Dedoce(input, d, n);

                textBox2.Text += result;

            }
            else
                MessageBox.Show("Введіть секретний ключ!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Sevka\source\repos\Crypta\Crypta",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string fileText = File.ReadAllText(filename);
                textBox1.Text = fileText;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox2.Text);
            }
            MessageBox.Show(
        "       Успішно збережено!",
        ""
        );
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Бажаєте зберегти дані перед виходом?",
        "Увага!",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                button1.BackColor = Color.Red;
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, textBox2.Text);
                }
                MessageBox.Show(
            "       Успішно збережено!",
            ""
            );
                this.Close();
            }
            if (result == DialogResult.No)
            {
                this.Close();
            }
        }

    }
}

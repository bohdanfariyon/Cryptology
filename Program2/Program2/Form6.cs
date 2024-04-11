using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Program2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private static List<int> Euclid(int a, int b)
        {
            List<int> result = new List<int>();

            if (b == 0)
            {
                result.Add(a);
                result.Add(1);
                result.Add(0);
                return result;
            }

            int r0 = a;
            int r1 = b;
            int u0 = 1;
            int v0 = 0;
            int u1 = 0;
            int v1 = 1;

            while (r1 > 0)
            {
                int q = r0 / r1;
                int temp = r1;
                r1 = r0 % r1;
                r0 = temp;

                int tempU = u1;
                u1 = u0 - q * u1;
                u0 = tempU;

                int tempV = v1;
                v1 = v0 - q * v1;
                v0 = tempV;
            }

            result.Add(r0);
            result.Add(u0);
            result.Add(v0);

            return result;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNSD.Text = "";
            textBoxU.Text = "";
            textBoxV.Text = "";
            string a, b;
            try
            {
                a = textBoxInputA.Text;
                b = textBoxInputB.Text;
                List<int> result = Euclid(int.Parse(a), int.Parse(b));
                textBoxNSD.Text = result[0].ToString();
                textBoxU.Text = result[1].ToString();
                textBoxV.Text = result[2].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error 404");
            }
        }

        private static int power(int x, int y, int p)
        {
            int res = 1;
            x = x % p;
            if (x == 0)
            {
                return 0;
            }
            while (y > 0)
            {
                if ((y & 1) != 0)
                {
                    res = (res * x) % p;
                }

                y = y >> 1;
                x = (x * x) % p;
            }
            return res;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxRes.Text = "";
            
            int x = Convert.ToInt32(textBoxInputX.Text);
            int d = Convert.ToInt32(textBoxInputD.Text);
            int n = Convert.ToInt32(textBoxModN.Text);
            textBoxRes.Text = $"{power(x, d, n)}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxInputN.Text);
            int l = (int)Math.Ceiling(Math.Log(n, 2));
            textBoxL.Text = l.ToString();
            int x = my_Random(l, n, out string binaryString);



            textBoxXBinary.Text = binaryString;
            textBoxXRandom.Text = x.ToString();
        }
        private int my_Random(int l, int n, out string binaryString)
        {
            Random random = new Random();
            int x = 0;
            binaryString = "";
            do
            {
                binaryString = "";
                for (int i = 0; i < l; i++)
                {
                    binaryString += random.Next(0, 2);
                }
                x = Convert.ToInt32(binaryString, 2);
               
            } while (x >= n);
            return x;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxInputN.Text);
            int l = (int)Math.Ceiling(Math.Log(n, 2));
            textBoxL.Text = l.ToString();
            int x = my_Random(l, n, out string binaryString);
            int nsd = NSD_(x, n);

            while (nsd != 1)
            {
                x = my_Random(l, n, out binaryString);
                nsd = NSD_(x, n);
            }
            textBoxNSDD.Text = x.ToString();
        }
        private int NSD_(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }


    
    



    
}



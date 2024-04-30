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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxRes1.Text = "";
            long num1 = long.Parse(textBoxInputN1.Text);
            long num2 = long.Parse(textBoxInputX.Text);
            textBoxRes1.Text += (calculateJacobian(num2, num1));
        }
        static long calculateJacobian(long a, long n)
        {
            if (n <= 0 || n % 2 == 0)
                return 0;

            long ans = 1L;

            if (a < 0)
            {
                a = -a; // (a/n) = (-a/n)*(-1/n)
                if (n % 4 == 3)
                    ans = -ans; // (-1/n) = -1 if n = 3 (mod 4)
            }

            if (a == 1)
                return ans; // (1/n) = 1

            while (a != 0)
            {
                if (a < 0)
                {
                    a = -a; // (a/n) = (-a/n)*(-1/n)
                    if (n % 4 == 3)
                        ans = -ans; // (-1/n) = -1 if n = 3 (mod 4)
                }

                while (a % 2 == 0)
                {
                    a /= 2;
                    if (n % 8 == 3 || n % 8 == 5)
                        ans = -ans;
                }

                long temp = a;
                a = n;
                n = temp;

                if (a % 4 == 3 && n % 4 == 3)
                    ans = -ans;

                a %= n;
                if (a > n / 2)
                    a = a - n;
            }

            if (n == 1)
                return ans;

            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxRes2.Text = "";
            int iter = int.Parse(textBoxInputK.Text);
            long num1 = long.Parse(textBoxInputN2.Text);
            



            if (solovoyStrassen(num1, iter))
                textBoxRes2.Text += (num1 + " є простим\r\n");
            else
                textBoxRes2.Text += (num1 + " є складеним\r\n");

            
        }
        static bool solovoyStrassen(long p, int iteration)
        {
            if (p < 2)
                return false;
            if (p != 2 && p % 2 == 0)
                return false;

            // Create Object for Random Class
            Random rand = new Random();
            for (int i = 0; i < iteration; i++)
            {

                // Generate a random number r
                long r = Math.Abs(rand.Next());
                long a = r % (p - 1) + 1;
                long jacobian = (p + calculateJacobian(a, p)) % p;
                long mod = modulo(a, (p - 1) / 2, p);

                if (jacobian == 0 || mod != jacobian)
                    return false;
            }
            return true;
        }
        static long modulo(long Base, long exponent, long mod)
        {
            long x = 1;
            long y = Base;

            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                    x = (x * y) % mod;

                y = (y * y) % mod;
                exponent = exponent / 2;

            }
            return x % mod;
        }
    }
}

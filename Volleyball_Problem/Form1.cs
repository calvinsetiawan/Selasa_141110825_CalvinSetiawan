using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volleyball_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }
        public int segitigaPascal(int a, int b, int mod)
        {
            int[] segitiga = new int[b];            
            for (int i = 0; i < b; i++)
            {
                segitiga[i] = 1;
            }
            for (int i = b - 2; i > 0; i--)
            {
                for (int j = i; j < b - 1; j++)
                {
                    segitiga[j] += segitiga[j + 1];
                    segitiga[j] %= mod;
                }
            }
            int prediksi = 1; 
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b - 1; j++)
                {
                    segitiga[j] += segitiga[j + 1];
                    segitiga[j] %= mod;
                }
                prediksi += segitiga[0];
                prediksi %= mod;
            }
            return prediksi;
        }
        public long ex(long x, long exp_a, int mod)
        {
            long result = 1;
            while (exp_a > 0)
            {
                if (exp_a % 2 == 1)
                {
                    result *= x;
                    result %= mod;
                }
                exp_a /= 2;
                x *= x;
                x %= mod;
            }
            return result % mod;

        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int mod = 1000000007;
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);
            int temp;
            long hasil;
            // membuat nilai a > b
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            if (a < 25)
            {
                TxtHasil.Text = "0";
            }
            else if (a > 25 && a - b != 2)
            {
                TxtHasil.Text = "0";
            }
            else if (a == 25 && a - b != 2)
            {
                hasil = (long)segitigaPascal(a - 1, b, mod);
                TxtHasil.Text = hasil.ToString();
            }
            else if (a > 25 && b == a - 2)
            {
                hasil = (long)segitigaPascal(24, 24, mod);
                //MessageBox.Show(hasil.ToString());
                int exp_a = b - 24;
                //MessageBox.Show("hasil : ");
                //MessageBox.Show(exp_a.ToString());
                hasil *= ex(2, exp_a, mod);
                hasil %= mod;
                TxtHasil.Text = hasil.ToString();
            }
        }
    }
}

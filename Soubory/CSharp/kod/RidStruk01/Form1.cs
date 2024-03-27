using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RidStruk01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int n;

            // Získání hodnot z textBoxů
            if (!int.TryParse(textBox1.Text, out a) || !int.TryParse(textBox2.Text, out n))
            {
                MessageBox.Show("Neplatný vstup!");
                return;
            }

            // Spočítání mocniny a^n
            double powerResult = Math.Pow(a, n);

            // Spočítání faktoriálu n!
            int factorialResult = 1;
            for (int i = 2; i <= n; i++)
            {
                factorialResult *= i;
            }

            // Zobrazení výsledků v okně se zprávou
            string message = "";
            if (checkBox1.Checked)
            {
                message += $"Mocnina {a}^{n} = {powerResult}\n";
            }
            if (checkBox2.Checked)
            {
                message += $"Faktoriál {n}! = {factorialResult}\n";
            }

            MessageBox.Show(message);
        }
    }
    
}

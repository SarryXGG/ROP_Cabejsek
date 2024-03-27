using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RidStruk02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            // Kontrola platnosti vstupu
            if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int number))
            {
                // Výpočet ciferného součtu
                int digitSum = 0;
                while (number > 0)
                {
                    digitSum += number % 10;
                    number /= 10;
                }

                MessageBox.Show($"Ciferný součet čísla je: {digitSum}", "Ciferný součet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zadejte platné celé číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            // Kontrola platnosti vstupu
            if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int number))
            {
                // Hledání dělitelů
                List<int> divisors = new List<int>();
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        divisors.Add(i);
                    }
                }

                // Výpis dělitelů do ListBoxu
                listBox1.Items.Clear();
                foreach (int divisor in divisors)
                {
                    listBox1.Items.Add(divisor);
                }
            }
            else
            {
                MessageBox.Show("Zadejte platné celé číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

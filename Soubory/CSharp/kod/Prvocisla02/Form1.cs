using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prvocislo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 11, 20, 3, 8, 5, 12, 7, 18, 23, 31 }; // Ukázka vstupní posloupnosti

            int firstPrime = FindFirstPrime(numbers);

            if (firstPrime != -1)
            {
                MessageBox.Show($"První prvočíslo v posloupnosti je: {firstPrime}", "Výsledek", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("V posloupnosti není žádné prvočíslo.", "Výsledek", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int FindFirstPrime(int[] numbers)
        {
            bool[] isPrime = new bool[121]; // Pole pro uchování informace o prvočíslech

            // Inicializace pole, předpokládáme, že všechna čísla jsou prvočísla
            for (int i = 2; i <= 120; i++)
            {
                isPrime[i] = true;
            }

            // Označení násobků čísel jako neprvočísel
            for (int i = 2; i * i <= 120; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= 120; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            // Hledání prvního prvočísla v posloupnosti
            foreach (int number in numbers)
            {
                if (isPrime[number])
                {
                    return number;
                }
            }

            return -1; // Vracíme -1, pokud v posloupnosti není žádné prvočíslo
        }
    }
}

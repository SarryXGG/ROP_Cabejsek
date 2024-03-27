using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n))
            {
                // Inicializace instance generátoru náhodných čísel
                Random rnd = new Random();

                // Inicializace pole pro uchování náhodných reálných čísel
                double[] pole = new double[n];

                // Vygenerování náhodných reálných čísel a vložení do pole
                for (int i = 0; i < n; i++)
                {
                    pole[i] = rnd.NextDouble() * 1000; // Generuje čísla z intervalu <0;1000)
                }

                // Výpis vygenerovaného pole do ListBoxu
                listBox1.Items.Clear();
                listBox1.Items.AddRange(pole.Select(x => x.ToString()).ToArray());

                // Najití nejmenšího čísla většího než poslední prvek
                double posledniPrvek = pole.Last();
                double minPrvek = pole.Where(x => x > posledniPrvek).DefaultIfEmpty(double.MaxValue).Min();

                // Výpis výsledku
                if (minPrvek == double.MaxValue)
                {
                    MessageBox.Show("Žádný prvek není větší než poslední prvek.", "Výsledek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Nejmenší číslo větší než poslední prvek je: {minPrvek}", "Výsledek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Neplatný vstup.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

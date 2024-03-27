using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole01
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

                // Inicializace pole pro uchování náhodných čísel
                int[] pole = new int[n];

                // Vygenerování náhodných čísel a vložení do pole
                for (int i = 0; i < n; i++)
                {
                    pole[i] = rnd.Next(0, 51); // Generuje čísla z intervalu 0 až 50
                }

                // Výpis vygenerovaného pole do ListBoxu
                listBox1.Items.Clear();
                listBox1.Items.AddRange(pole.Select(x => x.ToString()).ToArray());

                // Výpočet aritmetického průměru lichých prvků
                int pocetLichych = 0;
                int soucetLichych = 0;
                foreach (int cislo in pole)
                {
                    if (cislo % 2 != 0)
                    {
                        pocetLichych++;
                        soucetLichych += cislo;
                    }
                }

                double prumerLichych = pocetLichych == 0 ? 0 : (double)soucetLichych / pocetLichych;

                // Výpis prvků větších než aritmetický průměr lichých prvků
                listBox2.Items.Clear();
                foreach (int cislo in pole)
                {
                    if (cislo > prumerLichych)
                    {
                        listBox2.Items.Add(cislo.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Neplatný vstup.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

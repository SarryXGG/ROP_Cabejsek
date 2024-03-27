using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Získání čísel ze vstupních TextBoxů
            double cislo1, cislo2, cislo3;
            if (!double.TryParse(textBox1.Text, out cislo1) || !double.TryParse(textBox2.Text, out cislo2) || !double.TryParse(textBox3.Text, out cislo3))
            {
                MessageBox.Show("Neplatný vstupní formát! Zadejte platná čísla.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Výpočet průměru
            double prumer = Prumer(cislo1, cislo2, cislo3);

            // Zobrazení výsledku v MessageBoxu
            MessageBox.Show($"Aritmetický průměr čísel {cislo1}, {cislo2} a {cislo3} je: {prumer}", "Výsledek");
        }

        private double Prumer(double cislo1, double cislo2, double cislo3)
        {
            return (cislo1 + cislo2 + cislo3) / 3.0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int cislo))
            {
                // Kontrola, zda je číslo prvočíslo
                if (JePrvocislo(cislo))
                {
                    MessageBox.Show($"{cislo} je prvočíslo.", "Výsledek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{cislo} není prvočíslo.", "Výsledek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Neplatný vstup.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metoda pro ověření, zda je číslo prvočíslo
        private bool JePrvocislo(int cislo)
        {
            if (cislo <= 1)
            {
                return false;
            }

            // Procházení čísel od 2 do odmocniny ze zadaného čísla
            for (int i = 2; i <= Math.Sqrt(cislo); i++)
            {
                if (cislo % i == 0)
                {
                    return false; // Číslo není prvočíslo
                }
            }

            return true; // Číslo je prvočíslo
        }
    }
}

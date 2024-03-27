using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int cislo;
            if (!int.TryParse(textBox1.Text, out cislo))
            {
                MessageBox.Show("Neplatný vstupní formát! Zadejte platné celé číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Zjištění, zda je číslo liché
            bool liche = JeLiche(cislo);

            // Zobrazení výsledku o tom, zda je číslo liché v MessageBoxu
            MessageBox.Show($"Číslo {cislo} je {(liche ? "liché" : "sudé")}.", "Výsledek");
        }

        // Metoda pro zjištění, zda je číslo liché
        private bool JeLiche(int cislo)
        {
            return cislo % 2 != 0;
        }
    }
}

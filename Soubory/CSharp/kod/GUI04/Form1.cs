using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double cislo1) &&
                double.TryParse(textBox2.Text, out double cislo2) &&
                double.TryParse(textBox3.Text, out double cislo3) &&
                double.TryParse(textBox4.Text, out double cislo4))
            {
                // Počet záporných čísel
                int pocetZapornych = 0;
                if (cislo1 < 0) pocetZapornych++;
                if (cislo2 < 0) pocetZapornych++;
                if (cislo3 < 0) pocetZapornych++;
                if (cislo4 < 0) pocetZapornych++;

                // Součin kladných čísel
                double soucinKladnych = 1;
                if (cislo1 > 0) soucinKladnych *= cislo1;
                if (cislo2 > 0) soucinKladnych *= cislo2;
                if (cislo3 > 0) soucinKladnych *= cislo3;
                if (cislo4 > 0) soucinKladnych *= cislo4;

                // Vypsání výsledků pomocí MessageBox
                MessageBox.Show($"Počet záporných čísel: {pocetZapornych}\nSoučin kladných čísel: {soucinKladnych}");
            }
            else
            {
                MessageBox.Show("Neplatný vstup. Zadejte prosím platná čísla.");
            }
        }
    }
}

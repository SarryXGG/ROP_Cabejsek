using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int zaklad) && int.TryParse(textBox2.Text, out int exponent))
            {
                // Výpočet mocniny
                int vysledek = Mocnina(zaklad, exponent);

                // Zobrazení výsledku v MessageBoxu
                MessageBox.Show($"Mocnina {zaklad}^{exponent} je {vysledek}", "Výsledek");
            }
            else
            {
                // Pokud uživatel nezadá platná čísla, zobrazíme chybovou zprávu
                MessageBox.Show("Zadejte platná celá čísla do obou polí.", "Chyba");
            }
        }

        // Metoda pro výpočet celočíselné mocniny
        static int Mocnina(int zaklad, int exponent)
        {
            // Pokud je exponent roven 0, vrátíme 1
            if (exponent == 0)
                return 1;

            // Inicializujeme výsledek na základ
            int vysledek = zaklad;

            // Postupně násobíme základ sám sebou dle hodnoty exponentu
            for (int i = 1; i < exponent; i++)
            {
                vysledek *= zaklad;
            }

            return vysledek;
        }
    }
}

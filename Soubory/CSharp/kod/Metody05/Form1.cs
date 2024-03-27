using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody05
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
                // Výpočet faktoriálu
                long faktorial = Faktorial(cislo);

                // Zobrazení výsledku v MessageBoxu
                MessageBox.Show($"Faktoriál čísla {cislo} je {faktorial}", "Výsledek");
            }
            else
            {
                // Pokud uživatel nezadá platné číslo, zobrazíme chybovou zprávu
                MessageBox.Show("Zadejte platné celé číslo do pole.", "Chyba");
            }
        }

        // Metoda pro výpočet faktoriálu
        static long Faktorial(int cislo)
        {
            // Pokud je zadané číslo menší než 0, vrátíme -1 (chyba)
            if (cislo < 0)
                return -1;

            // Inicializace faktoriálu na 1
            long faktorial = 1;

            // Výpočet faktoriálu
            for (int i = 2; i <= cislo; i++)
            {
                faktorial *= i;
            }

            return faktorial;
        }
    }
}

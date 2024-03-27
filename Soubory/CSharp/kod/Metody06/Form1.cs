using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody06
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
                // Výpočet ciferného součtu lichých cifer
                int soucet = CifLichSoucet(cislo);

                // Zobrazení výsledku pomocí MessageBoxu
                MessageBox.Show($"Ciferný součet lichých cifer čísla {cislo} je: {soucet}");
            }
            else
            {
                MessageBox.Show("Zadáno neplatné číslo.");
            }
        }

        // Metoda pro výpočet ciferného součtu lichých cifer
        private int CifLichSoucet(int cislo)
        {
            // Převedeme číslo na řetězec pro snadnější manipulaci
            string cisloStr = Math.Abs(cislo).ToString();

            // Inicializace ciferného součtu
            int soucet = 0;

            // Projdeme všechny cifry čísla a sečteme liché
            foreach (char c in cisloStr)
            {
                if ((c - '0') % 2 != 0)
                {
                    soucet += c - '0'; // Převedeme znak na číslo
                }
            }

            return soucet;
        }
    }
}

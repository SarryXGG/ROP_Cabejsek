using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Načtení celých čísel ze vstupních textových polí
                int cislo1 = int.Parse(textBox1.Text);
                int cislo2 = int.Parse(textBox2.Text);

                // Aritmetické operace
                int soucet = checked(cislo1 + cislo2); // Kontrola přetečení
                int rozdil = checked(cislo1 - cislo2); // Kontrola přetečení
                int soucin = checked(cislo1 * cislo2); // Kontrola přetečení
                int podil = cislo1 / cislo2; // Neřešíme přetečení, dělení nulou způsobí výjimku

                // Výpis výsledků
                MessageBox.Show($"Součet: {soucet}\nRozdíl: {rozdil}\nSoučin: {soucin}\nPodíl: {podil}");
            }
            catch (FormatException ex)
            {
                // Chyba v zadání čísla, obsahuje neplatné znaky
                MessageBox.Show($"Chyba v zadání čísla: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                // Přetečení při aritmetické operaci
                MessageBox.Show($"Přetečení při aritmetické operaci: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                // Dělení nulou
                MessageBox.Show($"Dělení nulou: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Nečekaná chyba
                MessageBox.Show($"Neočekávaná chyba: {ex.Message}");
            }
        }
    }
}

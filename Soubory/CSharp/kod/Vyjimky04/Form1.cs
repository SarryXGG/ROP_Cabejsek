using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky04
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
                // Načtení hodnoty n z textBox2
                int n = int.Parse(textBox2.Text);

                // Proměnná pro uchování součtu
                long soucet = 0;

                // Procházení řádků textBoxu1
                string[] radky = textBox1.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (n > radky.Length)
                {
                    // Pokud n je větší než počet řádků v textBox1, oznamte to a vypočítejte součet ze všech řádků
                    MessageBox.Show("TextBox1 nemá dostatek řádků pro výpočet součtu.");
                    foreach (string radek in radky)
                    {
                        soucet += long.Parse(radek);
                    }
                }
                else
                {
                    // Pokud n je menší nebo rovno počtu řádků v textBox1, vypočítejte součet prvních n čísel
                    for (int i = 0; i < n; i++)
                    {
                        soucet += long.Parse(radky[i]);
                    }
                }

                // Zobrazení součtu
                MessageBox.Show($"Součet prvních {n} čísel z textBox1: {soucet}");
            }
            catch (FormatException)
            {
                // Chyba při načítání n ze textBox2
                MessageBox.Show("Chyba při načítání hodnoty n.");
            }
            catch (OverflowException)
            {
                // Přetečení součtu
                MessageBox.Show("Došlo k přetečení součtu.");
            }
            catch (Exception ex)
            {
                // Neočekávaná chyba
                MessageBox.Show($"Neočekávaná chyba: {ex.Message}");
            }
        }
    }
}

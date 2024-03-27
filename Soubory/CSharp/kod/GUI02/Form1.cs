using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Načtení poloměru a výšky ze vstupních TextBoxů
            if (double.TryParse(textBox1.Text, out double radius) && double.TryParse(textBox2.Text, out double height))
            {
                // Výpočet povrchu válce
                double surfaceArea = 2 * Math.PI * radius * (radius + height);

                // Výpočet objemu válce
                double volume = Math.PI * radius * radius * height;

                // Zobrazení výsledků výpočtu v Label
                label1.Text = $"Povrch válce: {surfaceArea} {GetUnit()}^2";
                label2.Text = $"Objem válce: {volume} {GetUnit()}^3";
            }
            else
            {
                MessageBox.Show("Zadejte platná čísla.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metoda pro získání jednotky podle výběru
        private string GetUnit()
        {
            // Zde můžete upravit jednotku podle potřeby
            return "cm"; // Použijeme centimetry jako výchozí jednotku
        }
    }
}

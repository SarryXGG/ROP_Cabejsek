using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextoveSoubory04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "Text.txt";

            // Načtení obsahu původního souboru do listBox1
            listBox1.Items.Clear();
            listBox1.Items.AddRange(File.ReadAllLines(filePath));

            // Nový obsah pro listBox2
            listBox2.Items.Clear();

            // Proměnná pro součet čísel
            int soucet = 0;

            try
            {
                // Otevření souboru pro čtení a zápis
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    // Projdeme všechny řádky v původním souboru
                    foreach (string line in File.ReadAllLines(filePath))
                    {
                        int number;
                        // Pokusíme se převést řádek na celé číslo
                        if (int.TryParse(line, out number))
                        {
                            // Pokud se podaří převést, přičteme ho k součtu
                            soucet += number;
                        }
                        else
                        {
                            // Pokud se nepodaří převést, zůstane součet beze změny a řádek nepřidáme do nového souboru
                            continue;
                        }
                    }

                    // Zápis součtu na konec souboru
                    sw.WriteLine($"Součet čísel: {soucet}");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Soubor Text.txt nebyl nalezen.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Neočekávaná chyba: {ex.Message}");
            }

            // Zobrazení součtu v listBox2
            listBox2.Items.Add($"Součet čísel: {soucet}");
        }
    
    }
}

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

namespace TextoveSoubory01
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
                // Načtení obsahu textového souboru
                string[] lines = File.ReadAllLines("Text.txt");
                string text = File.ReadAllText("Text.txt");

                // Pokud je vybráno zpracování znak po znaku
                if (radioButton1.Checked)
                {
                    int charCount = text.Length;
                    MessageBox.Show($"Počet znaků v souboru: {charCount}");
                }
                // Pokud je vybráno zpracování po řádcích
                else if (radioButton2.Checked)
                {
                    int lineCount = lines.Length;
                    MessageBox.Show($"Počet řádků v souboru: {lineCount}");
                }
                else
                {
                    MessageBox.Show("Vyberte, jak chcete zpracovat soubor (znak po znaku / po řádcích).");
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
        }
    }
}

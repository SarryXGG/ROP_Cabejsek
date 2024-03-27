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

namespace TextoveSoubory03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Textové soubory (*.txt)|*.txt";
            openFileDialog1.Title = "Vyberte textový soubor";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                try
                {
                    // Přečtení obsahu souboru
                    string text = File.ReadAllText(filename);

                    // Rozdělení textu na slova
                    string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Počet slov
                    int wordCount = words.Length;

                    // Zápis počtu slov na konec souboru
                    using (StreamWriter writer = File.AppendText(filename))
                    {
                        writer.WriteLine($"Počet slov: {wordCount}");
                    }

                    MessageBox.Show($"Počet slov v souboru {filename}: {wordCount}", "Výsledek", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Zobrazení obsahu opraveného souboru
                    string correctedText = File.ReadAllText(filename);
                    textBox1.Text = correctedText;
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Chyba při čtení/skrvání souboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

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

namespace TextoveSoubory05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Textové soubory (*.txt)|*.txt|Všechny soubory (*.*)|*.*";
            openFileDialog.Title = "Vyberte textový soubor";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string soubor = openFileDialog.FileName;

                    // Přečtení obsahu textového souboru a zobrazení v ListBoxu
                    using (StreamReader sr = new StreamReader(soubor))
                    {
                        string radek;
                        while ((radek = sr.ReadLine()) != null)
                        {
                            listBox1.Items.Add(radek);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba při čtení souboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Textové soubory (*.txt)|*.txt|Všechny soubory (*.*)|*.*";
            saveFileDialog.Title = "Uložte textový soubor";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string soubor = saveFileDialog.FileName;

                    // Získání obsahu ListBoxu a odstranění nadbytečných mezer
                    string obsah = "";
                    foreach (string item in listBox1.Items)
                    {
                        string cleanedLine = CleanUpLine(item);
                        obsah += cleanedLine + Environment.NewLine;
                    }

                    // Uložení obsahu do nového textového souboru
                    File.WriteAllText(soubor, obsah);
                    MessageBox.Show("Soubor byl úspěšně uložen.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba při ukládání souboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string CleanUpLine(string line)
        {
            string cleanedLine = "";
            bool prevCharWasSpace = false;

            foreach (char c in line)
            {
                if (c != ' ')
                {
                    cleanedLine += c;
                    prevCharWasSpace = false;
                }
                else
                {
                    if (!prevCharWasSpace)
                    {
                        cleanedLine += c;
                        prevCharWasSpace = true;
                    }
                }
            }

            return cleanedLine;
        }
    }
}

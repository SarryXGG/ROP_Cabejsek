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

namespace TextoveSoubory02
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
                string soubor = openFileDialog.FileName;
                int pocetRadku = 0;

                try
                {
                    using (StreamReader sr = new StreamReader(soubor))
                    {
                        string radek;
                        while ((radek = sr.ReadLine()) != null)
                        {
                            // Kontrola, zda řádek začíná velkým písmenem a končí právě jednou tečkou
                            if (char.IsUpper(radek[0]) && radek.EndsWith("."))
                            {
                                int pocetTecek = 0;
                                foreach (char znak in radek)
                                {
                                    if (znak == '.')
                                    {
                                        pocetTecek++;
                                    }
                                }
                                if (pocetTecek == 1)
                                {
                                    pocetRadku++;
                                }
                            }
                        }
                    }

                    MessageBox.Show($"Počet řádků začínajících velkým písmenem a končících jednou tečkou: {pocetRadku}", "Výsledek", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

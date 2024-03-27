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

namespace Vyjimky05
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
                string soubor = "Osoby.txt";

                if (!File.Exists(soubor))
                {
                    throw new FileNotFoundException("Soubor osoby.txt neexistuje.");
                }

                int pocetOsob = 0;
                double soucetVeku = 0;

                using (StreamReader sr = new StreamReader(soubor))
                {
                    string radek;
                    while ((radek = sr.ReadLine()) != null)
                    {
                        DateTime datumNarozeni;
                        if (DateTime.TryParse(radek, out datumNarozeni))
                        {
                            TimeSpan rozdil = DateTime.Today - datumNarozeni;
                            double vek = rozdil.TotalDays / 365.25;
                            soucetVeku += vek;
                            pocetOsob++;
                        }
                        else
                        {
                            throw new FormatException("Neplatny format data v souboru.");
                        }
                    }
                }

                double prumernyVek = soucetVeku / pocetOsob;
                MessageBox.Show("Prumerny vek osob z textoveho souboru je: " + prumernyVek + "Vysledek");
            }
            catch (FileNotFoundException exxx)
            {
                MessageBox.Show("Chyba: " + exxx.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Chyba: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exx)
            {
                MessageBox.Show("Neocekavana chyba: " + exx.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

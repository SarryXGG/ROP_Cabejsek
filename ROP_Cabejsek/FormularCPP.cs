using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace ROP_Cabejsek
{
    public partial class FormularCPP : Form
    {
        public FormularCPP()
        {
            InitializeComponent();
        }

        private void vypsaniPrikladu()
        { 
        }

        private void FormularCPP_Load(object sender, EventArgs e)
        {

        }

        

        private void FormularCPP_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
        Priklady formPriklady = new Priklady();
        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\PrikladySekvence.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split('/');

                    int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
                    int currentTop = 10; // Počáteční vertikální pozice

                    for (int i = 0; i < sts.Length; i++)
                    {
                        Label labelNazev = new Label();
                        labelNazev.Text = "Příklad č." + (i + 1);
                        labelNazev.AutoSize = true;
                        labelNazev.Top = currentTop;

                        formPriklady.Controls.Add(labelNazev);
                        currentTop += verticalSpacing;


                        TextBox tb = new TextBox();
                        tb.Multiline = true; // Použití víceřádkového textového pole
                        tb.ScrollBars = ScrollBars.Vertical; // Přidání svislého skrolování, pokud text přesahuje
                        tb.Text = sts[i];

                        // Nastavení šířky textového pole na šířku formuláře s odčtením mezery (např. 20)
                        tb.Width = formPriklady.ClientSize.Width - 20;

                        tb.Height = 60; // Nastavení výšky textového pole
                        tb.Top = currentTop;
                        tb.ReadOnly = true;

                        formPriklady.Controls.Add(tb);
                        currentTop += tb.Height + verticalSpacing;
                    }
                }

                formPriklady.ShowDialog();
            }
        }
    }
}

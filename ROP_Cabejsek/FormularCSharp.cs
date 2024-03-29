﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROP_Cabejsek
{
    public partial class FormularCSharp : Form
    {
        public FormularCSharp()
        {
            InitializeComponent();
        }
        Priklady formPriklady = new Priklady();
        string[] separators = { "\r\n", "\r", "\n" };

        

        private void FormularCSharp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        private void FormularCSharp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; 
            int currentTop = 10; 
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieGUI.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyGUI.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

                    for (int i = 0; i < sts.Length; i++)
                    {
                        Label labelNazev = new Label();
                        labelNazev.Text = "Příklad č." + (i + 1);
                        labelNazev.AutoSize = true;
                        labelNazev.Top = currentTop;

                        formPriklady.Controls.Add(labelNazev);
                        currentTop += verticalSpacing;


                        TextBox tb = new TextBox();
                        tb.Multiline = true; 
                        tb.ScrollBars = ScrollBars.Vertical; 
                        tb.Text = sts[i];
                        tb.Width = formPriklady.ClientSize.Width - 20;
                        tb.Height = 60; 
                        tb.Top = currentTop;
                        tb.ReadOnly = true;

                        formPriklady.Controls.Add(tb);
                        currentTop += tb.Height + verticalSpacing;
                    }
                }

                formPriklady.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieRidStruk.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyRidStruk.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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


        private void button3_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeoriePole.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyPole.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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

        private void button4_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieString.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyString.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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

        private void button5_Click(object sender, EventArgs e)
        {
            //zde byl github....
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieMetody.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyMetody.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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

        private void button7_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieList.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyList.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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

        private void button8_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieKnihovny.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyKnihovny.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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

        private void button9_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeoriePrvocisla.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyPrvocisla.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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

        private void button10_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieDatumACas.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyDatumACas.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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

        private void button11_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieOOP.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyOOP.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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

        private void button12_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieTextoveSoubory.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyTextoveSoubory.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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

        private void button13_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieDatoveSoubory.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyDatoveSoubory.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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

        private void button14_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieVyjimky.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyVyjimky.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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

        private void button15_Click(object sender, EventArgs e)
        {
            int verticalSpacing = 30; // Zvýšil jsem mezera mezi labely pro lepší čitelnost
            int currentTop = 10; // Počáteční vertikální pozice
            for (int i = formPriklady.Controls.Count - 1; i >= 0; i--)
            {
                Control control = formPriklady.Controls[i];

                // Pokud je ovládací prvek TextBox nebo Label, odstraň jej
                if (control is TextBox || control is Label)
                {
                    formPriklady.Controls.Remove(control);
                }
            }
            // Aktualizuje a překresluje formulář
            formPriklady.Refresh();

            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieFormulare.txt"))
            {
                string s;
                if (!srT.EndOfStream)
                {
                    s = srT.ReadToEnd();
                    //pridani teorie na zacatek label
                    Label labelTeorie = new Label();
                    labelTeorie.Text = "Teorie";
                    labelTeorie.AutoSize = true;
                    labelTeorie.Top = currentTop;
                    formPriklady.Controls.Add(labelTeorie);
                    currentTop += verticalSpacing;
                    //pridani tb s teorii
                    TextBox tba = new TextBox();
                    tba.Multiline = true;
                    tba.ScrollBars = ScrollBars.Vertical;
                    tba.Text = s;
                    tba.Width = formPriklady.ClientSize.Width - 20;
                    tba.Height = 60;
                    tba.Top = currentTop;
                    tba.ReadOnly = true;
                    formPriklady.Controls.Add(tba);
                    currentTop += tba.Height + verticalSpacing;
                }
            }


            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyFormulare.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split(separators, StringSplitOptions.None);

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

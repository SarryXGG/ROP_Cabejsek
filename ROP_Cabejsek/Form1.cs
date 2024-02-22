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
using System.Drawing.Printing;
using System.Diagnostics;


namespace ROP_Cabejsek
{
    public class ScrollableMessageBoxForm : Form
    {
        private TextBox textBox;
        private Button okButton;

        public string MessageText
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public ScrollableMessageBoxForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Scrollable MessageBox";
            this.Size = new System.Drawing.Size(400, 300);

            textBox = new TextBox();
            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Dock = DockStyle.Fill;
            textBox.ReadOnly = true;

            okButton = new Button();
            okButton.Text = "OK";
            okButton.Dock = DockStyle.Bottom;
            okButton.Click += (sender, e) => this.Close();

            this.Controls.Add(textBox);
            this.Controls.Add(okButton);
        }
    }
    public partial class Form1 : Form
    {
        private void ShowScrollableMessageBox(string text)
        {
            using (ScrollableMessageBoxForm scrollableMessageBox = new ScrollableMessageBoxForm())
            {
                scrollableMessageBox.MessageText = text;
                scrollableMessageBox.ShowDialog();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        string[] separators = { "\r\n", "\r", "\n" };
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        FormularCPP formCPP = new FormularCPP();
        FormPridat formPridat = new FormPridat();
        FormularCSharp formCSharp = new FormularCSharp();
        string textToPrint;

        private void button1_Click(object sender, EventArgs e)
        {
            if (formCPP.Visible)
            {
                formCPP.Activate();
            }
            else
            {
                formCPP = new FormularCPP();
                formCPP.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formCSharp.Visible)
            {
                formCSharp.Activate();
            }
            else
            {
                formCSharp = new FormularCSharp();
                formCSharp.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string vybranaHodnota = comboBox2.Text;
            string vybraneTema = comboBox1.Text;
            int cislo = 0;

            switch (vybranaHodnota)
            {
                case "Teorie":
                    cislo = 0;
                    break;
                case "Příklad 1":
                    cislo = 1;
                    break;
                case "Příklad 2":
                    cislo = 2;
                    break;
                case "Příklad 3":
                    cislo = 3;
                    break;
                case "Příklad 4":
                    cislo = 4;
                    break;
                case "Příklad 5":
                    cislo = 5;
                    break;
                case "Příklad 6":
                    cislo = 6;
                    break;
                case "Příklad 7":
                    cislo = 7;
                    break;
                default: 
                    break;
            }

            switch (vybraneTema)
            {
                case "C++ Sekvence":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieSekvence.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySekvence.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C++ Selekce":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieSelekce.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySelekce.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C++ Cykly":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieCykly.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyCykly.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C++ Switch":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieSwitch.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySwitch.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;
                case "C++ Printf":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeoriePrintf.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPrintf.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C++ N-prvková posloupnost":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieNposl.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyNposl.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C++ Posloupnost Zakončená Hodnotou":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeoriePoslZaHodn.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPoslZaHodn.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C++ Jednoduché Datové Typy":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieJednoDatTyp.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyJednoDatTyp.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C++ Pole":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeoriePole.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPole.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C++ Funkce":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieFce.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyFce.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# GUI":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieGUI.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyGUI.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# Řídící Struktury":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieRidStruk.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyRidStruk.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# Pole":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeoriePole.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyPole.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# String":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieString.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyString.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# Metody":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieMetody.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyMetody.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# List":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieList.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyList.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;
                case "C# Knihovny":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieKnihovny.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyKnihovny.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# Prvočísla":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeoriePrvocisla.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyPrvocisla.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# Datum A Čas":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieDatumACas.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyDatumACas.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# OOP":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieOOP.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyOOP.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# Textové Soubory":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieTextoveSoubory.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyTextoveSoubory.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# Datové Soubory":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieDatoveSoubory.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyDatoveSoubory.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# Vyjimky":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieVyjimky.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyVyjimky.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                case "C# Formuláře":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieFormulare.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    MessageBox.Show(s);
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyFormulare.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                MessageBox.Show(sts[cislo - 1]);
                            }
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string vybranaHodnota = comboBox2.Text;
            string vybraneTema = comboBox1.Text;
            int cislo = 0;

            switch (vybranaHodnota)
            {
                case "Teorie":
                    cislo = 0;
                    break;
                case "Příklad 1":
                    cislo = 1;
                    break;
                case "Příklad 2":
                    cislo = 2;
                    break;
                case "Příklad 3":
                    cislo = 3;
                    break;
                case "Příklad 4":
                    cislo = 4;
                    break;
                case "Příklad 5":
                    cislo = 5;
                    break;
                case "Příklad 6":
                    cislo = 6;
                    break;
                case "Příklad 7":
                    cislo = 7;
                    break;
                default:
                    break;
            }

            switch (vybraneTema)
            {
                case "C++ Sekvence":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieSekvence.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySekvence.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C++ Selekce":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieSelekce.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySelekce.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C++ Cykly":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieCykly.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyCykly.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C++ Switch":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieSwitch.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySwitch.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;
                case "C++ Printf":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeoriePrintf.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPrintf.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C++ N-prvková posloupnost":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieNposl.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyNposl.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C++ Posloupnost Zakončená Hodnotou":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeoriePoslZaHodn.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPoslZaHodn.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C++ Jednoduché Datové Typy":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieJednoDatTyp.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyJednoDatTyp.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C++ Pole":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeoriePole.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPole.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C++ Funkce":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CPP\TeorieFce.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyFce.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# GUI":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieGUI.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyGUI.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# Řídící Struktury":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieRidStruk.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyRidStruk.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# Pole":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeoriePole.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyPole.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# String":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieString.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyString.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# Metody":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieMetody.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyMetody.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# List":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieList.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyList.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;
                case "C# Knihovny":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieKnihovny.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyKnihovny.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# Prvočísla":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeoriePrvocisla.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyPrvocisla.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# Datum A Čas":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieDatumACas.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyDatumACas.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# OOP":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieOOP.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyOOP.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# Textové Soubory":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieTextoveSoubory.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyTextoveSoubory.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# Datové Soubory":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieDatoveSoubory.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyDatoveSoubory.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# Vyjimky":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieVyjimky.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyVyjimky.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                case "C# Formuláře":
                    {
                        if (cislo == 0)
                        {
                            using (StreamReader srT = new StreamReader(@"..\..\..\Soubory\CSharp\TeorieFormulare.txt"))
                            {
                                string s;
                                if (!srT.EndOfStream)
                                {
                                    s = srT.ReadToEnd();
                                    textToPrint = s;
                                }
                            }
                        }
                        else if (cislo > 0)
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyFormulare.txt"))
                            {
                                string s;
                                string[] sts;
                                s = sr.ReadToEnd();
                                sts = s.Split(separators, StringSplitOptions.None);
                                textToPrint = sts[cislo - 1];
                            }
                        }
                    }
                    break;

                default:
                    break;
            }
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Arial", 12);
            //float leftMargin = e.MarginBounds.Left;
            //float topMargin = e.MarginBounds.Top;
            //float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            RectangleF printArea = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);
            e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, printArea);

                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (formPridat.Visible)
            {
                formPridat.Activate();
            }
            else
            {
                formPridat = new FormPridat();
                formPridat.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string vybranaHodnota = comboBox2.Text;
            string vybraneTema = comboBox1.Text;
            int cislo = 0;

            switch (vybranaHodnota)
            {
                case "Teorie":
                    cislo = 0;
                    break;
                case "Příklad 1":
                    cislo = 1;
                    break;
                case "Příklad 2":
                    cislo = 2;
                    break;
                case "Příklad 3":
                    cislo = 3;
                    break;
                case "Příklad 4":
                    cislo = 4;
                    break;
                case "Příklad 5":
                    cislo = 5;
                    break;
                case "Příklad 6":
                    cislo = 6;
                    break;
                case "Příklad 7":
                    cislo = 7;
                    break;
                default:
                    break;
            }
            if (cislo != 0)
            {
                switch (vybraneTema)
                {
                    case "C++ Sekvence":
                        {

                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySekvence.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ Selekce":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySelekce.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ Cykly":
                        {
                            
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyCykly.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ Switch":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySwitch.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;
                    case "C++ Printf":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPrintf.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ N-prvková posloupnost":
                        {
                            
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyNposl.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ Posloupnost Zakončená Hodnotou":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPoslZaHodn.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ Jednoduché Datové Typy":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyJednoDatTyp.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ Pole":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPole.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ Funkce":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyFce.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# GUI":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyGUI.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# Řídící Struktury":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyRidStruk.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# Pole":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyPole.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# String":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyString.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# Metody":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyMetody.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# List":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyList.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;
                    case "C# Knihovny":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyKnihovny.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# Prvočísla":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyPrvocisla.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# Datum A Čas":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyDatumACas.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# OOP":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyOOP.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# Textové Soubory":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyTextoveSoubory.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# Datové Soubory":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyDatoveSoubory.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# Vyjimky":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CSharp\PrikladyVyjimky.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C# Formuláře":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    if (System.IO.File.Exists(@"..\..\..\Soubory\CSharp\exe\Formulare01.exe"))
                                    {
                                        Process.Start(@"..\..\..\Soubory\CSharp\exe\Formulare01.exe");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Soubor nebyl nalezen.");
                                    }
                                    break;
                                case 2:
                                    if (System.IO.File.Exists(@"..\..\..\Soubory\CSharp\exe\Formulare02.exe"))
                                    {
                                        Process.Start(@"..\..\..\Soubory\CSharp\exe\Formulare02.exe");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Soubor nebyl nalezen.");
                                    }
                                    break;
                                case 3:
                                    if (System.IO.File.Exists(@"..\..\..\Soubory\CSharp\exe\Formulare03.exe"))
                                    {
                                        Process.Start(@"..\..\..\Soubory\CSharp\exe\Formulare03.exe");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Soubor nebyl nalezen.");
                                    }
                                    break;
                                case 4:
                                    if (System.IO.File.Exists(@"..\..\..\Soubory\CSharp\exe\Formulare04.exe"))
                                    {
                                        Process.Start(@"..\..\..\Soubory\CSharp\exe\Formulare04.exe");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Soubor nebyl nalezen.");
                                    }
                                    break;
                                case 5:
                                    if (System.IO.File.Exists(@"..\..\..\Soubory\CSharp\exe\Formulare05.exe"))
                                    {
                                        Process.Start(@"..\..\..\Soubory\CSharp\exe\Formulare05.exe");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Soubor nebyl nalezen.");
                                    }
                                    break;
                                case 6:
                                    if (System.IO.File.Exists(@"..\..\..\Soubory\CSharp\exe\Formulare06.exe"))
                                    {
                                        Process.Start(@"..\..\..\Soubory\CSharp\exe\Formulare06.exe");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Soubor nebyl nalezen.");
                                    }
                                    break;
                                case 7:
                                    if (System.IO.File.Exists(@"..\..\..\Soubory\CSharp\exe\Formulare07.exe"))
                                    {
                                        Process.Start(@"..\..\..\Soubory\CSharp\exe\Formulare07.exe");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Soubor nebyl nalezen.");
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    default:
                        break;
                }

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string vybranaHodnota = comboBox2.Text;
            string vybraneTema = comboBox1.Text;
            int cislo = 0;

            switch (vybranaHodnota)
            {
                case "Teorie":
                    cislo = 0;
                    break;
                case "Příklad 1":
                    cislo = 1;
                    break;
                case "Příklad 2":
                    cislo = 2;
                    break;
                case "Příklad 3":
                    cislo = 3;
                    break;
                case "Příklad 4":
                    cislo = 4;
                    break;
                case "Příklad 5":
                    cislo = 5;
                    break;
                case "Příklad 6":
                    cislo = 6;
                    break;
                case "Příklad 7":
                    cislo = 7;
                    break;
                default:
                    break;
            }
            if (cislo != 0)
            {
                switch (vybraneTema)
                {
                    case "C++ Sekvence":
                        {

                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySekvence.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ Selekce":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySelekce.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ Cykly":
                        {

                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyCykly.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ Switch":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySwitch.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;
                    case "C++ Printf":
                        {
                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPrintf.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ N-prvková posloupnost":
                        {

                            if (cislo > 0)
                            {
                                using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyNposl.txt"))
                                {
                                    string s;
                                    string[] sts;
                                    s = sr.ReadToEnd();
                                    sts = s.Split(separators, StringSplitOptions.None);
                                    textToPrint = sts[cislo - 1];
                                }
                            }
                        }
                        break;

                    case "C++ Posloupnost Zakončená Hodnotou":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\PoslZakHodn01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\PoslZakHodn02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\PoslZakHodn03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\PoslZakHodn04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\PoslZakHodn05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\PoslZakHodn06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\PoslZakHodn07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C++ Jednoduché Datové Typy":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\JedDatTyp01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\JedDatTyp02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\JedDatTyp03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\JedDatTyp04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\JedDatTyp05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\JedDatTyp06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\JedDatTyp07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C++ Pole":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Pole01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Pole02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Pole03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Pole04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Pole05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Pole06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Pole07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C++ Funkce":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Funkce01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Funkce02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Funkce03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Funkce04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Funkce05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Funkce06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CPP\kod\Funkce07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C# GUI":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\GUI01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\GUI02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\GUI03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\GUI04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\GUI05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\GUI06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\GUI07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C# Řídící Struktury":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\RidStruk01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\RidStruk02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\RidStruk03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\RidStruk04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\RidStruk05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\RidStruk06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\RidStruk07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C# Pole":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Pole01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Pole02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Pole03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Pole04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Pole05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Pole06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Pole07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C# String":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\String01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\String02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\String03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\String04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\String05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\String06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\String07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C# Metody":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Metody01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Metody02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Metody03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Metody04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Metody05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Metody06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Metody07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C# List":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\List01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\List02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\List03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\List04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\List05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\List06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\List07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;
                    case "C# Knihovny":
                        {
                            MessageBox.Show("u knihoven kod zobrazit nelze");
                        }
                        break;

                    case "C# Prvočísla":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Prvocisla01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Prvocisla02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Prvocisla03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Prvocisla04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Prvocisla05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Prvocisla06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Prvocisla07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C# Datum A Čas":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatumACas01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatumACas02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatumACas03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatumACas04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatumACas05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatumACas06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatumACas07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C# OOP":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\OOP01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\OOP02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\OOP03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\OOP04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\OOP05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\OOP06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\OOP07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C# Textové Soubory":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\TextoveSoubory01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\TextoveSoubory02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\TextoveSoubory03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\TextoveSoubory04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\TextoveSoubory05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\TextoveSoubory06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\TextoveSoubory07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C# Datové Soubory":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatoveSoubory01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatoveSoubory02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatoveSoubory03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatoveSoubory04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatoveSoubory05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatoveSoubory06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\DatoveSoubory07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case "C# Vyjimky":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Vyjimky01\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }

                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Vyjimky02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Vyjimky03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Vyjimky04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Vyjimky05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Vyjimky06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Vyjimky07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;

                    case "C# Formuláře":
                        {
                            switch (cislo)
                            {
                                case 1:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Formulare01\Form1.cs", FileMode.Open,FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                   
                                    break;
                                case 2:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Formulare02\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 3:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Formulare03\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 4:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Formulare04\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 5:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Formulare05\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 6:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Formulare06\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                case 7:
                                    using (FileStream fs = new FileStream(@"..\..\..\Soubory\CSharp\kod\Formulare07\Form1.cs", FileMode.Open, FileAccess.Read))
                                    {
                                        using (StreamReader sr = new StreamReader(fs))
                                        {
                                            string obsahSouboru = sr.ReadToEnd();
                                            ShowScrollableMessageBox(obsahSouboru);
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    default:
                        break;
                }

            }
        }
    }
}

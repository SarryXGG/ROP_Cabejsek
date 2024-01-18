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

namespace ROP_Cabejsek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] separators = { "\r\n", "\r", "\n" };
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        FormularCPP formCPP = new FormularCPP();
        FormularCSharp formCSharp = new FormularCSharp();

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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
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
                                for (int i = 1; i < 20; i++)
                                {
                                    if (cislo == i)
                                    {
                                        MessageBox.Show(sts[cislo - 1]);
                                    }
                                }
                            }
                        }
                    }
                    break;

                default:
                    break;
            }
        }
    }
}

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
    public partial class FormPridat : Form
    {
        public FormPridat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pomoc = "";
            if (comboBox3.Text != "")
            {
                
                MessageBox.Show(comboBox3.Text.ToString());
                string vybraneTema = comboBox3.Text;
                switch (vybraneTema)
                {
                    case "C++ Sekvence":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySekvence.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladySekvence.txt"))
                            {

                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C++ Selekce":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySelekce.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladySelekce.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C++ Cykly":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyCykly.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyCykly.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C++ Switch":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladySwitch.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladySwitch.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;
                    case "C++ Printf":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPrintf.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyPrintf.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C++ N-prvková posloupnost":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyNposl.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyNposl.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C++ Posloupnost Zakončená Hodnotou":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPoslZaHodn.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyPoslZaHodn.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C++ Jednoduché Datové Typy":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyJednoDatTyp.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyJednoDatTyp.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C++ Pole":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPole.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyPole.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C++ Funkce":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyFce.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyFce.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# GUI":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyGUI.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyGUI.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# Řídící Struktury":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyRidStruk.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyRidStruk.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# Pole":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPole.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyPole.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# String":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyString.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyString.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# Metody":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyMetody.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyMetody.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# List":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyList.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyList.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;
                    case "C# Knihovny":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyKnihovny.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyKnihovny.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# Prvočísla":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyPrvocisla.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyPrvocisla.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# Datum A Čas":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyDatumACas.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyDatumACas.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# OOP":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyOOP.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyOOP.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# Textové Soubory":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyTextoveSoubory.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyTextoveSoubory.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# Datové Soubory":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyDatoveSoubory.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyDatoveSoubory.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# Vyjimky":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyVyjimky.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyVyjimky.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    case "C# Formuláře":
                        {
                            using (StreamReader sr = new StreamReader(@"..\..\..\Soubory\CPP\PrikladyFormulare.txt"))
                            {
                                while (!sr.EndOfStream)
                                {
                                    pomoc = sr.ReadToEnd();
                                }
                            }
                            using (StreamWriter sw = new StreamWriter(@"..\..\..\Soubory\CPP\PrikladyFormulare.txt"))
                            {
                                string s = textBox1.Text;
                                sw.Write(pomoc);
                                sw.WriteLine("\n" + s);
                            }
                        }
                        break;

                    default:
                        break;
                }

            }
            else
            {
                MessageBox.Show("neni vybrano kam se ma priklad zapsat");
            }
        }
    }

    }


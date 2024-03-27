using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROP_Cabejsek
{
    public partial class FormularTest : Form
    {
        public FormularTest()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            int hodnotaPromenne = 0;
            if (form1 != null)
            {
                hodnotaPromenne = form1.GetPromenna();
            }
            else
            {
                hodnotaPromenne = 0;
            }
            string vysledek = textBox1.Text.Trim();

            switch (hodnotaPromenne)
            {
                case 1:
                    if (vysledek == "b 3")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX a X2X je 'b 3' ");
                    }
                    break;

                case 2:
                    if (vysledek == "switch znak")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX a X2X je 'switch znak' ");
                    }
                    break;

                case 3:
                    if (vysledek == "for 10")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX a X2X je 'for 10' ");
                    }
                    break;

                case 4:
                    if (vysledek == "day case")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX a X2X je 'day case' ");
                    }
                    break;

                case 5:
                    if (vysledek == "d &")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX a X2X je 'd &' ");
                    }
                    break;

                case 6:
                    if (vysledek == "while n")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX a X2X je 'while n' ");
                    }
                    break;

                case 7:
                    if (vysledek == "0")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX je '0' ");
                    }
                    break;

                case 8:
                    MessageBox.Show("Jednoduche datove typy pouzivame stale neni potreba priklad");

                    break;

                case 9:
                    int vysledekC = 4;
                    if (vysledekC <= int.Parse(textBox1.Text))
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX je '4 nebo víc' ");
                    }
                    break;

                case 10:
                    if (vysledek == "return")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX je 'return' ");
                    }
                    break;

                case 11:
                    if (vysledek == "Show" || vysledek == "show")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX je 'show/Show' ");
                    }
                    break;

                case 12:
                    if (vysledek == "if else")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX a X2X je 'if else' ");
                    }
                    break;

                case 13:
                    if (vysledek == "[]")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX je '[]' ");
                    }
                    break;

                case 14:
                    if (vysledek == "Split")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX je 'Split' ");
                    }
                    break;

                case 15:
                    if (vysledek == "int void")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX a X2X je 'int void' ");
                    }
                    break;

                case 16:
                    if (vysledek == "<int> Add")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX a X2X je '<int> Add' ");
                    }
                    break;

                case 17:
                    if (vysledek == "sqrt")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX je 'sqrt' ");
                    }
                    break;

                case 18:
                    if (vysledek == "Now")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX je 'Now' ");
                    }
                    break;

                case 19:
                    if (vysledek == "get set")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX a X2X je 'get set' ");
                    }
                    break;

                case 20:
                    if (vysledek == "StreamWriter")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX je 'StreamWriter' ");
                    }
                    break;

                case 21:
                    if (vysledek == "BinaryWriter")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX je 'BinaryWriter' ");
                    }
                    break;

                case 22:
                    if (vysledek == "try catch")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX a X2X je 'try catch' ");
                    }
                    break;

                case 23:
                    if (vysledek == "object")
                    {
                        MessageBox.Show("Ano správně");
                    }
                    else
                    {
                        MessageBox.Show("Špatně XXX je 'object' ");
                    }
                    break;



                default:
                    break;
            }
        }
    }
}

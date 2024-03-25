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
                    break;

                case 4:
                    break;

                case 5:
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

                default:
                    break;
            }
        }
    }
}

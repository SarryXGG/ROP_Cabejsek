using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            try
            {
                // Rozdělení vstupu na operandy a operátor
                string[] parts = input.Split(new char[] { '+', '-', '*', '/' });

                // Převod operandů na reálná čísla
                double operand1 = double.Parse(parts[0]);
                double operand2 = double.Parse(parts[1]);

                // Zjištění operátoru
                char operation = input[parts[0].Length];

                // Provedení požadované operace
                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = operand1 + operand2;
                        break;
                    case '-':
                        result = operand1 - operand2;
                        break;
                    case '*':
                        result = operand1 * operand2;
                        break;
                    case '/':
                        // Ošetření dělení nulou
                        if (operand2 == 0)
                        {
                            MessageBox.Show("Nelze dělit nulou!");
                            return;
                        }
                        result = operand1 / operand2;
                        break;
                    default:
                        MessageBox.Show("Neplatná operace!");
                        return;
                }

                // Výpis výsledku
                MessageBox.Show($"Výsledek: {result}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Neplatný vstup!");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Neplatný vstup!");
            }
        }
    }
}

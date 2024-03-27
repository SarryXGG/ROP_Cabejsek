using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky03
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
                int a = int.Parse(textBox1.Text);
                int n = int.Parse(textBox2.Text);

                if (n == 0)
                {
                    textBox3.Text = $"Mocnina {a} na {n}-tou je: 1";
                    return;
                }

                long mocnina = 1;

                for (int i = 0; i < Math.Abs(n); i++)
                {
                    mocnina *= a;
                }

                if (n < 0)
                {
                    mocnina = 1 / mocnina; // Záporná mocnina -> výsledek je 1 děleno mocninou
                }

                textBox3.Text = $"Mocnina {a} na {n}-tou je: {mocnina}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Chyba: Neplatný vstupní formát dat.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Chyba: Přetečení při výpočtu mocniny.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

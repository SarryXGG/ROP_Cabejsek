using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky02
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
                int N = int.Parse(textBox1.Text);

                // Inicializace pole
                int[] posloupnost = new int[N];

                // Naplnění pole náhodnými čísly z intervalu <1, 20>
                Random rnd = new Random();
                listBox1.Items.Clear();
                for (int i = 0; i < N; i++)
                {
                    posloupnost[i] = rnd.Next(1, 21); // Interval <1, 20>
                    listBox1.Items.Add(posloupnost[i]);
                }

                // Umocnění prvního prvku pole na 6. prvek pole
                if (N >= 6)
                {
                    posloupnost[5] = (int)Math.Pow(posloupnost[0], posloupnost[5]);
                    label1.Text = "Prvni prvek pole umocneny na 6. prvek pole: " + posloupnost[5];
                }
                else
                {
                    throw new IndexOutOfRangeException("Chyba: Pole ma mene nez 6 prvku.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Chyba: Neplatny format vstupu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Chyba: Prekroceni rozsahu celeho cisla.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

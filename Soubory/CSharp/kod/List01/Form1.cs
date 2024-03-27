using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> seznamCisel = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            seznamCisel.Clear();
            int n;
            if (int.TryParse(textBox1.Text, out n))
            {
                Random rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    seznamCisel.Add(rand.Next(-5, 11));
                }
                MessageBox.Show("Seznam byl úspěšně vygenerován.", "Info");
            }
            else
            {
                MessageBox.Show("Chybný vstup, zadejte platné celé číslo.", "Chyba");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in seznamCisel)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seznamCisel.Clear();
            MessageBox.Show("Seznam byl vymazán.", "Info");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int max = seznamCisel.Max();
                seznamCisel.Remove(max);
                MessageBox.Show("Poslední maximum bylo vypuštěno.", "Info");
            }
            else if (radioButton2.Checked)
            {
                int min = seznamCisel.Min();
                seznamCisel.Remove(min);
                MessageBox.Show("Poslední minimum bylo vypuštěno.", "Info");
            }
            else
            {
                MessageBox.Show("Není vybrána žádná možnost.", "Upozornění");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            HashSet<int> uniqueNumbers = new HashSet<int>(seznamCisel);
            MessageBox.Show("Počet různých čísel v seznamu: " + uniqueNumbers.Count, "Počet různých čísel");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var counts = seznamCisel.GroupBy(x => x)
                                   .Select(group => new { Number = group.Key, Count = group.Count() })
                                   .OrderByDescending(x => x.Count);
            var maxCount = counts.First();
            MessageBox.Show($"Číslo s největším počtem výskytů: {maxCount.Number}, Počet výskytů: {maxCount.Count}", "Největší počet výskytů");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RidStruk03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = textBox1.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            double[] numbers = new double[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                if (!double.TryParse(lines[i], out numbers[i]))
                {
                    MessageBox.Show($"Chyba: Řádek {i + 1} neobsahuje platné číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Průměr čísel
            double average = numbers.Length > 0 ? numbers.Average() : 0;
            label1.Text = $"Průměr čísel: {average}";

            // Minimum čísel
            double minimum = numbers.Length > 0 ? numbers.Min() : 0;
            label2.Text = $"Minimum: {minimum}";

            // Počet čísel v intervalu <5, 30)
            int countInRange = numbers.Count(num => num >= 5 && num < 30);
            label3.Text = $"Počet čísel v intervalu <5, 30): {countInRange}";

            // Index prvního a posledního čísla 3 v TextBox
            int firstIndexOf3 = Array.IndexOf(numbers, 3);
            int lastIndexOf3 = Array.LastIndexOf(numbers, 3);
            label4.Text = firstIndexOf3 != -1 ? $"První index čísla 3: {firstIndexOf3}" : "Číslo 3 nenalezeno";
            label5.Text = lastIndexOf3 != -1 ? $"Poslední index čísla 3: {lastIndexOf3}" : "Číslo 3 nenalezeno";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Načtení tří čísel ze vstupních TextBoxů
            if (int.TryParse(textBox1.Text, out int number1) &&
                int.TryParse(textBox2.Text, out int number2) &&
                int.TryParse(textBox3.Text, out int number3))
            {
                int evenCount = CountEvenNumbers(number1, number2, number3); // Počet sudých čísel
                double averageOfOddNumbers = CalculateAverageOfOddNumbers(number1, number2, number3); // Aritmetický průměr lichých čísel

                // Zobrazení výstupu pomocí MessageBox
                MessageBox.Show($"Počet sudých čísel: {evenCount}\nAritmetický průměr lichých čísel je: {averageOfOddNumbers}",
                                "Výsledek",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zadejte platná čísla.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metoda pro výpočet počtu sudých čísel
        private int CountEvenNumbers(int num1, int num2, int num3)
        {
            int count = 0;
            if (num1 % 2 == 0) count++;
            if (num2 % 2 == 0) count++;
            if (num3 % 2 == 0) count++;
            return count;
        }

        // Metoda pro výpočet aritmetického průměru lichých čísel
        private double CalculateAverageOfOddNumbers(int num1, int num2, int num3)
        {
            int sum = 0;
            int count = 0;
            if (num1 % 2 != 0)
            {
                sum += num1;
                count++;
            }
            if (num2 % 2 != 0)
            {
                sum += num2;
                count++;
            }
            if (num3 % 2 != 0)
            {
                sum += num3;
                count++;
            }
            if (count == 0) return 0; // Pokud nejsou žádná lichá čísla, vrátíme 0
            return (double)sum / count;
        }
    }
}

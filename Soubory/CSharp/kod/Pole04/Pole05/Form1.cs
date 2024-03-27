using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int n))
            {
                double[] numbers = GenerateRandomNumbers(n);
                listBox1.Items.Clear();
                foreach (double number in numbers)
                {
                    listBox1.Items.Add(number);
                }

                // Najděte druhý nejmenší a druhý největší prvek
                double secondSmallest = numbers.OrderBy(num => num).Distinct().Skip(1).FirstOrDefault();
                double secondLargest = numbers.OrderByDescending(num => num).Distinct().Skip(1).FirstOrDefault();

                // Najděte indexy druhého nejmenšího a druhého největšího prvku
                int secondSmallestIndex = Array.IndexOf(numbers, secondSmallest);
                int secondLargestIndex = Array.IndexOf(numbers, secondLargest);

                // Prohoďte prvky na nalezených indexech
                double temp = numbers[secondSmallestIndex];
                numbers[secondSmallestIndex] = numbers[secondLargestIndex];
                numbers[secondLargestIndex] = temp;

                listBox2.Items.Clear();
                foreach (double number in numbers)
                {
                    listBox2.Items.Add(number);
                }
            }
            else
            {
                MessageBox.Show("Zadejte platné celé číslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double[] GenerateRandomNumbers(int n)
        {
            Random rand = new Random();
            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rand.NextDouble() * 100; // Náhodné reálné číslo v rozsahu [0, 100)
            }
            return numbers;
        }
    }
}

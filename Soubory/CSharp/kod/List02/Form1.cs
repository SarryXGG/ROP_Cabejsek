using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> numbers = GenerateRandomNumbersList();
            DisplayListInListBox(numbers, listBox1);

            List<int> modifiedNumbers = ModifyNumbersList(numbers);
            DisplayListInListBox(modifiedNumbers, listBox2);
        }

        private List<int> GenerateRandomNumbersList()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            int n = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i < n; i++)
            {
                numbers.Add(random.Next(-100, 101));
            }

            return numbers;
        }

        private void DisplayListInListBox(List<int> list, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (int number in list)
            {
                listBox.Items.Add(number);
            }
        }

        private List<int> ModifyNumbersList(List<int> numbers)
        {
            List<int> oddDivisibleBy3 = new List<int>();
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else if (number % 3 == 0)
                {
                    oddDivisibleBy3.Add(number);
                }
            }

            // Pokud jsou v seznamu lichá čísla dělitelná 3
            if (oddDivisibleBy3.Count > 0)
            {
                int minOddDivisibleBy3 = oddDivisibleBy3.Min();
                int maxEvenNumber = evenNumbers.Max();

                // Prohození hodnot
                int minIndex = numbers.IndexOf(minOddDivisibleBy3);
                int maxIndex = numbers.IndexOf(maxEvenNumber);

                numbers[minIndex] = maxEvenNumber;
                numbers[maxIndex] = minOddDivisibleBy3;
            }

            return numbers;
        }
    }
}

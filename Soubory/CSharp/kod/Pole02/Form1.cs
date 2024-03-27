using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string inputText = textBox1.Text;
            string[] numberStrings = inputText.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();

            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString, out int number))
                {
                    numbers.Add(number);
                }
            }

            // Vypsání čísel do prvního ListBoxu
            listBox1.Items.Clear();
            foreach (int number in numbers)
            {
                listBox1.Items.Add(number);
            }

            // Vynulování prvočísel v poli
            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    int index = numbers.IndexOf(number);
                    numbers[index] = 0;
                }
            }

            // Vypsání upravených čísel do druhého ListBoxu
            listBox2.Items.Clear();
            foreach (int number in numbers)
            {
                listBox2.Items.Add(number);
            }
        }

        // Metoda pro ověření, zda je číslo prvočíslo
        private bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;
            if (number % 2 == 0 || number % 3 == 0)
                return false;
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }
            return true;
        }
    }
}

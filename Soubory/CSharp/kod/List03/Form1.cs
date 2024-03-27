using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> numbers = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            listBox1.Items.Clear();

            if (!int.TryParse(textBox1.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Chyba: Zadejte platné kladné číslo pro počet.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(random.Next(1, 101));
            }

            numbers.Sort();

            foreach (int number in numbers)
            {
                listBox1.Items.Add(number);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox2.Items.Clear();

            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    listBox2.Items.Add(number);
                }
            }
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;
            if (number % 2 == 0 || number % 3 == 0)
                return false;

            int i = 5;
            while (i * i <= number)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
                i += 6;
            }

            return true;
        }
    }
}

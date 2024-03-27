using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RidStruk04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(textBox1.Text, out n) || n <= 0)
            {
                MessageBox.Show("Neplatný vstup!");
                return;
            }

            Random random = new Random();
            listBox1.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                int randomNumber = random.Next(101); // Náhodné číslo z intervalu 0..100
                listBox1.Items.Add(randomNumber);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> itemsToRemove = new List<int>();
            foreach (int item in listBox1.Items)
            {
                if (item % 2 == 0)
                {
                    itemsToRemove.Add(item);
                }
            }

            foreach (int itemToRemove in itemsToRemove)
            {
                listBox1.Items.Remove(itemToRemove);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int max = int.MinValue;
            foreach (int item in listBox1.Items)
            {
                int number = (int)item;
                if (number > max)
                {
                    max = number;
                }
            }

            if (max != int.MinValue)
            {
                MessageBox.Show($"Maximum v listBox1 je: {max}");
            }
            else
            {
                MessageBox.Show("listBox1 je prázdný.");
            }
        }
    }
}

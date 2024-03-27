using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(textBox1.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Chyba: Zadejte platné kladné číslo pro počet.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[] numbers = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(-20, 21);
                listBox1.Items.Add(numbers[i]);
            }

            // Vyhledání prvků větších než poslední prvek a vypsání jejich indexu
            int lastElement = numbers[numbers.Length - 1];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > lastElement)
                {
                    listBox2.Items.Add($"Prvek: {numbers[i]}, Pozice: {i + 1}");
                }
            }
        }
    }
}

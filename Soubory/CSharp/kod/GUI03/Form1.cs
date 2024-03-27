using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int amount) || amount < 0)
            {
                MessageBox.Show("Chyba: Zadejte platné nezáporné celé číslo pro částku.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int banknotes5000 = amount / 5000;
            int remainder = amount % 5000;
            int banknotes2000 = remainder / 2000;
            remainder %= 2000;
            int banknotes1000 = remainder / 1000;

            label1.Text = $"Počet 5000 bankovek: {banknotes5000}";
            label2.Text = $"Počet 2000 bankovek: {banknotes2000}";
            label3.Text = $"Počet 1000 bankovek: {banknotes1000}";
        }
    }
}

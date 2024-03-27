using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            // Rozdělení textu na slova a odstranění prázdných slov
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                MessageBox.Show("Chyba: Zadali jste prázdný text.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nalezení nejkratšího slova
            string shortestWord = words.OrderBy(word => word.Length).FirstOrDefault();
            int shortestWordLength = shortestWord.Length;

            // Nalezení nejdelšího slova
            string longestWord = words.OrderByDescending(word => word.Length).FirstOrDefault();
            int longestWordLength = longestWord.Length;

            // Výpis nejkratšího a nejdelšího slova s jejich délkou pomocí MessageBoxu
            MessageBox.Show($"Nejkratsi slovo: {shortestWord}, Delka: {shortestWordLength}");
            MessageBox.Show($"Nejdelsi slovo: {longestWord}, Delka: {longestWordLength}");

        }
    }
}

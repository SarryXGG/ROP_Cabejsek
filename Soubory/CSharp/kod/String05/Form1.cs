using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string originalText = textBox1.Text;
            string replacedText = "";

            foreach (char c in originalText)
            {
                if (char.IsDigit(c))
                {
                    replacedText += NumberToWord(int.Parse(c.ToString())) + " ";
                }
                else
                {
                    replacedText += c;
                }
            }

            textBox1.Text = replacedText.Trim(); // Oříznutí přebytečné mezery na konci

        }

        private string NumberToWord(int number)
        {
            switch (number)
            {
                case 0:
                    return "nula";
                case 1:
                    return "jedna";
                case 2:
                    return "dva";
                case 3:
                    return "tři";
                case 4:
                    return "čtyři";
                case 5:
                    return "pět";
                case 6:
                    return "šest";
                case 7:
                    return "sedm";
                case 8:
                    return "osm";
                case 9:
                    return "devět";
                default:
                    return ""; // Pokud číslo není mezi 0 a 9, vrátí se prázdný řetězec
            }
        }
    }
}

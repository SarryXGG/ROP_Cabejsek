using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string input = textBox1.Text;

                int lowercaseCount = 0;
                int uppercaseCount = 0;
                int digitCount = 0;
                int otherCount = 0;

                foreach (char c in input)
                {
                    if (char.IsLower(c))
                    {
                        lowercaseCount++;
                    }
                    else if (char.IsUpper(c))
                    {
                        uppercaseCount++;
                    }
                    else if (char.IsDigit(c))
                    {
                        digitCount++;
                    }
                    else
                    {
                        otherCount++;
                    }
                }

                string message = $"Počet malých písmen: {lowercaseCount}\n" +
                                 $"Počet velkých písmen: {uppercaseCount}\n" +
                                 $"Počet číslic: {digitCount}\n" +
                                 $"Počet jiných znaků: {otherCount}";

                MessageBox.Show(message);
            }
        }
    }
}

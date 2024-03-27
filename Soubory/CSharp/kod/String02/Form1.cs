using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String02
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
            string modifiedText = "";

            foreach (char c in originalText)
            {
                if (!char.IsUpper(c) || (c < 'A' || c > 'Z'))
                {
                    modifiedText += c;
                }
            }

            textBox1.Text = modifiedText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string originalText = textBox1.Text;
            string modifiedText = "";

            foreach (char c in originalText)
            {
                if (c != '*')
                {
                    modifiedText += c;
                }
            }

            textBox1.Text = modifiedText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string originalText = textBox1.Text;
            string modifiedText = "";
            bool previousCharWasSpace = false;

            foreach (char c in originalText)
            {
                if (c != ' ' || !previousCharWasSpace)
                {
                    modifiedText += c;
                    previousCharWasSpace = c == ' ';
                }
            }

            textBox1.Text = modifiedText;
        }
    }
}

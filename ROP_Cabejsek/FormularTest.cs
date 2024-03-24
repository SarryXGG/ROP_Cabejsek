using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROP_Cabejsek
{
    public partial class FormularTest : Form
    {
        public FormularTest()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            int hodnotaPromenne = form1 != null ? form1.GetPromenna() : 0;
            string vysledek = textBox1.Text;

            if (hodnotaPromenne == 7 && vysledek == "0")
            {
                MessageBox.Show("Ano správně");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Formulare04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            TextBox tb = new TextBox();
        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            form2.BackColor = Color.Blue;
            form2.Location = new Point(0, 1000);
            form2.Size = new Size(262, 488);
            form2.Show();

            tb.Size = textBox1.Size;
            tb.Location = textBox1.Location;
            tb.Multiline = textBox1.Multiline;
            tb.Show();
            tb.TextChanged += tb_TextChanged;
            form2.Controls.Add(tb);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tb.Text = textBox1.Text;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = tb.Text;
        }
    }
}

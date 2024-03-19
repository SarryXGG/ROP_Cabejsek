using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumCas01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DateTime> listDatNarozeni = new List<DateTime>();

            foreach (string Lajna in textBox1.Lines)
            {
                string[] slovaLajny = Lajna.Split(';');
                listDatNarozeni.Add(DateTime.Parse(slovaLajny[2]));
            }

            MessageBox.Show("Datum narození nejstarší osoby je: " + listDatNarozeni.Min());
        }
    }
}

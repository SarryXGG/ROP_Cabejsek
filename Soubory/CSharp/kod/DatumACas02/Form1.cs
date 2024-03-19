using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumCas04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool JeVZaruce(DateTime datumKoupe, int letZaruky, out int pocetDni)
        {
            DateTime datumKonci = datumKoupe.AddYears(letZaruky);
            DateTime dnes = DateTime.Today;
            pocetDni = (datumKonci - dnes).Days;

            bool jeVZaruce = true;
            if (pocetDni < 0) jeVZaruce = false;

            return jeVZaruce;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value.Date;
            int letZaruky = int.Parse(textBox1.Text);
            int pocetDni;

            if (JeVZaruce(dt, letZaruky, out pocetDni)) MessageBox.Show("Pro dané zboží ještě záruka platí " +
                                                                                                            "\nDnů do konce záruky ještě zbývá: " + pocetDni);
            else MessageBox.Show("Pro dané zboží záruka už propadla");
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool jeCerveny = true;
        private void button1_Click(object sender, EventArgs e)
        {
            // Přepínání barvy formuláře
            if (jeCerveny)
            {
                // Pokud je formulář červený, změníme barvu na zelenou
                this.BackColor = Color.Green;
                jeCerveny = false;
                button1.Text = "Přepnout na červený"; // Změna popisku tlačítka
                this.Text = "Zelený formulář"; // Změna popisku formuláře
            }
            else
            {
                // Pokud je formulář zelený, změníme barvu na červenou
                this.BackColor = Color.Red;
                jeCerveny = true;
                button1.Text = "Přepnout na zelený"; // Změna popisku tlačítka
                this.Text = "Červený formulář"; // Změna popisku formuláře
            }
        }
    }
}

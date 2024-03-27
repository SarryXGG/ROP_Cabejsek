using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prvocisla01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nejvetsiPrvocislo = NajdiNejvetsiPrvocislo(1000);
            MessageBox.Show("Největší prvočíslo menší než 1000 je: " + nejvetsiPrvocislo.ToString(), "Výsledek");
        }

        static bool JePrvocislo(int cislo)
        {
            if (cislo <= 1)
                return false;
            if (cislo <= 3)
                return true;
            if (cislo % 2 == 0 || cislo % 3 == 0)
                return false;

            int i = 5;
            while (i * i <= cislo)
            {
                if (cislo % i == 0 || cislo % (i + 2) == 0)
                    return false;
                i += 6;
            }
            return true;
        }

        // Metoda pro hledání největšího prvočísla menšího než zadaná hodnota
        static int NajdiNejvetsiPrvocislo(int limit)
        {
            for (int i = limit; i >= 2; i--)
            {
                if (JePrvocislo(i))
                    return i;
            }
            return -1; // Pokud není nalezeno žádné prvočíslo menší než limit
        }
    }
}

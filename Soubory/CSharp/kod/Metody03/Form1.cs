using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x1 = 1;
            double y1 = 2;

            // Souřadnice druhého bodu
            double x2 = 4;
            double y2 = 6;

            // Výpočet vzdálenosti mezi body
            double vzdalenost = Vzdalenost(x1, y1, x2, y2);

            // Výpis vzdálenosti pomocí MessageBoxu
            MessageBox.Show($"Vzdálenost mezi body ({x1}, {y1}) a ({x2}, {y2}) je {vzdalenost}", "Vzdálenost");
        }

        // Metoda pro výpočet vzdálenosti mezi dvěma body v rovině
        static double Vzdalenost(double x1, double y1, double x2, double y2)
        {
            // Vzdálenost se počítá podle Pythagorovy věty
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}

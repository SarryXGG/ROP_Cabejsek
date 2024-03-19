using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SouboryBin02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\..\..\Soubory\RealnaCisla.dat", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            Random rnd = new Random();
            int n = int.Parse(textBox1.Text);
            listBox1.Items.Clear();

            for (int i = 0; i < n; i++)
            {
                double genCislo = rnd.NextDouble() * (200 - -200) + -200;
                bw.Write(genCislo);
                listBox1.Items.Add(genCislo);
            }

            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\..\..\Soubory\RealnaCisla.dat", FileMode.Open, FileAccess.Read);
            StreamWriter sw = new StreamWriter(@"..\..\..\..\Soubory\RealnaCisla.txt");
            BinaryReader br = new BinaryReader(fs);
        }
    }
}

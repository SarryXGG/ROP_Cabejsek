using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SouboryBin01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"..\..\..\..\Soubory\CelaCisla.txt");
            listBox1.Items.Clear();

            while(!sr.EndOfStream) listBox1.Items.Add(sr.ReadLine());

            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\..\..\Soubory\CelaCisla.dat", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            StreamReader sr = new StreamReader(@"..\..\..\..\Soubory\CelaCisla.txt");

            while (!sr.EndOfStream)
            {
                int cislo = int.Parse(sr.ReadLine());
                bw.Write(cislo);
            }

            fs.Close();
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\..\..\Soubory\CelaCisla.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            listBox2.Items.Clear();

            while(fs.Position < fs.Length)
            {
                int cislo = br.ReadInt32();
                listBox2.Items.Add(cislo);
            }

            fs.Close();
        }
    }
}

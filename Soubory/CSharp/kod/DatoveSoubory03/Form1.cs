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

namespace SouboryBin08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int posledniCislo;        

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\..\..\Soubory\genCisla.dat", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int genCislo = rnd.Next(-10, 11);
                bw.Write(genCislo);                
            }

            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\..\..\Soubory\genCisla.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            listBox1.Items.Clear();
            int cislo = -11;

            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                cislo = br.ReadInt32();
                listBox1.Items.Add(cislo);
                //if (br.BaseStream.Position == br.BaseStream.Length) posledniCislo = cislo;
            }

            posledniCislo = cislo;
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\..\..\Soubory\genCisla.dat", FileMode.Open, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs);
            BinaryWriter bw = new BinaryWriter(fs);
            int pocatek = (int)br.BaseStream.Position;
            int cislo;
            listBox2.Items.Clear();

            if (posledniCislo % 2 == 0)
            {
                while (br.BaseStream.Position < br.BaseStream.Length)
                {
                    cislo = br.ReadInt32();

                    if (cislo % 2 > 0)
                    {
                        cislo *= 2;
                        br.BaseStream.Position -= sizeof(Int32);
                        bw.Write(cislo);
                    }
                }
            }
            else
            {
                while (br.BaseStream.Position < br.BaseStream.Length)
                {
                    cislo = br.ReadInt32();

                    if (cislo % 2 == 0)
                    {
                        cislo += 1;
                        br.BaseStream.Position -= sizeof(Int32);
                        bw.Write(cislo);
                    }
                }
            }

            bw.Seek(pocatek, SeekOrigin.Begin);

            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                int cislo = br.ReadInt32();
                listBox2.Items.Add(cislo);
            }

            fs.Close();
        }
    }
}

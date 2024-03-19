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

namespace SouboryBin04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Znaky.dat", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);            

            for (int i = 0; i < textBox1.Lines.Count(); i++)
            {
                string s = textBox1.Lines[i];
                bw.Write(s);
            }

            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Znaky.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);            
            int pocetPismen = 0;
            int pocetCifer = 0;
            int pocetMatOper = 0;
            int pocetZnakuVet = 0;
            //char[] matOper = { '+', '-', '*', '/' };
            //char[] znakyVet = { '.', '?', '!', ':' };
            string matOper = "+-*/";
            string znakyVet = ".?!:";

            while (fs.Position < fs.Length)
            {                
                char znak = br.ReadChar();

                if (char.IsLetter(znak)) pocetPismen++;
                else if (char.IsDigit(znak)) pocetCifer++;
                else if (matOper.Contains(znak)) pocetMatOper++;
                else if (znakyVet.Contains(znak)) pocetZnakuVet++; 
            }

            fs.Close();

            MessageBox.Show("Počet písmen v souboru je: " + pocetPismen + "\nPočet cifer v souboru je: " + pocetCifer + "\nPočet matematických operátorů je: " + pocetMatOper + "\nPočet znaků pro konec věty je: " + pocetZnakuVet);
        }
    }
}

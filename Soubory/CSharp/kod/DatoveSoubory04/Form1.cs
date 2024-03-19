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

namespace SouboryBin09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int konec;
        char[] polePohlavi;

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\..\..\Soubory\sport.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);            
            listBox1.Items.Clear();

            int hmotnostNejtezsiho = -1;
            string infoNejtezsiho = string.Empty;
            string infoOsoby = string.Empty;
            konec = (int)br.BaseStream.Length;
            polePohlavi = new char[br.BaseStream.Length / 6];
            int i = 0;

            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                int osc = br.ReadInt32();
                string jmeno = br.ReadString();
                string prijmeni = br.ReadString();
                char pohlavi = br.ReadChar();
                int vyska = br.ReadInt32();
                int hmotnost = br.ReadInt32();
                string s = osc + ";" + jmeno + ";" + prijmeni + ";" + pohlavi + ";" + vyska + ";" + hmotnost;
                polePohlavi[i] = pohlavi;
                i++;

                if (prijmeni == "Svoboda") infoOsoby = "Jméno: " + jmeno + ", příjmení: " + prijmeni + ", pohlaví: " + pohlavi + ", výška (cm): " + vyska + ", hmotnost (kg): " + hmotnost;
                if (hmotnost > hmotnostNejtezsiho && pohlavi == 'M')
                {
                    hmotnostNejtezsiho = hmotnost;
                    infoNejtezsiho = "Jméno: " + jmeno + ", příjmení: " + prijmeni + ", pohlaví: " + pohlavi + ", výška (cm): " + vyska + ", hmotnost (kg): " + hmotnost;
                }

                listBox1.Items.Add(s);
            }
         
            MessageBox.Show("Veškeré informace o nejtěžším muži jsou:\n" + infoNejtezsiho);
            if (infoOsoby.Length > 0) MessageBox.Show("Veškeré informace o muži s příjmením Svoboda jsou:\n" + infoOsoby);
            else MessageBox.Show("V souboru neexistuje muž s příjmením Svoboda...");

            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"..\..\..\..\Soubory\sport.txt");
            FileStream fs = new FileStream(@"..\..\..\..\Soubory\sport.dat", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            while (!sr.EndOfStream)
            {
                string radek = sr.ReadLine();
                string[] slova = radek.Split(';');

                int osc = int.Parse(slova[0]);
                string jmeno = slova[1];
                string prijmeni = slova[2];
                char pohlavi = slova[3][0];
                int vyska = int.Parse(slova[4]);
                int hmotnost = int.Parse(slova[5]);

                bw.Write(osc);
                bw.Write(jmeno);
                bw.Write(prijmeni);
                bw.Write(pohlavi);
                bw.Write(vyska);
                bw.Write(hmotnost);
            }

            sr.Close();
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\..\..\Soubory\sport.dat", FileMode.Open, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Seek(konec, SeekOrigin.Current);
            bw.Write(14);
            bw.Write("Jakub");
            bw.Write("Dvořák");
            bw.Write('M');
            bw.Write(176);
            bw.Write(86);

            fs.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\..\..\Soubory\sport.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            FileStream fsM = new FileStream(@"..\..\..\..\Soubory\panove.dat", FileMode.Create, FileAccess.Write);
            BinaryWriter bwM = new BinaryWriter(fsM);
            FileStream fsZ = new FileStream(@"..\..\..\..\Soubory\damy.dat", FileMode.Create, FileAccess.Write);
            BinaryWriter bwZ= new BinaryWriter(fsZ);
            int i = 0;

            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                int osc = br.ReadInt32();
                string jmeno = br.ReadString();
                string prijmeni = br.ReadString();
                char pohlavi = br.ReadChar();
                int vyska = br.ReadInt32();
                int hmotnost = br.ReadInt32();

                if (polePohlavi[i] == 'M')
                {
                    bwM.Write(osc);
                    bwM.Write(jmeno);
                    bwM.Write(prijmeni);
                    bwM.Write(pohlavi);
                    bwM.Write(vyska);
                    bwM.Write(hmotnost);
                }
                else
                {
                    bwZ.Write(osc);
                    bwZ.Write(jmeno);
                    bwZ.Write(prijmeni);
                    bwZ.Write(pohlavi);
                    bwZ.Write(vyska);
                    bwZ.Write(hmotnost);
                }

                i++;
            }

            fs.Close();
            fsM.Close();
            fsZ.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fsM = new FileStream(@"..\..\..\..\Soubory\panove.dat", FileMode.Open, FileAccess.Read);
            BinaryReader brM = new BinaryReader(fsM);
            FileStream fsZ = new FileStream(@"..\..\..\..\Soubory\damy.dat", FileMode.Open, FileAccess.Read);
            BinaryReader brZ = new BinaryReader(fsZ);
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            while (brM.BaseStream.Position < brM.BaseStream.Length)
            {
                int osc = brM.ReadInt32();
                string jmeno = brM.ReadString();
                string prijmeni = brM.ReadString();
                char pohlavi = brM.ReadChar();
                int vyska = brM.ReadInt32();
                int hmotnost = brM.ReadInt32();
                string s = osc + ";" + jmeno + ";" + prijmeni + ";" + pohlavi + ";" + vyska + ";" + hmotnost;

                listBox2.Items.Add(s);
            }

            while (brZ.BaseStream.Position < brZ.BaseStream.Length)
            {
                int osc = brZ.ReadInt32();
                string jmeno = brZ.ReadString();
                string prijmeni = brZ.ReadString();
                char pohlavi = brZ.ReadChar();
                int vyska = brZ.ReadInt32();
                int hmotnost = brZ.ReadInt32();
                string s = osc + ";" + jmeno + ";" + prijmeni + ";" + pohlavi + ";" + vyska + ";" + hmotnost;

                listBox3.Items.Add(s);
            }

            fsM.Close();
            fsZ.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

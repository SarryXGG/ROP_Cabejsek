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

namespace Formulare07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool jeUlozeno = false;
        Button buttonSave;
        Button buttonDontSave;
        Button buttonCancel;
        Form formKonec;

        private void novýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void ukoncitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!jeUlozeno)
            {
                formKonec = new Form();
                formKonec.Size = new Size(350, 150);

                Label labelKonec = new Label();
                labelKonec.Location = new Point(20, 20);
                labelKonec.AutoSize = true;
                labelKonec.Font = new Font("Comic Sans MS", 12);
                labelKonec.Text = "Chcete uložit soubor?";

                buttonSave = new Button();
                buttonSave.Size = new Size(75, 25);
                buttonSave.Location = new Point(80, 80);
                buttonSave.Text = "Uložit";

                buttonDontSave = new Button();                
                buttonDontSave.Size = new Size(75, 25);
                buttonDontSave.Location = new Point(165, 80);
                buttonDontSave.Text = "Neukládat";

                buttonCancel = new Button();
                buttonCancel.DialogResult = DialogResult.Cancel;
                buttonCancel.Size = new Size(75, 25);
                buttonCancel.Location = new Point(250, 80);
                buttonCancel.Text = "Zrušit";

                formKonec.Controls.Add(buttonSave);
                formKonec.Controls.Add(buttonDontSave);
                formKonec.Controls.Add(buttonCancel);
                formKonec.Controls.Add(labelKonec);

                buttonSave.Click += buttonSave_Click;
                buttonDontSave.Click += buttonDontSave_Click;

                if (formKonec.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
            else this.Close();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);

                foreach (string retezec in textBox1.Lines) sw.WriteLine(retezec);
                sw.Close();
                jeUlozeno = true;
            }
        }

        private void buttonDontSave_Click(object sender, EventArgs e)
        {
            formKonec.Close();
            this.Close();
        }

        private void otevritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                textBox1.Clear();


                while (!sr.EndOfStream)
                {
                    string retezec = sr.ReadLine();
                    textBox1.Text += retezec;
                }
                sr.Close();
            }
            
        }

        private void ulozitJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);

                foreach (string retezec in textBox1.Lines) sw.WriteLine(retezec);
                sw.Close();
                jeUlozeno = true;
            }
        }
    }
}

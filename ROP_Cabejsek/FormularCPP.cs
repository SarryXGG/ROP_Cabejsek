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

namespace ROP_Cabejsek
{
    public partial class FormularCPP : Form
    {
        public FormularCPP()
        {
            InitializeComponent();
        }

        private void FormularCPP_Load(object sender, EventArgs e)
        {

        }

        

        private void FormularCPP_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
        Priklady formPriklady = new Priklady();
        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("PrikladySekvence.txt"))
            {
                string s;
                string[] sts;
                if (!sr.EndOfStream)
                {
                    s = sr.ReadToEnd();
                    sts = s.Split('/');
                    foreach (Control c in formPriklady.Controls)
                    {
                        if (c is Label && c.TabIndex >= 21)
                        {
                            c.Text = sts[c.TabIndex % 21];
                        }
                    }
                }

                formPriklady.ShowDialog();
            }
        }
    }
}

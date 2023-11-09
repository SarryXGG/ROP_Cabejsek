using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROP_Cabejsek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        FormularCPP formCPP = new FormularCPP();
        FormularCSharp formCSharp = new FormularCSharp();

        private void button1_Click(object sender, EventArgs e)
        {
            if (formCPP.Visible)
            {
                formCPP.Activate();
            }
            else
            {
                formCPP = new FormularCPP();
                formCPP.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formCSharp.Visible)
            {
                formCSharp.Activate();
            }
            else
            {
                formCSharp = new FormularCSharp();
                formCSharp.Show();
            }
        }
    }
}

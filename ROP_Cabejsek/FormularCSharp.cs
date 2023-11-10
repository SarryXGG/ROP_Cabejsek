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
    public partial class FormularCSharp : Form
    {
        public FormularCSharp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormularCSharp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        private void FormularCSharp_Load(object sender, EventArgs e)
        {

        }
    }
}

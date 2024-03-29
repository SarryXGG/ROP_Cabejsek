﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumCas06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button2.Enabled = false;
        }

        Stopwatch stopky = new Stopwatch();

        private void button1_Click(object sender, EventArgs e)
        {
            stopky.Start();

            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopky.Stop();

            button1.Enabled = true;
            button2.Enabled = false;

            MessageBox.Show("Uplynulo: " + stopky.Elapsed.Minutes + " minut a " + stopky.Elapsed.Seconds + " sekund");                  
        }
    }
}

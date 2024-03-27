using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> backups = new List<string>();
        private Timer timer;
        private bool editingEnabled = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!editingEnabled)
            {
                MessageBox.Show("Editace textu je již ukončena.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            timer = new Timer();
            textBox1.ReadOnly = false;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!editingEnabled)
                return;

            editingEnabled = false;
            timer.Dispose();
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.ReadOnly = true;
        }

        private void BackupText(object state)
        {
            string text = textBox1.Text;
            backups.Add(text);
        }

        private void NavigateBackup(int index)
        {
            if (index < 0 || index >= backups.Count)
                return;

            textBox1.Text = backups[index];
        }






        private void button3_Click_1(object sender, EventArgs e)
        {
            NavigateBackup(0);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            NavigateBackup(Math.Max(0, backups.Count - 1));
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            NavigateBackup(Math.Min(backups.Count - 1, backups.Count + 1));
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            NavigateBackup(backups.Count - 1);
        }
    }
}

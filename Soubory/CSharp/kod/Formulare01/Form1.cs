using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulare01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label label1 = new System.Windows.Forms.Label();
        private void Form1_Load(object sender, EventArgs e)
        {
            Button buttonOpenForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // buttonOpenForm2
            // 
            buttonOpenForm2.Location = new System.Drawing.Point(15, 41);
            buttonOpenForm2.Name = "buttonOpenForm2";
            buttonOpenForm2.Size = new System.Drawing.Size(75, 23);
            buttonOpenForm2.TabIndex = 1;
            buttonOpenForm2.Text = "Open Form2";
            buttonOpenForm2.UseVisualStyleBackColor = true;
            buttonOpenForm2.Click += new System.EventHandler(buttonOpenForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 78);
            this.Controls.Add(buttonOpenForm2);
            this.Controls.Add(label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void buttonOpenForm2_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = form2.TextBoxText;
                }
            }
        }
    }
}

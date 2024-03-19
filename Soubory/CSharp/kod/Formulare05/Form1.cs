using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulare05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CheckBox checkBox1;
        CheckBox checkBox2;
        CheckBox checkBox3;
        CheckBox checkBox4;
        CheckBox checkBox5;
        CheckBox checkBox6;
        CheckBox checkBox7;
        Button buttonNahled;

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            Form form2 = new Form();
            form2.Location = new Point(0, 1000);
            form2.Size = new Size(816, 489);            

            Button buttonOK = new Button();
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(600, 410);
            buttonOK.Size = new Size(75, 25);
            buttonOK.Text = "OK";

            Button buttonCancel = new Button();
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(700, 410);
            buttonCancel.Size = new Size(75, 25);
            buttonCancel.Text = "Cancel";

            Button buttonApply = new Button();
            buttonApply.Location = new Point(500, 410);
            buttonApply.Size = new Size(75, 25);
            buttonApply.Text = "Apply";

            buttonNahled = new Button();
            buttonNahled.Location = new Point(450, 100);
            buttonNahled.Size = button1.Size;
            buttonNahled.Text = "Náhled button1...";

            Label labelInfo = new Label();
            labelInfo.Location = new Point(450, 80);
            labelInfo.Size = new Size(200, 25);
            labelInfo.Text = "Takto bude vypadat výsledný button1:";

            checkBox1 = new CheckBox();           
            checkBox1.Location = new Point(25, 20);
            checkBox1.Size = new Size(100, 20);
            checkBox1.Text = "Uprav text";

            checkBox2 = new CheckBox();
            checkBox2.Location = new Point(25, 45);
            checkBox2.Size = new Size(100, 20);
            checkBox2.Text = "Uprav font";

            checkBox3 = new CheckBox();
            checkBox3.Location = new Point(25, 70);
            checkBox3.Size = new Size(150, 20);
            checkBox3.Text = "Uprav barvu popředí";

            checkBox4 = new CheckBox();
            checkBox4.Location = new Point(25, 95);
            checkBox4.Size = new Size(150, 20);
            checkBox4.Text = "Uprav barvu pozadí";

            checkBox5 = new CheckBox();
            checkBox5.Location = new Point(25, 120);
            checkBox5.Size = new Size(100, 20);
            checkBox5.Text = "TextAlign";

            checkBox6 = new CheckBox();
            checkBox6.Location = new Point(25, 145);
            checkBox6.Size = new Size(100, 20);
            checkBox6.Text = "Uprav šířku";

            checkBox7 = new CheckBox();
            checkBox7.Location = new Point(25, 170);
            checkBox7.Size = new Size(100, 20);
            checkBox7.Text = "Uprav výšku";            

            form2.Controls.Add(buttonOK);
            form2.Controls.Add(buttonCancel);
            form2.Controls.Add(buttonNahled);
            form2.Controls.Add(buttonApply);
            form2.Controls.Add(labelInfo);
            form2.Controls.Add(checkBox1);
            form2.Controls.Add(checkBox2);
            form2.Controls.Add(checkBox3);
            form2.Controls.Add(checkBox4);
            form2.Controls.Add(checkBox5);
            form2.Controls.Add(checkBox6);
            form2.Controls.Add(checkBox7);


            buttonOK.Click += buttonOK_Click;
            buttonApply.Click += buttonApply_Click;
            if (form2.ShowDialog() == DialogResult.OK)
            {
                button1.Text = buttonNahled.Text;
                button1.Font = buttonNahled.Font;
                button1.ForeColor = buttonNahled.ForeColor;
                button1.BackColor = buttonNahled.BackColor;
                button1.TextAlign = buttonNahled.TextAlign;
                button1.Width = buttonNahled.Width;
                button1.Height = buttonNahled.Height;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) buttonNahled.Text = "Ale dost už!";      
            if (checkBox2.Checked) buttonNahled.Font = new Font("Comic Sans MS", 12);
            if (checkBox3.Checked) buttonNahled.ForeColor = Color.Azure;
            if (checkBox4.Checked) buttonNahled.BackColor = Color.DarkViolet;
            if (checkBox5.Checked) buttonNahled.TextAlign = ContentAlignment.MiddleRight;
            if (checkBox6.Checked) buttonNahled.Width = 150;
            if (checkBox7.Checked) buttonNahled.Height = 50;
        }
    }
}

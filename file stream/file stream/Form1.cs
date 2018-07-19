using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace file_stream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Text = "File Reader";
            this.button2.Text = "File Writer";
            this.button3.Text = "File Stream";
            this.button4.Text = "Read";
            this.button5.Text = "Write";
            this.button4.Visible = false;
            this.button5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button4.Visible = true;
            this.button5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}

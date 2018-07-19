using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace file_stream
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Writer";
            this.label1.Text = "File location";
            this.label2.Text = "File name";
            this.button1.Text = "Write";
            this.button2.Text = "File Stream";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(textBox2.Text + textBox3.Text);
            sw.Write(this.textBox1.Text);
            MessageBox.Show("file has been written");
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] b = new byte[100];
            char[] ch = new char[100];
            string fn = textBox2.Text + textBox3.Text;
            FileStream fs = new FileStream(fn, FileMode.OpenOrCreate);
            ch = textBox1.Text.ToCharArray();
            Encoder en = Encoding.UTF8.GetEncoder();
            en.GetBytes(ch, 0, ch.Length, b, 0, true);
            fs.Write(b, 0, b.Length);
            MessageBox.Show("File has been Written");
            fs.Close();
        }
    }
}

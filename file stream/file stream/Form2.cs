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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Reader";
            this.label1.Text = "File location";
            this.label2.Text = "File name";
            this.button1.Text = "Read";
            this.button2.Text = "File Stream";
            this.textBox3.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader(textBox1.Text + textBox2.Text);
            this.textBox3.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] b = new byte[100];
            char[] ch = new char[100];
            FileStream fs = new FileStream(@"d:\Vendor Approve\file1.txt", FileMode.OpenOrCreate);
            fs.Read(b, 0, 100);
            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(b, 0, b.Length, ch, 0);
            foreach (char c in ch)
            {
                this.textBox3.Text += c;
            }
        }
    }
}

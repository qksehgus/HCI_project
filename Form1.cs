using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_HCI
{  

    public partial class Form1 : Form
    {
        Form2 f1;
        int index = 0;
        public Form1(Form2 frm)
        {
            InitializeComponent();
            f1 = frm;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var temp = this.f1.richTextBox1.Text;
            this.f1.richTextBox1.Text = "";
            this.f1.richTextBox1.Text = temp;

            while (index < this.f1.richTextBox1.Text.LastIndexOf(searchrichBox.Text))
            {
                this.f1.richTextBox1.Find(searchrichBox.Text, index, this.f1.richTextBox1.TextLength, RichTextBoxFinds.None);
                this.f1.richTextBox1.SelectionBackColor = Color.Yellow;

                index = this.f1.richTextBox1.Text.IndexOf(searchrichBox.Text, index) + 1;
            }


        }

        private void button2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchrichBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void replacetextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.f1.richTextBox1.Text = this.f1.richTextBox1.Text.Remove(index, searchrichBox.Text.Length);
            this.f1.richTextBox1.Text = this.f1.richTextBox1.Text.Insert(index, replacetextbox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.f1.richTextBox1.Text = this.f1.richTextBox1.Text.Replace(searchrichBox.Text, replacetextbox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

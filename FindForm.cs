using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_HCI
{
    public partial class 찾기 : Form
    {
        int t = 0;
        int k_result = 0;
        Form2 f2;
        public 찾기(Form2 frm)
        {
            InitializeComponent();
            f2 = frm;
             
        }



        private void button1_Click(object sender, System.EventArgs e)
        {
            
            for (int i = t;i<this.f2.richTextBox1.TextLength-searchTextBox.TextLength;i++)
            {
                string x = "";
                for(int j=0;j< searchTextBox.TextLength;j++)
                {
                    if (searchTextBox.Text[j] == this.f2.richTextBox1.Text[i + j])
                        x += this.f2.richTextBox1.Text[i + j] + "";
                    else { x = ""; k_result = 0; };
                }
                if(x==searchTextBox.Text)
                {
                    t = i + 1;
                    this.f2.richTextBox1.SelectAll();
                    this.f2.richTextBox1.SelectionBackColor = Color.White;
                    this.f2.richTextBox1.Select(i, searchTextBox.TextLength);
                    this.f2.richTextBox1.SelectionBackColor = Color.LightSkyBlue;
                    k_result++;
                    break;
                }
                if (i == this.f2.richTextBox1.TextLength - searchTextBox.TextLength - 1)
                {      if(k_result>0)         
                        MessageBox.Show("검색 완료");
                        else MessageBox.Show("문자를 찾을 수 없습니다.");
                    t = 0;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.f2.richTextBox1.SelectAll();
            this.f2.richTextBox1.SelectionBackColor = Color.White;          
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 찾기_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.f2.richTextBox1.SelectAll();
            this.f2.richTextBox1.SelectionBackColor = Color.White;
            k_result = 0;
            t = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = 0; string temp = this.f2.richTextBox1.Text; this.f2.richTextBox1.Text = ""; this.f2.richTextBox1.Text = temp;
            while(index < this.f2.richTextBox1.Text.LastIndexOf(searchTextBox.Text))
                {
                this.f2.richTextBox1.Find(searchTextBox.Text, index, this.f2.richTextBox1.TextLength, RichTextBoxFinds.None);
                this.f2.richTextBox1.SelectionBackColor = Color.LightSkyBlue;
                index = this.f2.richTextBox1.Text.IndexOf(searchTextBox.Text, index) + 1;
            }
        }
    }

}
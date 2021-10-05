using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_HCI.Properties
{
    public partial class Form1 : Form
    {
        private string id = "admin";
        private string pw = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;
            if(textBox1.Text==id&&textBox2.Text==pw)
            {
                MessageBox.Show("로그인 확인");
                x = true;
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
            if(x==true)
            {
                this.Visible = false;
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                if (keyData.Equals(Keys.Enter))
                {
                    button1.PerformClick();
                    return true;
                }
                else return false;
            }
            else return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Project_HCI
{

    public partial class Form3 : Form
    {
        Form2 f2 = new Form2();
        public Form3(Form2 frm)
        {
            f2 = frm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senter = senders.Text;
            string adress = toaddress.Text;
            string pw = pswd.Text;
            string sub = subject.Text;
            string result = mailbox.Text;
            string smtp_coning = "smtp.gmail.com";
            int smtp_port = 587;

            MailMessage mail = new MailMessage(senter, adress,sub,result);
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient(smtp_coning, smtp_port);
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential(senter, pw);
            try
            {
                smtp.Send(mail);
                MessageBox.Show("전송완료");
            }
            catch
            {
                MessageBox.Show("불가능");
            }
        }

        private void toaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void subject_TextChanged(object sender, EventArgs e)
        {

        }

        private void mailbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void sender_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mailbox.Text = f2.richTextBox1.Text;
        }

        private void pswd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

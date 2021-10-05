namespace Project_HCI
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.mailbox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.senders = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pswd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toaddress
            // 
            this.toaddress.Location = new System.Drawing.Point(112, 80);
            this.toaddress.Name = "toaddress";
            this.toaddress.Size = new System.Drawing.Size(413, 21);
            this.toaddress.TabIndex = 0;
            this.toaddress.TextChanged += new System.EventHandler(this.toaddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "수신자(이메일)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "제목";
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(112, 115);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(413, 21);
            this.subject.TabIndex = 3;
            this.subject.TextChanged += new System.EventHandler(this.subject_TextChanged);
            // 
            // mailbox
            // 
            this.mailbox.Location = new System.Drawing.Point(113, 161);
            this.mailbox.Name = "mailbox";
            this.mailbox.Size = new System.Drawing.Size(413, 291);
            this.mailbox.TabIndex = 4;
            this.mailbox.Text = "";
            this.mailbox.TextChanged += new System.EventHandler(this.mailbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "전송";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "발신자(이메일)";
            // 
            // senders
            // 
            this.senders.Location = new System.Drawing.Point(112, 20);
            this.senders.Name = "senders";
            this.senders.Size = new System.Drawing.Size(413, 21);
            this.senders.TabIndex = 7;
            this.senders.TextChanged += new System.EventHandler(this.sender_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "메세지 불러오기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "비밀번호";
            // 
            // pswd
            // 
            this.pswd.Location = new System.Drawing.Point(112, 51);
            this.pswd.Name = "pswd";
            this.pswd.PasswordChar = '*';
            this.pswd.Size = new System.Drawing.Size(413, 21);
            this.pswd.TabIndex = 10;
            this.pswd.TextChanged += new System.EventHandler(this.pswd_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 498);
            this.Controls.Add(this.pswd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.senders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mailbox);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toaddress);
            this.Name = "Form3";
            this.Text = "이메일 전송";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.RichTextBox mailbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox senders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pswd;
    }
}
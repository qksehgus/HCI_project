using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace Project_HCI
{

    public partial class Form2 : Form
    {

        private FontDialog fd = new FontDialog();//Font set
        private ColorDialog color = new ColorDialog();


        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 삽입ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }





        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void 자동저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asdfasdfaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 새로만들기ToolStripButton_Click(object sender, EventArgs e)//New_File
        {
            //만약 리치박스가 비어있지 않다면
            if (MessageBox.Show("현재 작성하신 문서를 저장하시겠습니까?", "새로만들기", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string dir = "";
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    dir = sv.FileName;
                    FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(richTextBox1.Text);

                    sw.Flush();
                    sw.Close();
                    fs.Close();

                    richTextBox1.Text = null;
                }
            }
            else
            {
                richTextBox1.Text = null;
            }
        }

        private void displayImage(string name)
        {
            Clipboard.SetImage(Image.FromFile(name));

            richTextBox1.Paste();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                displayImage(open.FileName);
            }


        }




        private void 앞으로ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void SadfasdfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 도움말ToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://go.microsoft.com/fwlink/?LinkId=834783");
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)//Open_File
        {
            OpenFileDialog OF = new OpenFileDialog();
            OF.DefaultExt = "*.txt";
            OF.Filter = "텍스트 파일 (*.txt) |*.txt|모든파일(*.*)|*.*";
            OF.FilterIndex = 1;

            if (OF.ShowDialog() == DialogResult.OK)
            {
                string ProgramPath = OF.FileName;
                TextReader tr = new StreamReader(OF.FileName);
                richTextBox1.Text = tr.ReadToEnd();
            }
        }
        private void 열기ToolStripButton_Click(object sender, EventArgs e)//Open_File
        {
            OpenFileDialog OF = new OpenFileDialog();
            OF.DefaultExt = "*.txt";
            OF.Filter = "텍스트 파일 (*.txt) |*.txt|모든파일(*.*)|*.*";
            OF.FilterIndex = 1;

            if (OF.ShowDialog() == DialogResult.OK)
            {
                string ProgramPath = OF.FileName;
                TextReader tr = new StreamReader(OF.FileName);
                richTextBox1.Text = tr.ReadToEnd();
            }
        }
        private void 저장ToolStripButton_Click(object sender, EventArgs e)//Save_File
        {
            string dir = "";
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                dir = sv.FileName;
                FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(richTextBox1.Text);

                sw.Flush();
                sw.Close();
                fs.Close();
            }

        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)//Save_File
        {
            string dir = "";
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                dir = sv.FileName;
                FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(richTextBox1.Text);

                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)//Exit
        {

            this.Close();
        }

        private void 현재시간F5ToolStripMenuItem_Click(object sender, EventArgs e)//Time_Up
        {
            richTextBox1.Text += DateTime.Now.ToString("yyyy년MM월dd일HH시mm분ss초\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//리치박스안에 내용이 있을경우 Save Or Close
        {
            if (richTextBox1.Text.Length != 0)
            {
                if (MessageBox.Show("변경 내용을 저장하지 않고 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    Application.Exit();
                }

                else
                {
                    string dir = "";
                    SaveFileDialog sv = new SaveFileDialog();
                    sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
                    if (sv.ShowDialog() == DialogResult.OK)
                    {
                        dir = sv.FileName;
                        FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(richTextBox1.Text);

                        sw.Flush();
                        sw.Close();
                        fs.Close();
                    }
                }
            }
            else
                this.Close();
        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.richTextBox1.Text, this.richTextBox1.Font, Brushes.Black, 10, 25);
        }
        private void 인쇄ToolStripButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
            printDocument.Print();
        }


        private void 잘라내기ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        /*        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)//단축기
                {
                    if (e.Control == true && e.KeyCode == Keys.S)//저장
                    {
                        string dir = "";
                        SaveFileDialog sv = new SaveFileDialog();
                        sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
                        if (sv.ShowDialog() == DialogResult.OK)
                        {
                            dir = sv.FileName;
                            FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine(richTextBox1.Text);

                            sw.Flush();
                            sw.Close();
                            fs.Close();
                        }
                    }//저장 단축키
                    if (e.Control == true && e.KeyCode == Keys.O)
                    {
                        OpenFileDialog OF = new OpenFileDialog();
                        OF.DefaultExt = "*.txt";
                        OF.Filter = "텍스트 파일 (*.txt) |*.txt|모든파일(*.*)|*.*";
                        OF.FilterIndex = 1;

                        if (OF.ShowDialog() == DialogResult.OK)
                        {
                            string ProgramPath = OF.FileName;
                            TextReader tr = new StreamReader(OF.FileName);
                            richTextBox1.Text = tr.ReadToEnd();
                        }
                    }//열기 단축키
                }
        */
        private void 분마다저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 300000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HCI 4조 Project Text Editer 1.0 Version", "프로그램정보");

        }

        private void 글자색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            col.ShowDialog();
            richTextBox1.SelectionColor = col.Color;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)//Font
        {
            if (fd.ShowDialog() == DialogResult.OK) {
                this.richTextBox1.Font = fd.Font;
            }
        }

        private void 바탕색ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 시간날짜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += DateTime.Now.ToString("yyyy년MM월dd일HH시mm분ss초\n");
        }

        private void 복사ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void 배경색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog bgcolor = new ColorDialog();
            bgcolor.ShowDialog();
            richTextBox1.BackColor = bgcolor.Color;

        }

        private void 왼쪽정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void 가운데ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void 오른쪽정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void 도움말보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help help = new help();
            help.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void google로검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string alpha = richTextBox1.Text;
            string search = alpha;
            System.Diagnostics.Process.Start("https://search.naver.com/search.naver?sm=top_hty&fbm=1&ie=utf8&query=" + search);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData)) // 위에서 처리 안했으면
            {
                // 여기에 처리코드를 넣는다.
                if (keyData.Equals(Keys.F5))
                {

                    richTextBox1.Text += DateTime.Now.ToString("yyyy년MM월dd일HH시mm분ss초\n");

                    return true;
                } //현재시각
                else if (keyData.Equals(Keys.Control | Keys.S))
                {

                    string dir = "";
                    SaveFileDialog sv = new SaveFileDialog();
                    sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
                    if (sv.ShowDialog() == DialogResult.OK)
                    {
                        dir = sv.FileName;
                        FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(richTextBox1.Text);

                        sw.Flush();
                        sw.Close();
                        fs.Close();
                    }
                    // 대충 이런 식으로 처리한다.
                    return true;
                } // 저장하기
                else if (keyData.Equals(Keys.Control | Keys.O))
                {
                    OpenFileDialog OF = new OpenFileDialog();
                    OF.DefaultExt = "*.txt";
                    OF.Filter = "텍스트 파일 (*.txt) |*.txt|모든파일(*.*)|*.*";
                    OF.FilterIndex = 1;

                    if (OF.ShowDialog() == DialogResult.OK)
                    {
                        string ProgramPath = OF.FileName;
                        TextReader tr = new StreamReader(OF.FileName);
                        richTextBox1.Text = tr.ReadToEnd();
                    }

                    return true;
                } //불러오기
                else if (keyData.Equals(Keys.Control | Keys.N))
                {
                    if (MessageBox.Show("현재 작성하신 문서를 저장하시겠습니까?", "새로만들기", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string dir = "";
                        SaveFileDialog sv = new SaveFileDialog();
                        sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
                        if (sv.ShowDialog() == DialogResult.OK)
                        {
                            dir = sv.FileName;
                            FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);
                            sw.WriteLine(richTextBox1.Text);

                            sw.Flush();
                            sw.Close();
                            fs.Close();

                            richTextBox1.Text = null;
                        }
                    }
                    else
                    {
                        richTextBox1.Text = null;
                    }
                    return true;
                } //새 파일 불러오기
                else if (keyData.Equals(Keys.F1))
                {

                    help help = new help();
                    help.ShowDialog();
                    return true;
                }//도움말
                else if (keyData.Equals(Keys.Control | Keys.C))
                {
                    richTextBox1.Copy();
                    return true;
                } //복사하기
                else if (keyData.Equals(Keys.Control | Keys.V))
                {
                    richTextBox1.Paste();
                    return true;
                } //붙여넣기
                else if (keyData.Equals(Keys.Control | Keys.X))
                {
                    richTextBox1.Cut();
                    return true;
                } //오리기
                else if (keyData.Equals(Keys.Control | Keys.Z))
                {
                    richTextBox1.Undo();
                    return true;
                } //되돌리기
                else if (keyData.Equals(Keys.Control | Keys.Y))
                {
                    richTextBox1.Redo();
                    return true;
                } //앞으로
                else if (keyData.Equals(Keys.Control | Keys.F))
                {
                    찾기 searchText = new 찾기(this);
                    searchText.Show();
                    return true;
                }
                else if (keyData.Equals(Keys.Control | Keys.P))
                {
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                        printDocument1.Print();
                    return true;
                }
                else if (keyData.Equals(Keys.Control | Keys.Add))
                {
                    float currentSize;

                    currentSize = richTextBox1.Font.Size;
                    currentSize += 2.0F;
                    richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize,
                    richTextBox1.Font.Style, richTextBox1.Font.Unit);
                    return true;
                }
                else if (keyData.Equals(Keys.Control | Keys.Subtract))
                {
                    float currentSize;

                    currentSize = richTextBox1.Font.Size;
                    currentSize -= 2.0F;
                    richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize,
                    richTextBox1.Font.Style, richTextBox1.Font.Unit);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void Form1_Load(object sender, EventArgs e) // 글꼴 (디자인 시작!!!!!!!!!!!!!!)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // 글꼴
        {
            {
                try
                {
                    richTextBox1.Font = new Font(comboBox1.Text, richTextBox1.Font.Size);
                }
                catch { }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)// 글꼴 사이즈
        {
            try
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(comboBox2.SelectedItem.ToString()));
            }
            catch { }
        }
        private void button1_Click(object sender, EventArgs e) // 굵게
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e) // 기울이기
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Italic);
        }

        private void button3_Click(object sender, EventArgs e) //밑줄
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Underline);
        }

        private void button5_Click(object sender, EventArgs e) //취소선
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Strikeout);
        }

        private void button4_Click(object sender, EventArgs e) //색상
        {

            ColorDialog col = new ColorDialog();
            col.ShowDialog();
            richTextBox1.SelectionColor = col.Color;
        }

        private void button6_Click(object sender, EventArgs e) //붙여넣기
        {
            richTextBox1.Paste();
            button6.TabStop = false;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;

        }

        private void button7_Click(object sender, EventArgs e) //잘라내기
        {
            richTextBox1.Cut();
        }

        private void button8_Click(object sender, EventArgs e) //복사
        {
            richTextBox1.Copy();
        }


        private void button9_Click(object sender, EventArgs e) // 왼쪽정렬
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button10_Click(object sender, EventArgs e) //가운데 정렬
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button11_Click(object sender, EventArgs e) //오른쪽 정렬
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button15_Click(object sender, EventArgs e) //새로 만들기
        {
            if (MessageBox.Show("현재 작성하신 문서를 저장하시겠습니까?", "새로만들기", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string dir = "";
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    dir = sv.FileName;
                    FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(richTextBox1.Text);

                    sw.Flush();
                    sw.Close();
                    fs.Close();

                    richTextBox1.Text = null;
                }
            }
            else
            {
                richTextBox1.Text = null;
            }
        }

        private void button16_Click(object sender, EventArgs e) //열기
        {
            OpenFileDialog OF = new OpenFileDialog();
            OF.DefaultExt = "*.txt";
            OF.Filter = "텍스트 파일 (*.txt) |*.txt|모든파일(*.*)|*.*";
            OF.FilterIndex = 1;

            if (OF.ShowDialog() == DialogResult.OK)
            {
                string ProgramPath = OF.FileName;
                TextReader tr = new StreamReader(OF.FileName);
                richTextBox1.Text = tr.ReadToEnd();
            }
        }

        private void button17_Click(object sender, EventArgs e) //저장
        {
            string dir = "";
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                dir = sv.FileName;
                FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(richTextBox1.Text);

                sw.Flush();
                sw.Close();
                fs.Close();
            }

        }

        private void button18_Click(object sender, EventArgs e) //이미지 열기
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                displayImage(open.FileName);
            }
        }

        private void button19_Click(object sender, EventArgs e) //인쇄
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 실행취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length >= 10)
            {
                string name = null;
                for (int i = 0; i < 10; i++)
                {
                    name = richTextBox1.Text.Substring(0, i);
                }
                string dir = "";
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
                sv.Title = "저장";
                sv.FileName = name;
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    dir = sv.FileName;
                    FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    sw.WriteLine(richTextBox1.Text);

                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
            else
            {
                int y = richTextBox1.Text.Length;
                string name = null;
                for (int i = 0; i < y; i++)
                {
                    name = richTextBox1.Text.Substring(0, i);
                }
                string dir = "";
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
                sv.Title = "저장";
                sv.FileName = name;
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    dir = sv.FileName;
                    FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    sw.WriteLine(richTextBox1.Text);

                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
        }

        private void 분마다저장ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 600000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void 분마다저장ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1800000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void 시간마다저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 3200000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length >= 10)
            {
                string name = null;
                for (int i = 0; i < 10; i++)
                {
                    name = richTextBox1.Text.Substring(0, i);
                }
                string dir = "";
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
                sv.Title = "저장";
                sv.FileName = name;
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    dir = sv.FileName;
                    FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    sw.WriteLine(richTextBox1.Text);

                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
            else
            {
                int y = richTextBox1.Text.Length;
                string name = null;
                for (int i = 0; i < y; i++)
                {
                    name = richTextBox1.Text.Substring(0, i);
                }
                string dir = "";
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "텍스트 파일(*.txt) |*.txt|모든 파일(*.*)|*.*";
                sv.Title = "저장";
                sv.FileName = name;
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    dir = sv.FileName;
                    FileStream fs = new FileStream(sv.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    sw.WriteLine(richTextBox1.Text);

                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.richTextBox1.Text, this.richTextBox1.Font, Brushes.Black, new Point(100, 100));
        }

        private void 인쇄ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void 오려넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        private void 찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            찾기 searchText = new 찾기(this);
            searchText.Show();


        }

        private void button21_Click(object sender, EventArgs e)
        {
            ColorDialog bgcolor = new ColorDialog();
            bgcolor.ShowDialog();
            richTextBox1.BackColor = bgcolor.Color;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void 확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;

            currentSize = richTextBox1.Font.Size;
            currentSize += 2.0F;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize,
            richTextBox1.Font.Style, richTextBox1.Font.Unit);
        }

        private void 축소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;

            currentSize = richTextBox1.Font.Size;
            currentSize -= 2.0F;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize,
            richTextBox1.Font.Style, richTextBox1.Font.Unit);
        }

        private void 찾아바꾸기CtrlHToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 searchText = new Form1(this);
            searchText.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button6_mous(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(button6, "붙여넣기");
        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void button7_mouse(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button7, "잘라내기");
        }

        private void button8_mouse(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button8, "복사");
        }

        private void button20_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button20, "바탕체");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button1, "굵게");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button2, "기울이기");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button3, "밑줄");
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button5, "취소선");
        }

        private void button21_MouseHover(object sender, EventArgs e)
        {

            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button21, "배경색");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {

            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button4, "글자색");
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button9, "왼쪽 정렬");
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {

            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button10, "가운데 정렬");
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {

            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button11, "오른쪽 정렬");
        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button15, "새로만들기");
        }

        private void button16_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button16, "열기");
        }

        private void button17_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button17, "저장");
        }

        private void button18_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button18, "이미지 열기");
        }

        private void button19_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button19, "인쇄");
        }

        private void button23_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button23, "다시하기");
        }

        private void button24_MouseHover(object sender, EventArgs e)
        {
            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button24, "되돌리기");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Mail_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
        }

        private void 이메일전송ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3(this);
            form3.ShowDialog();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            timer2.Interval = 1000;
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;

            statusStrip1.Text = DateTime.Now.ToString();
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_2(object sender, EventArgs e)
        {
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text =
                String.Format("{0}시 {1:0#}분 {2}초",
            DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second.ToString().PadLeft(2, '0'));
        }
        private void Timer4_Tick(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.TextLength.ToString());
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

            toolStripStatusLabel2.Text = String.Format("{0}글자 {1}줄", richTextBox1.TextLength.ToString(), richTextBox1.Lines.Length.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, float.Parse(comboBox2.SelectedItem.ToString()));
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Font = new Font(comboBox1.Text, richTextBox1.Font.Size);
            }
            catch { }
        }

        private void Mail_MouseHover(object sender, EventArgs e)
        {

            toolTip1.IsBalloon = true;
            toolTip1.SetToolTip(button24, "이메일전송");
        }
    }
}

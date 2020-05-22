using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _008TypingWord
{
    public partial class Form2 : Form
    {
        public string ReturnStep
        {
            get { return this.cbGrade.Text; }
        }
        public string ReturnKind
        {
            get { return this.cbKind.Text; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.cbKind.Text = "한글";
            lvWordView();
        }

        private void lvWordView()
        {
            this.lvWord.Items.Clear();
            var f = new FileInfo(@"setup.txt");
            if (f.Exists == true)       //파일이 있는경우
            {
                var sr = File.OpenText(@"setup.txt");       //텍스트파일을 읽기용으로 열어서 sr에 할당.
                while (true)
                {
                    var str = sr.ReadLine();        //한줄의 문자를 읽고 데이터를 문자열로 반환해서 str에 할당.
                    if (str == null)
                        break;
                    var a_str = str.Split('&');     //&를 기준으로 문자열 분리.
                    if(this.cbKind.SelectedItem.ToString() == "한글")     //종류 콤보박스의 선택이 한글일때
                    {
                        if(a_str[0] == "1")
                        {
                            this.lvWord.Items.Add(a_str[1]);
                        }
                    }
                    else
                    {
                        if(a_str[0] == "2")
                        {
                            this.lvWord.Items.Add(a_str[1]);
                        }
                    }
                }
                sr.Close();
            }
            else //setup.txt 파일이 없는 경우 
            {
                var sw = new StreamWriter(new FileStream(@"setup.txt", FileMode.CreateNew));        //CreateNew메서드로 setup.txt파일 생성.

                sw.Close();

                MessageBox.Show("에러발생.\n 파일을 생성합니다", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvWordView();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(this.txtInsert.Text == "")
            {
                MessageBox.Show("문자열을 입력해 주세요", "알림", MessageBoxButtons.OK);
                this.txtInsert.Focus();
            }
            else
            {
                string str = this.txtInsert.Text;
                var dlr = MessageBox.Show("" + str + "을 저장합니다.", "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch (dlr)
                {
                    case DialogResult.Yes:
                        var f = new FileInfo(@"setup.txt");
                        if(f.Exists == true)
                        {
                            var sw = new StreamWriter(new FileStream(@"setup.txt", FileMode.Append));   //FileMode.Append -> 파일을 열고 끝까지 검색.
                            var s = "";
                            if(this.cbKind.Text == "영어")
                            {
                                s = "2" + "&" + this.txtInsert.Text;
                            }
                            else
                            {
                                s = "1" + "&" + this.txtInsert.Text;
                            }

                            sw.WriteLine(s);        //s 문자열과 줄 종결자를 차례로 텍스트문자열에 씀.
                            sw.Close();
                            this.lvWord.Items.Add(this.txtInsert.Text);
                        }
                        else
                        {
                            var sw = File.CreateText(@"setup.txt");
                            var s = "";
                            if(this.cbKind.Text == "영어")
                            {
                                s = "2" + "&" + this.txtInsert.Text;
                            }
                            else
                            {
                                s = "1" + "&" + this.txtInsert.Text;
                            }
                            sw.WriteLine(s);
                            sw.Close();
                            this.lvWord.Items.Add(this.txtInsert.Text);
                        }
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
                this.txtInsert.Text = "";
                this.txtInsert.Focus();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;     //frm1에 대화상자의 결과값을 전달.
        }
    }
}

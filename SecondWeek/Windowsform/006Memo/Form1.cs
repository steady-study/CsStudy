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

namespace _006Memo
{
    public partial class Form1 : Form
    {
        private Boolean txtNoteChange;      //내용변경체크
        private string fWord;               //찾기 문자열에 사용
        private Form2 frm2;                 //다음찾기할때 사용
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            this.txtNoteChange = true;      //입력된 데이터가 추가되거나 수정될때 txtNoteChange가 true로 변경됨. 
                                            //이 변수에 따라 입력된 데이터를 저장하는 작업 하기때문에 메인 변수로 지정되어 관리되어야 함.
        }

        private void newNToolStripMenuItem_Click(object sender, EventArgs e)        //새로만들기
        {
            if(this.txtNoteChange == true)      //텍스트박스의 내용이 바뀌어서 txtNoteChange==true가 참임.
            {
                var msg = this.Text + "파일의 내용이 변경되었습니다. \r\n 변경된 내용을 저장하시겠습니까?";
                var dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                
                if(dlr == DialogResult.Yes)
                {
                    textSave();                     //textSave() 메서드 호출
                    this.txtNote.ResetText();       //ResetText -> Text속성을 기본값(string.Empty)로 다시 설정. 비우는거.
                    this.Text = "제목 없음";
                }
                else if(dlr == DialogResult.No)
                {
                    this.txtNote.ResetText();
                    this.Text = "제목 없음";
                    this.txtNoteChange = false;
                }
                else if(dlr == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    this.txtNote.ResetText();
                    this.Text = "제목 없음";
                    this.txtNoteChange = false;
                }
            }
        }
        private void textSave()
        {
            if(this.Text == "제목 없음")
            {
                var dlr = this.sfdFile.ShowDialog();        //saveFileDialog 실행
                if(dlr != DialogResult.Cancel)
                {
                    var str = this.sfdFile.FileName;        //파일 경로
                    var sw = new StreamWriter(str, false, Encoding.UTF8);
                    //              기록할 전체파일 경로/데이터를 파일에 추가하려면 true, 덮어쓰려면 false/사용할 문자 인코딩

                    //streamWriter -> 지정된 인코딩 및 기본 버퍼 크기를 사용하여 지정된 파일에 대해 StreamWriter클래스의 새 인스턴스 초기화.
                    //해당 파일이 있으면 덮어쓰거나 추가하고, 해당 파일이 없으면 새로운 파일을 만듦.

                    sw.Write(this.txtNote.Text);    //.Write -> 데이터를 스트림에 씀.
                    sw.Flush();         //writer의 모든 버퍼를 지우면 버퍼링된 모든 데이터가 내부 스트림에 쓰여짐
                                        //flush를 명시적으로 호출하지 않으면, 플러시 하는동안 기본 인코더가 플러시 되지 않음.
                    sw.Close();         //내부 스트림 닫아줌. sw 개체 리소스 제거

                    var f = new FileInfo(str);
                    this.Text = f.Name;
                    this.txtNoteChange = false;

                }
            }

            else    //폼의 제목, form.Text의 내용이 "제목 없음"이 아닌경우. 기존 파일을 불러와서 수정후 원래 파일이름 그대로/변경후 저장할때. ex)다른이름으로 저장.
            {
                var strt = this.Text;
                var sw = new StreamWriter(strt, false, Encoding.UTF8);
                sw.Write(this.txtNote.Text);
                sw.Flush();
                sw.Close();
                this.Text = strt;
                this.txtNoteChange = false;
            }
        }

        private void openOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtNoteChange == true) //텍스트 박스 데이터가 수정 및 추가되었을 때
            {
                var msg = this.Text + " 파일의 내용이 변경되었습니다. \r\n 변경된 내용을 저장하시겠습니까?";
                var dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dlr == DialogResult.Yes)
                {
                    textSave(); // 저장
                    textOpen(); // 파일 열기 메서드 호출
                }
                else if (dlr == DialogResult.No)
                {
                    textOpen(); // 파일 열기 메서드만 호출
                }
                else if (dlr == DialogResult.Cancel)
                {
                    return; //저장 및 열기 하지 않고 모든 작업을 취소한다.
                }
            }
            else //텍스트박스 데이터가 수정/추가되지 않았음.
            {
                textOpen(); // 파일 열기 메서드 호출.
            }
        }

        private void textOpen()
        {
            var dr = this.ofdFile.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                var str = this.ofdFile.FileName;        //파일 경로
                var sr = new StreamReader(str, Encoding.UTF8);   //StreamReader(읽을 전체 파일 경로, 사용할 문자 인코딩)
                this.txtNote.Text = sr.ReadToEnd();     //.ReadToEnd() -> 처음부터 끝까지 모든 문자 읽기.
                sr.Close();

                var f = new FileInfo(str);
                this.Text = f.Name;
                this.txtNoteChange = false;
                //MessageBox.Show("ok");
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;        //폼의 종료를 정지하는 작업.
            if(this.txtNoteChange == true)      //텍스트 박스 창에 변경된 내용이 있을경우
            {
                var msg = this.Text + " 파일 내용이 변경되었습니다.\n 변경된 내용을 저장하시겠습니까?";
                var dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                
                if(dlr == DialogResult.Yes)     //저장하겠다.
                {
                    if(this.Text == "제목 없음")        //form.Text == 제목 없음. 일때. 새로 만든 상황일때
                    {
                        var dr = this.sfdFile.ShowDialog();         //다른이름으로 저장하기 창 띄움.
                        if(dr != DialogResult.Cancel)       //저장하기 창에서 저장 눌렀을때 실행
                        {
                            var str = this.sfdFile.FileName;    //파일 경로
                            var sw = new StreamWriter(str, false, Encoding.UTF8);
                            sw.Write(this.txtNote.Text);        //텍스트창 데이터를 sw스트림에 문자열 쓰고
                            sw.Flush();                         //
                            sw.Close();                         //sw개체 닫기.
                            this.txtNoteChange = false;
                        }
                    }
                    else //form.Text != "제목 없음"일때. ex)저장되있었던 파일 불러와서 수정
                    {
                        var strt = this.Text;
                        var sw = new StreamWriter(strt, false, Encoding.UTF8);
                        sw.Flush();
                        sw.Close();
                        this.txtNoteChange = false;
                    }
                    this.Dispose();     //dlr == DialogResult.Yes해서 열린 모든 리소스 해제
                }
                else if(dlr == DialogResult.No)     //저장 안하겠다.
                {       
                    this.Dispose();         //열린 모든 리소스 해제하고 폼 끄기.
                }
                else if(dlr == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                this.Dispose();
            }
        }

        private void saveSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSave();
        }

        private void saveAsAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlr = this.sfdFile.ShowDialog();
            if(dlr != DialogResult.Cancel)
            {
                var str = this.sfdFile.FileName;        //파일 경로
                var sw = new StreamWriter(str, false, Encoding.UTF8);
                sw.Write(this.txtNote.Text);        //지정된 경로에 txtNote 입력 문자열 저장.
                sw.Flush();
                sw.Close();

                var f = new FileInfo(str);
                this.Text = f.Name;
                this.txtNoteChange = false;
                this.txtNote.ResetText();
                this.Text = "제목 없음";
            }
        }

        private void findPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(frm2 == null || !frm2.Visible))        //form2가 있거나, 컨트롤이 효시되면
            {
                frm2.Focus();
                return;
            }

            frm2 = new Form2();

            if (this.txtNote.SelectionLength == 0)    //SelectionLength속성 : 선택한 문자 수.
            {
                frm2.txtWord.Text = this.fWord;
            }
            else
            {
                frm2.txtWord.Text = this.txtNote.SelectedText;      //선택한 문자가 있으면, 그 선택한 문자를 form2 txtWord컨트롤의 text 속성값(찾을 문자열)에 저장
            }

            frm2.btnOK.Click += new System.EventHandler(this.btnOK_Click);      
            //btnOK버튼과 찾는 문자를 입력하는 컨트롤은 frm2에 위치하기 때문에 btnOK_Click을 대리자를 사용하여 frm2의 btnOK 컨트롤에 연결하여 사용.

            frm2.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var updown = -1;
            var str = this.txtNote.Text;        //본문 내용 str에 할당
            var findWord = frm2.txtWord.Text;

            if (!frm2.chb.Checked)              //체크박스에 체크가 되어있지 않으면, 대소문자 구분을 하지 않으려면,
            {
                str = str.ToUpper();                //텍스트의 내용과 검색 창 텍스트 내용을 모두 다 대문자로 변환.
                findWord = findWord.ToUpper();
            }

            if(!(frm2.txtWord.Text == ""))
            {
                if (frm2.rdb01.Checked)
                {
                    if (this.txtNote.SelectionStart != 0)
                    {
                        updown = str.LastIndexOf(findWord, this.txtNote.SelectionStart + this.txtNote.SelectionLength);
                        //지정된 문자 위치에서 문자열의 시작 부분을 향해 검색이 진행 
                        //findword -> 검색할 문자열 /검색할 시작할 위치 = 텍스트상자에서 선택한 텍스트의 시작지점 + 선택한 문자수 
                        //해당 문자나 문자열이 없으면 LastIndexOf 메서드는 -1을 반환.
                    }
                }
                else
                {
                    updown = str.IndexOf(findWord, this.txtNote.SelectionStart + this.txtNote.SelectionLength);
                    //지정된 문자 위치에서 맨 처음 발견되는지정된 문자열의 0부터 시작하는 인덱스를 보고. 뒤쪽으로 검색 진행
                }
            }
            else
            {
                MessageBox.Show("문자열을 입력하세요.");
            }
            


            if(updown == -1)        //LastIndexOf나 IndexOf메서드는 찾는 문자나 문자열이 없으면 -1을 반환. ∴ 찾는 문자/문자열이 없는 경우.
            {
                MessageBox.Show("더이상 찾는 문자열이 없습니다.", "메모장", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            this.txtNote.Select(updown, findWord.Length);
            //Select -> 텍스트 상자의 텍스트 범위 선택 /선택영역에 있는 첫 문자의 인덱스(0)./ 선택 영역의 문자의 길이
            fWord = frm2.txtWord.Text;
            this.txtNote.Focus();
            this.txtNote.ScrollToCaret();   //현재 컨트롤의 내용을 현재 캐럿 위치까지 스크롤.
        }
        

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoUToolStripMenuItem_Click(object sender, EventArgs e)       //실행 취소
        {
            this.txtNote.Undo();
        }

        private void cutTToolStripMenuItem_Click(object sender, EventArgs e)        //잘라내기
        {
            this.txtNote.Cut();
        }

        private void copyCToolStripMenuItem_Click(object sender, EventArgs e)       //복사하기
        {
            this.txtNote.Copy();
        }

        private void pastePToolStripMenuItem_Click(object sender, EventArgs e)      //붙여넣기
        {
            this.txtNote.Paste();
        }

        private void deleteLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.SelectedText = "";
        }

        private void selectAllAToolStripMenuItem_Click(object sender, EventArgs e)      //모두 선택
        {
            this.txtNote.SelectAll();
        }

        private void fontFToolStripMenuItem_Click(object sender, EventArgs e)       //글꼴
        {
            if(this.fdText.ShowDialog() == DialogResult.OK)
            {
                this.txtNote.Font = this.fdText.Font;
            }
        }

        private void wordWrapWToolStripMenuItem_Click(object sender, EventArgs e)       //자동 줄바꿈
        {
            this.txtNote.WordWrap = !(this.txtNote.WordWrap);
            wordWrapWToolStripMenuItem.Checked = !(wordWrapWToolStripMenuItem.Checked);
        }

        private void timeDateDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToShortTimeString();        //현재 시간 값을 문자열 표현으로 변환.
            var date = DateTime.Today.ToShortDateString();      //오늘 날짜 값을 문자열 표현으로 변환.

            this.txtNote.AppendText(time + "/" + date);
            //AppendText -> 텍스트 추가.
        }

        private void informationAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        
    }
}

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
using System.Collections;

namespace _008TypingWord
{
    public partial class Form1 : Form
    {
        private string kind = "";       //한글, 영어
        int array = 0;                  //랜덤수 지정
        int jumsu = 0;                  //점수
        int selectlbl;                  //1~6 랜덤수 랜덤벽돌 지정
        int maxjumsu = 0;               //최종 점수
        private string[] word;          //배열에 워드 지정
        private string[] TempKorWord = new string[] { "가나다", "라마바", "아자차", "카파하", "도레미파", "솔라시도" };
        private string[] TempEngWord = new string[] { "abc", "def", "ghi", "demo", "jpg", "gif" };
        private ArrayList ArrayWord = new ArrayList();
        //string FilePath = @"C:\Users\user\Desktop\CS\SecondWeek\Windowsform\008TypingWord\";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var Rekind = 0;
            if(File.Exists("setup.txt") == false)
            {
                MessageBox.Show("단어가 없어 기본 게임으로 시작합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (kind == "한글")           //setup.txt파일의 종류가 한글일때
                    word = TempKorWord;      //한글 문자열 담은 배열을 word에 할당
                else
                    word = TempEngWord;      //영어 문자열 담은 배열을 word에 할당.

                array = word.Length;         //word의 요소 총 수를 array에 할당.
            }
            else        //setup.txt파일 존재
            {
                if(kind == "한글")
                {
                    Rekind = 1;             //Rekind에 1 할당.
                }
                else if(kind == "영어")
                {
                    Rekind = 2;             //2 할당.
                }
                else
                {
                    Rekind = 1;
                }

                var srt = File.OpenText(@"setup.txt");      //setup.txt파일을 읽기전용으로 읽어옴

                while (true)
                {
                    var str = srt.ReadLine();           //한줄씩 문자열 읽어와서 str에 할당.
                    if (str == null)
                        break;

                    var a_str = str.Split('&');             //한줄씩 읽어온str을 &를 기준으로 분할해서 a_str에 할당.

                    if (a_str[0] == Convert.ToString(Rekind))               //Rekind값을 문자열로 변환한 값이 a_str의 첫번째 값과 같으면         
                    {
                        //System.Diagnostics.Debug.WriteLine("a_str[0] = " + a_str[0]);
                        ArrayWord.Add(a_str[1]);        //a_str의 두번째 값을 ArrayList로 인스턴스화 시큰 ArrayWord에 할당.
                        //System.Diagnostics.Debug.WriteLine("" + a_str[1]);
                    }
                }
                array = ArrayWord.Count;            //array에 ArrayWord의 실제 요소 수 할당.
                srt.Close();                        //srt파일 닫기.

                if (ArrayWord.Count < 5)            //ArrayWord의 요소 수가 5보다 작으면
                {
                    MessageBox.Show("단어가 적절하지 않아 기본 게임으로 시작합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (kind == "한글")
                        word = TempKorWord;
                    else
                        word = TempEngWord;     //지정되어있는 배열형 문자열들 word에 저장
                    array = word.Length;        //배열의 길이 array에 할당.
                    
                }
                else
                {
                    word = new string[ArrayWord.Count];     //ArrayWord의 요소 수를 word에 할당.
                    int i = 0;

                    foreach(string wd in ArrayWord)     //ArrayWord의 수만큼 반복문.
                    {
                        word[i++] = wd;                 //word의 배열을 하나씩 꺼내옴.
                    }
                }
            }

            this.lblLife.Width = 150;           //lblLife너비 150.
            this.txtJumsu.Text = "0";           //txtJumsu 0
            MessageBox.Show("제 " + lblGrade.Text + "단계입니다.");       //환경설정 클릭시 발생한 이벤트에서 받아온 lblGrade.Text

            this.txtInsert.Focus();

            if(randomtim.Enabled == false)              
            {
                randomtim.Enabled = true;               //randomtim 실행중으로
                var r = new Random();
                var i = r.Next(0, array - 4);            //0<=  r< array(Array.Word의 실제 요소값) - 4 을 i에 할당.
                this.button1.Text = word[i];
                this.button2.Text = word[i + 1];
                this.button3.Text = word[i + 2];
                this.button4.Text = word[i + 3];
                this.button5.Text = word[i + 4];
            }            
        }
        
        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var frm2 = new Form2();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                this.lblGrade.Text = frm2.ReturnStep;
                kind = frm2.ReturnKind;
            }
            
        }

        private void 사용자설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm3 = new Form3();
            if(frm3.ShowDialog() == DialogResult.OK)
            {
                this.lblName.Text = frm3.ReturnName;

                if(frm3.checkNum == 1)
                {
                    this.lblImg.ImageIndex = 0;
                }
                else
                {
                    this.lblImg.ImageIndex = 1;
                }
                this.lblImg.Text = null;
                this.btnStart.Enabled = true;
                this.btnStop.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.randomtim.Enabled = false;
            this.btn1tim.Enabled = false;
            this.btn2tim.Enabled = false;
            this.btn3tim.Enabled = false;
            this.btn4tim.Enabled = false;
            this.btn5tim.Enabled = false;           //게임 더이상 진행되지 않게 timer멈추기. 

            this.array = 0;

            if(this.txtJumsu.Text == "")
            {
                MessageBox.Show("게임 시작 후에 정지할 수 있습니다.");
            }
            else
            {
                try
                {
                    if (Convert.ToInt32(this.txtJumsu.Text) > maxjumsu)         //현재 점수가 최고점수보타 높을 경우 현재점수를 최고 점수 칸에 넣는 과정.
                    {
                        this.txtMaxJumsu.Text = this.txtJumsu.Text;
                    }                    
                    this.txtJumsu.Text = "0";

                    for (var i = 0; i < this.plMain.Controls.Count; i++)        //판넬 컨트롤의 개수만큼(버튼 개수만큼) 반복.
                    {
                        this.plMain.Controls[i].Top = 0;                    //버튼의 Top속성값을 0으로 입력.
                    }
                }
                catch { }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            btnStart.Focus();
            //MessageBox.Show("게임 전에 사용자 설정과 환경 설정을 하시려면 \n 왼쪽 상단 설정 탭을 눌러주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtInsert_KeyDown(object sender, KeyEventArgs e)
        {
            var r = new Random();
            int randomtxt;

            if (e.KeyCode == Keys.Enter)
            {
                for (var i = 0; i <this.plMain.Controls.Count; i++)
                {

                    //                    if((this.plMain.Controls[i]).Text == this.txtInsert.Text) {
                    if (this.txtInsert.Text == (this.plMain.Controls[i]).Text)
                    {
                        this.txtInsert.Text = null;

                        randomtxt = r.Next(0, array);
                        (this.plMain.Controls[i]).Text = this.word[randomtxt];
                        jumsu += 10;
                        (this.plMain.Controls[i]).Top = 0;
                        this.txtJumsu.Text = Convert.ToString(jumsu);

                        this.txtInsert.Text = null;
                    }                  
                    
                }
                this.txtInsert.Text = null;
            }
        }

        private void randomtim_Tick(object sender, EventArgs e)         //버튼 위치 랜덤으로 바꿔줌.
        {
            var r = new Random();
            selectlbl = r.Next(1, 6);       //1부터 5까지 seleclbl에 할당.

            switch (selectlbl)              
            {
                case 1:
                    this.btn1tim.Enabled = true;
                    break;
                case 2:
                    this.btn2tim.Enabled = true;
                    break;
                case 3:
                    this.btn3tim.Enabled = true;
                    break;
                case 4:
                    this.btn4tim.Enabled = true;
                    break;
                case 5:
                    this.btn5tim.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btn1tim_Tick(object sender, EventArgs e)       
        {
            var r = new Random();               //random값 할당.
            var txt = r.Next(0, array);         //

            if((this.plMain.Controls[0]).Top <= this.plMain.Height - (this.plMain.Controls[0]).Height)
            {
                (this.plMain.Controls[0]).Top += 20;
            }
            else
            {
                (this.plMain.Controls[0]).Top = -0;
                (this.plMain.Controls[0]).Text = word[txt];
                if(lblLife.Width != 0)
                {
                    lblLife.Width -= 20;
                }
                
            }
        }

        private void btn2tim_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            var txt = r.Next(0, array);
            if ((this.plMain.Controls[1]).Top <= this.plMain.Height - (this.plMain.Controls[1]).Height)
            {
                (this.plMain.Controls[1]).Top += 20;
            }
            else
            {
                (this.plMain.Controls[1]).Top = 0;
                (this.plMain.Controls[1]).Text = word[txt];
                if (lblLife.Width != 0)
                {
                    lblLife.Width -= 20;
                }
                
            }
        }

        private void btn3tim_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            var txt = r.Next(0, array);
            if ((this.plMain.Controls[2]).Top <= this.plMain.Height - (this.plMain.Controls[2]).Height)
            {
                (this.plMain.Controls[2]).Top += 20;
            }
            else
            {
                (this.plMain.Controls[2]).Top = -0;
                (this.plMain.Controls[2]).Text = word[txt];
                if (lblLife.Width != 0)
                {
                    lblLife.Width -= 20;
                }
                
            }
        }

        private void btn4tim_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            var txt = r.Next(0, array);
            if ((this.plMain.Controls[3]).Top <= this.plMain.Height - (this.plMain.Controls[3]).Height)
            {
                (this.plMain.Controls[3]).Top += 20;
            }
            else
            {
                (this.plMain.Controls[3]).Top = 0;
                (this.plMain.Controls[3]).Text = word[txt];
                if (lblLife.Width != 0)
                {
                    lblLife.Width -= 20;
                }
                
            }
        }

        private void btn5tim_Tick(object sender, EventArgs e)
        {
            var r = new Random();
            var txt = r.Next(0, array);
            if ((this.plMain.Controls[4]).Top <= this.plMain.Height - (this.plMain.Controls[4]).Height)
            {
                (this.plMain.Controls[4]).Top += 20;
            }
            else
            {
                (this.plMain.Controls[4]).Top = 0;
                (this.plMain.Controls[4]).Text = word[txt];
                if (lblLife.Width != 0)
                {
                    lblLife.Width -= 20;
                }                
            }
        }

        private void lblLife_SizeChanged(object sender, EventArgs e)        //생명바 사이즈 변화시 발생 이벤트.
        {
            if(lblLife.Width == 0)              //너비가 0이되면
            {
                randomtim.Enabled = false;
                btn1tim.Enabled = false;
                btn2tim.Enabled = false;
                btn3tim.Enabled = false;
                btn4tim.Enabled = false;
                btn5tim.Enabled = false;        //타이머 종료.

                if(Convert.ToInt32(this.txtJumsu.Text) > maxjumsu)      //점수textBox의 텍스트가 최고TextBox의 텍스트값보다 클때
                {
                    this.txtMaxJumsu.Text = this.txtJumsu.Text;             //현재 점수를 최고점수에 할당.
                }

                for(var i = 0; i<this.plMain.Controls.Count; i++)       //panel안 텍스트 버튼만큼 반복
                {
                    (this.plMain.Controls[i]).Top = 0;                  //텍스트버튼 위쪽 가장자리에 0값 할당.
                }

                this.txtJumsu.Text = "0";
                MessageBox.Show("죽었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.btnStart.Focus();
            }
        

        
        }

        private void lblGrade_TextChanged(object sender, EventArgs e)       //lblGrade 텍스트 내용이 변할때 발생하는 이벤트.
        {
            switch (Convert.ToInt32(lblGrade.Text))         //10단계까지 timer.Interval이 줄어듦.
            {
                case 1:
                    btn1tim.Interval = 1000;
                    btn2tim.Interval = 1000;
                    btn3tim.Interval = 1000;
                    btn4tim.Interval = 1000;
                    btn5tim.Interval = 1000;
                    break;
                case 2:
                    btn1tim.Interval = 900;
                    btn2tim.Interval = 900;
                    btn3tim.Interval = 900;
                    btn4tim.Interval = 900;
                    btn5tim.Interval = 900;
                    break;
                case 3:
                    btn1tim.Interval = 800;
                    btn2tim.Interval = 800;
                    btn3tim.Interval = 800;
                    btn4tim.Interval = 800;
                    btn5tim.Interval = 800;
                    break;
                case 4:
                    btn1tim.Interval = 700;
                    btn2tim.Interval = 700;
                    btn3tim.Interval = 700;
                    btn4tim.Interval = 700;
                    btn5tim.Interval = 700;
                    break;
                case 5:
                    btn1tim.Interval = 500;
                    btn2tim.Interval = 500;
                    btn3tim.Interval = 500;
                    btn4tim.Interval = 500;
                    btn5tim.Interval = 500;
                    break;
                case 6:
                    btn1tim.Interval = 300;
                    btn2tim.Interval = 300;
                    btn3tim.Interval = 300;
                    btn4tim.Interval = 300;
                    btn5tim.Interval = 300;
                    break;
                case 7:                
                    btn1tim.Interval = 200;
                    btn2tim.Interval = 200;
                    btn3tim.Interval = 200;
                    btn4tim.Interval = 200;
                    btn5tim.Interval = 200;
                    break;
                case 8:
                    btn1tim.Interval = 100;
                    btn2tim.Interval = 100;
                    btn3tim.Interval = 100;
                    btn4tim.Interval = 100;
                    btn5tim.Interval = 100;
                    break;
                case 9:
                    btn1tim.Interval = 80;
                    btn2tim.Interval = 80;
                    btn3tim.Interval = 80;
                    btn4tim.Interval = 80;
                    btn5tim.Interval = 80;
                    break;
                case 10:
                    btn1tim.Interval = 50;
                    btn2tim.Interval = 50;
                    btn3tim.Interval = 30;
                    btn4tim.Interval = 30;
                    btn5tim.Interval = 50;
                    break;
                default:                
                    btn1tim.Interval = 30;
                    btn2tim.Interval = 20;
                    btn3tim.Interval = 30;
                    btn4tim.Interval = 20;
                    btn5tim.Interval = 30;
                    break;
            }
        }

        private void txtJumsu_TextChanged(object sender, EventArgs e)       //점수창 변화시 발생하는 이벤트.
        {
            if(Convert.ToInt32(this.txtJumsu.Text) != 0)            //점수텍스트박스 안의 텍스트가 0이 아닐때
            {
                if(Convert.ToInt32(this.txtJumsu.Text)%100 == 0)    //점수를 100으로 나눠서 나머지 값이 0일때/ 점수가 100점일때
                {
                    lblGrade.Text = Convert.ToString(Convert.ToInt32(lblGrade.Text) + 1);   //현재 난도에 +1 한 값 lblGrade.Text에 할당.
                    
                    for(int i = 0; i<this.plMain.Controls.Count; i++)       //panel안 텍스트 버튼수만큼 반복문
                    {
                        (this.plMain.Controls[i]).Top = 0;          //텍스트 버튼들 다 위로 올림.
                    }
                    btn1tim.Enabled = false;
                    btn2tim.Enabled = false;
                    btn3tim.Enabled = false;
                    btn4tim.Enabled = false;
                    btn5tim.Enabled = false;            //타이머들 초기화.
                    this.txtInsert.Text = null;         //입력 텍스트창 초기화
                    this.txtInsert.Focus();
                }
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;        //종료 중지하는 코드.
            var dlr = MessageBox.Show("폼을 종료합니다", "끝내기", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (dlr)
            {
                case DialogResult.Yes:
                    Application.ExitThread();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}

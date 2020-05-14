using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002Survey
{
    public partial class SurbeyForm1 : Form
    {
        public SurbeyForm1()
        {
            InitializeComponent();
        }

        private void btnPoll_Click(object sender, EventArgs e)      //제출하기 버튼 눌렀을때 발생하는 이벤트
        {
            if(this.chb01.Checked == true || this.chb02.Checked == true)      //체크박스 버튼이 둘중에 하나라도 눌렸을때
            {
                foreach (RadioButton c in this.gbHobby.Controls)        //gbHobby 그룹박스 내에 있는 RadioButton의 요소를 다 가져옴.
                {
                    if (c.Checked == true)      //그 요소가 체크 상태이면
                        this.lblHobby.Text = c.Text;        //요소의 Text값을 lblHobby값에 대입.
                }

                this.lblSports.Text = "";       
                //제출하기 버튼 누를때마다 + 체크박스 버튼 한개이상 눌렸을때마다 "스포츠는 : " 글자 초기화

                foreach(CheckBox c in this.gbSports.Controls)
                //foreach는 배열이나 컬렉션에 주로 사용. 컬렉션과 배열의 각 요소를 한개씩 꺼내와서 foreach 루프 내의 블럭을 실행할때 사용.
                {
                    if(c.Checked == true)
                    {
                        this.lblSports.Text += c.Text + " ";
                    }
                }
            }
            else
            {
                MessageBox.Show("좋아하는 스포츠를 선택해 주세요");
            }
        }
    }
}


//radio button은 선택 옵션을 보여주는 컨트롤. 두개 이상 선택 할수 없다. 
//만약 두개 이상 선택하고 싶다면 groupBox 컨테이너를 이용해 컨트롤들을 각 그룹에 넣으면 됨.


using System;
using System.Collections;   //목록,큐,비트 배열, 해시 테이블 및 사전과 같은 다양한 컬렉션을 정의하는 인터페이스와 클래스 포함
using System.Windows.Forms;

namespace _007HeaderSort    //어려움.
{
    public partial class HeaderSorting : Form
    {        
        private bool Isort = true;      //칼럼 정렬을 오름 또는 내림으로 구분하여 정렬할 수 있도록 멤버변수 추가.
     
        public HeaderSorting()
        {
            InitializeComponent();
        }         
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ControlCheck() == true)
            {
                var strArray = new String[] { this.txtName.Text, this.txtPhone.Text };
                //string타입의 배열에 입력받은 문자열을 저장하고, strArray변수에 할당.
                var lvt = new ListViewItem(strArray);
                //lvt개체 생성, 매개변수에 배열을 전달하여 생성한다.

                this.lvCall.Items.Add(lvt); //lvt개체를 추가해서 lbCall items속성값입력
                this.txtName.Clear();       //이름 텍스트창 텍스트 삭제
                this.txtPhone.Clear();      //폰번호 텍스트창 텍스트 삭제.
            }
            else
            {
                return;
            }
        }

        private Boolean ControlCheck()  //각 입력 컨트롤의 입력 유효성 검사하는 코드.
                                        //txtName과 txtPhone 컨트롤에 입력된 문자열이 없다면 오류메시지 창을 출력하고 fasle값 반환,
                                        //입력된 문자열이 있다면 true값을 반환하여 lvCall 컨트롤에 아이템 추가작업.
        {
            if (this.txtName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();       //커서가 txtName으로 이동.
                return false;
            }
            else if (this.txtPhone.Text == "")
            {
                MessageBox.Show("전화번호를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPhone.Focus();
                return false;
            }
            else    //이름과 전화번호가 입력 되었을 경우.
            {
                return true;
            }
        }

        private void lvCall_ColumnClick(object sender, ColumnClickEventArgs e)//열 머리글 클릭할때 발생하는 이벤트
        {
            if (Isort == true)      //기본값.
            {
                this.lvCall.ListViewItemSorter = new ListViewItemComparer(e.Column, Isort);     //클릭된 열의 인덱스와 bool값을 lvCall.ListViewItemSorter에 할당
                Isort = false;  //Isort를 false로 바꿔줌.
            }
            else
            {
                this.lvCall.ListViewItemSorter = new ListViewItemComparer(e.Column, Isort);

                Isort = true;
            }
        }
        class ListViewItemComparer : IComparer  //칼럼 데이터를 정렬하는 작업을 수행하는 클래스.
            //IComparer(두 개체를 비교하는 Comparer 메서드 사용할 수 있게함.)인터페이스 상속
        {
            private int col;
            //public string sort = "asc";
            private bool z;
            public ListViewItemComparer(int column, bool v) //칼럼 헤더를 누를때 한번 실행.
            {
                col = column;   //몇번째 column인지 나타내는 변수.
                z = v;      //정렬 구분을 z에 할당. //오름차순
            }

            public int Compare(object x, object y)  //칼럼에 데이터가 존재하는 만큼 호출 되면서 칼럼 데이터를 정렬.
            {
                object a, b;
                if(z == true)       //오름차순인 경우
                {
                    a = x;      //비교할 첫번째 객체를 a에 할당
                    b = y;      //비교할 두번째 객체를 b에 할당.
                }
                else                //내림차순인 경우
                {
                    a = y;      //비교할 두번째 객체를 a에할당
                    b = x;      //비교할 첫번째 객체를 b에 할당
                }

                return String.Compare(((ListViewItem)a).SubItems[col].Text, ((ListViewItem)b).SubItems[col].Text);
                //정리된 a,b를 ListViewItme에 SubItem[col](listViewItem 모든 하위항목의 [col]번째 열에 텍스트 삽입. )
            }
        }
        
    }
}

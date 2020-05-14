using System;
using System.Windows.Forms;
using System.Data;  //ADO.NET 아케텍처를 나타내는 클래스에 대한 엑세스를 제공. ADO.NET을 통해 여러 데이터 원본의 데이터를 효율적으로 관리할 수 있는 구성요소 만들수 있다.
//연결이 끊긴 인터넷과 같은 시나리오에서 다계층 시스템에서 데이터를 요청, 업데이트 및 조정하는 도구를 제공.
//ADO.NET은 모든 데이터베이스 처리 명령어. C#클래스들의 모임. / SQL Server, Oracle 등 모든 데이터베이스 접근 가능.
using Microsoft.VisualBasic;
//visyal Basic에서 Visual Basic 런타임을 지원하는 형식 들어있음.

namespace _004Diary
{
    public partial class Diary : Form
    {
        string[] i = new string[365];   //멤버변수 i / 클래스 내에 모든 함수 또는 상속받는 자식에서 사용하고자 한다면 클래스 바로 아래에 선언.
        public Diary()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var datTim1 = Convert.ToDateTime("#1/1/2020#");     //초기날짜로 지정된 문자열 표현을 해당하는 날짜와 시간값으로 변환.
            DateTime datTim2 = this.dtpTime.Value;              //이 컨트롤의 현재 시간과 날짜를 datTim2에 할당.
            int wD = Convert.ToInt32(DateAndTime.DateDiff(DateInterval.Day, datTim1, datTim2, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
            //날짜 및 시간 작업에 사용되는 속성값(long형)을 int로 변환해 wD에 할당.
            /*DateDiff(DateInterval(Date1과 Date2 사이의 시간차 단위로 사용할 시간 간격을 나타내는 DateInterval열거형 값 또는 String식),
             * date1(계산에 사용할 첫째 날짜/시간 값), date2(계산에 사용할 둘째 날짜/시간 값),
             * dayOfWeek(선택적 요소. 첫째 요일 지정. 지정하지 않는다면 FirstDayOFWeek.Sunday가 기본 값),
             * weekOfYear(선택적 요소. 첫째 주 지정. 지정하지 않는다면 FirstWeekOfYear.Jan1가 기본 값). )
             * ∴ DateDiff()메서드는 두 date값 사이의 시간 간격수(시간 차//날짜 차이)를 long값으로 반환
             */

            i[wD] = this.txtMemo.Text;  //시간 차이를 배열 변수 인덱스에 지정하고, txtMemo 컨트롤의 Text속성값을 저장한다.
            //text박스에 글자가 쓰여진것을 초기 날짜와 쓴 날짜의 차이값의 배열인덱스에 1:1 매치.

            if(i[wD].Length > 0)    //텍스트박스에 텍스트가 쓰여져, wd값에 저장되면, i[wd]값은 계속 생김. ∴텍스트가 쓰였을때의 조건문.
            {
                MessageBox.Show("일기가 정상적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.txtMemo.Clear();   //저장 되었으니 텍스트박스 창은 지움.
            }
            else
            {
                MessageBox.Show("글자가 입력되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime datTim1 = Convert.ToDateTime("#1/1/2020#");    //초기 날짜 지정
            DateTime datTim2 = this.dtpTime.Value;                  //현재 시간과 날짜 할당.

            
            int wD = Convert.ToInt32(DateAndTime.DateDiff(DateInterval.Day, datTim1, datTim2)); //날짜 차이를 int형으로 변환후 wD에 할당.
            this.txtMemo.Text = i[wD];      //변수값인 wD를 배열 변수 인덱스로 지정해서  i[wD]에 저장된 값을 텍스트박스에 출력.
            /*
            bool boolwd = Convert.ToBoolean(wD);
            if(boolwd)
            {
                this.txtMemo.Text = i[wD];  //변수값인 wD를 배열 변수 인덱스로 저장해서 i[wD]에 저장된 값을 텍스트박스에 출력.
            }
            
            else
            {
                MessageBox.Show("저장된 일기가 없습니다.","알림", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            */
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003Calculator
{
    public partial class CalculatorForm1 : Form
    {
        public CalculatorForm1()
        {
            InitializeComponent();
        }

        private void cbbSelect_SelectedIndexChanged(object sender, EventArgs e) //콤보박스 컨트롤의 item속성 값이 변경되면 발생하는 이벤트
        {
            this.lbResult.Items.Clear();    //comboBox index값 바뀌면 결과값도 바뀌어야 하는데 밑에 쭉 쓰여지지 않게 초기화 하는 역할.
            var s = this.cbbSelect.SelectedItem.ToString(); //선택된 아이템을 가져와서 문자열로 반환하여 "s"에 대입
            var gustr = s.Split(new char[] { ' ' });    //공백을 기준으로 앞 뒤의 문자열을 char배열에 저장하고, 부분 문자열을 갖는 배열을 gurst에 반환.


            this.lbResult.Items.Add(gustr[0] + "단 실행 결과"); //
            
            this.lbResult.Items.Add(" ");
            for(var i = 1; i<10; i++)   //2단부터 9단까지 증가하면서 반복문 돌리기.
            {
                this.lbResult.Items.Add(gustr[0] + '*' + i.ToString() + " = " + (Convert.ToInt32(gustr[0]) * i).ToString());
                //Convert.ToInt32() -> 문자열을 32비트 부호있는 정수로 변환// ToString() -> 문자열 반환.
            }

        }
    }
}

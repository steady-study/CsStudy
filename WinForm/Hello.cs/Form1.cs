using System;
//주 사용되는 값과 참조 데이터 형식, 이벤트와 이벤트 처리기, 인터페이스, 특성, 
//예외 처리 등을 정의하는 기본적인 클래스 및 기본 클래스를 포함

using System.Windows.Forms;

namespace Hello.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Hello.c#";
        }
    }
}

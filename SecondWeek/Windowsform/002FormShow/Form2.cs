using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002FormShow
{
    public partial class Form2 : Form
    {
        private double o = 0.0;

        public string SetText       //다른 클래스에서도 접근할수 있도록 public한정자 사용
        {
            set { this.Text = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;          //폼이 로드되면서 Timer 컨트롤 활성화.
        }

        private void Timer_Tick(object sender, EventArgs e)     //지정된 시간 간격이 경과할때마다 발생
        {
            if(o < 100.0)
            {
                o = o + 3.6;        //
                float c = Convert.ToSingle(o);
                float f = c / 100;
                this.Opacity = f;
            }

            else
            {
                this.Opacity = Convert.ToSingle(100 / 100);
                o = 0.0;
                this.Timer.Enabled = false;
            }
        }
    }
}

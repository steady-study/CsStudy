using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;                //Thread사용시 필요
using System.Diagnostics;              //시스템 성능 모니터링 가능.
using System.Windows.Forms;

namespace _004MemoryCheck
{
    public partial class MemoryCheck : Form
    {
        private PerformanceCounter oCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        //Windows 성능 카운터 요소 나타냄.                         categoryName,  counterName,     InstanceName
        
        private int iCPU = 0;           //CPU초기 사용률
        private bool bExit = false;     //실시간 체크 위한 while문 조건
        private Font F = new Font("굴림", 9);     //폰트 모양 지정
        private Thread checkThread;     //thread 개체 생성
        public MemoryCheck()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkThread = new Thread(getCPU_Info);      //외부에서 실행될 메서드 getCPU_Info checkThread에 할당.
            checkThread.Start();        //스레드 실행
        }

        private void getCPU_Info()      //반복문 돌면서 cpu사용률 체크
        {
            while (!bExit)
            {
                iCPU = (int)oCPU.NextValue();      //PerformanceCounter의 카운터 샘플을 가져와 int형으로 반환                
                iCPU = iCPU * 3;
                plBar.Invalidate();         //plBar 전체영역을 무효화 하고 그리기 메시지를 컨트롤로 보냄. 컨트롤 디자이너에게 다시 그리도록 신호 보냄.
                Thread.Sleep(1000);
            }
        }

        private void plBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            if (iCPU <= 60)
                G.FillRectangle(Brushes.BlanchedAlmond, 0, 0, iCPU, plBar.Height);
               //Graphics.FillRectangle(brush, 채울 사각형의 왼쪽 위 모퉁이에 대한 x좌표, y좌표, 채울 사각형의 너비, 채울 사각형의 높이)
            else if (iCPU <= 120)
                G.FillRectangle(Brushes.Wheat, 0, 0, iCPU, plBar.Height);
            else if (iCPU <= 180)
                G.FillRectangle(Brushes.NavajoWhite, 0, 0, iCPU, plBar.Height);
            else if (iCPU < 240)
                G.FillRectangle(Brushes.Orange, 0, 0, iCPU, plBar.Height);
            else
                G.FillRectangle(Brushes.DarkOrange, 0, 0, iCPU, plBar.Height);

            iCPU = iCPU / 3;
            G.DrawString(iCPU.ToString() + "%", F, Brushes.DarkRed, plBar.Width / 2 - 17, plBar.Height / 4);
            //Graphics.DrawString(그릴 문자열, 문자열 텍스트 형식을 정의하는 폰트, 그려지는 색과 질감 결정, 그려지는 텍스트의 왼쪽 위 모퉁이에 대한 x좌표, y좌표)
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkThread.Abort();        //스레드 종료.
        }
    }
}

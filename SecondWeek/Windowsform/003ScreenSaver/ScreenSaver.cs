using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _003ScreenSaver
{
    public partial class ScreenSaver : Form
    {
        private int screenWidth = 0;            //화면 가로 사이즈
        private int screenHeight = 0;           //화면 세로 사이즈
        private int marQueeLocation = 0;        //lblTitle 이동시 필요 값
        private int mXStart = 0;                //마우스 포인트 가로 좌표
        private int mYStart = 0;                //마우스 포인트 세로 좌표

        public ScreenSaver()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)     //커서 숨기고 스크린 세이버 실행
        {
            Cursor.Hide();
            ShowScreenSaver();      //ShowScreenSaver 메서드 실행
        }

        private void ShowScreenSaver()
        {
            Rectangle fullScreen = Screen.PrimaryScreen.Bounds;     //스크린의 기본 디스플레이의 범위를 사각형의 위치와 크기를 나타내는 네 정수의 집합인 fullScreen에 할당.
            screenWidth = fullScreen.Width;
            screenHeight = fullScreen.Height;

            this.pbImg.Location = new Point(Convert.ToInt32(fullScreen.Width / 2 - 200), Convert.ToInt32(fullScreen.Height / 2 - 250));
        }

        private void StopScreenSaver()          //스크린세이버 종료 메서드.
        {
            Cursor.Show();
            Timer.Enabled = false;
            Application.Exit();
        }

        private void Timer_Tick(object sender, EventArgs e)     //label  위치를 지정된 시간 간격으로, 왼쪽으로 2픽셀식 이동.
        {
            this.lblTitle.Location = new Point(this.screenWidth - marQueeLocation, 10);     //marQueeLocationr값이 늘면 왼쪽으로 이동.
            this.lblTitle.Visible = true;
            marQueeLocation += 2;               //marQueeLocation이 2씩 증가.

            if(this.lblTitle.Location.X <= -Math.Abs(this.lblTitle.Width))        //X 좌표 값이 가로크기의 음수보다 작거나 같으면, 즉 label 위치가 왼쪽으로 움직여 완전히 사라지면
            {
                Debug.WriteLine("Location.x = {0}", this.lblTitle.Location.X);
                Debug.WriteLine("lblTitle = {0}", this.lblTitle.Width);

                marQueeLocation = 0;            //다시 오른쪽 맨 끝으로 위치를 이동시킴.
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if((mXStart ==0) && (mYStart == 0))     //초기 마우스 포인터 위치 설정.
            {
                mXStart = e.X;      
                mYStart = e.Y;

                return;
            }
            else if((e.X !=mXStart) || (e.Y != mYStart))
            {
                StopScreenSaver();
            }
        }

        private void pbImg_MouseMove(object sender, MouseEventArgs e)       
        {
            if ((mXStart == 0) && (mYStart == 0))     
            {
                mXStart = e.X;
                mYStart = e.Y;

                return;
            }
            else if ((e.X != mXStart) || (e.Y != mYStart))
            {
                StopScreenSaver();
            }
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if ((mXStart == 0) && (mYStart == 0))     
            {
                mXStart = e.X;
                mYStart = e.Y;

                return;
            }
            else if ((e.X != mXStart) || (e.Y != mYStart))
            {
                StopScreenSaver();
            }
        }
    }
}

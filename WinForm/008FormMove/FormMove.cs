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

namespace _008FormMove
{
    public partial class FormMove : Form
    {
        Point ptMouseCurrentPos;        //마우스 클릭 좌표(2차원 평면에 있는 한점을 정의하는 정수 X 및 정수 Y 좌표 순서쌍)지정.
        Point ptMouseNewPos;            //이동시 마우스 좌표
        Point ptFormCurrentPos;         //폼 위치 좌표 지정
        Point ptFormNewPos;             //이동시 폼 위치 좌표

        bool bFormMouseDown = false;    //왼쪽 마우스 클릭

        public FormMove()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //picMinimize와 picClose 초기 이미지
            this.picMinimize.Image = Image.FromFile(@"C:\Users\user\Desktop\icons\black.png");
            this.picClose.Image = Image.FromFile(@"C:\Users\user\Desktop\icons\white.png");
        }

        private void picClose_MouseDown(object sender, MouseEventArgs e)    //마우스 클릭이 머물시
        {
            this.picClose.Image = Image.FromFile(@"C:\Users\user\Desktop\icons\white.png");
        }

        private void picClose_MouseLeave(object sender, EventArgs e)        //마우스 포인터가 컨트롤 벗어날때 발생되는 이벤트
        {
            this.picClose.Image = Image.FromFile(@"C:\Users\user\Desktop\icons\yellow.png");
        }

        private void picClose_MouseMove(object sender, MouseEventArgs e)    //마우스 포인터가 컨트롤 위로 이동할때 발생되는 이벤트
        {
            this.picClose.Image = Image.FromFile(@"C:\Users\user\Desktop\icons\red.png");
        }

        private void picMinimize_Click(object sender, EventArgs e)  //picMinimize 클릭시
        {
            this.WindowState = FormWindowState.Minimized;       //Windowstate속성 이용해 폼 최소화.
        }

        private void picMinimize_MouseDown(object sender, MouseEventArgs e)
        {
            this.picMinimize.Image = Image.FromFile(@"C:\Users\user\Desktop\icons\green.png");
        }

        private void picMinimize_MouseLeave(object sender, EventArgs e)
        {
            this.picMinimize.Image = Image.FromFile(@"C:\Users\user\Desktop\icons\blue.png");
        }

        private void picMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            this.picMinimize.Image = Image.FromFile(@"C:\Users\user\Desktop\icons\purple.png");
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMove_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)   //누른 마우스값이 왼쪽단추일때
            {
                bFormMouseDown = true;       //왼쪽 마우스 클릭 체크
                ptMouseCurrentPos = Control.MousePosition;  //마우스 커서의 위치를 ptMouseCurrentPos에 할당.
                ptFormCurrentPos = this.Location;           //폼의 위치좌표를 ptFormCurrentPos에 할당.
            }
        }

        private void FormMove_MouseUp(object sender, MouseEventArgs e) //마우스를 놓을때 발생되는 이벤트
        {
            if (e.Button == MouseButtons.Left)        //놓은 마우스가 왼쪽 단추일때
            {
                bFormMouseDown = false;     //왼쪽 마우스 클릭 해제
            }
        }

        private void FormMove_MouseMove(object sender, MouseEventArgs e)
        {
            if(bFormMouseDown == true)
            {
                ptMouseNewPos = Control.MousePosition;      //마우스커서위치를 ptMouseNewPos에 할당
                ptFormNewPos.X = ptMouseNewPos.X - ptMouseCurrentPos.X + ptFormCurrentPos.X;
                //폼 이동시 가로 좌표 = 마우스 커서의 X위치 - 마우스를 놓았을때 X위치 + 폼의 X위치좌표
                //Debug.WriteLine("{0},{1},{2},{3}", ptFormNewPos.X, ptMouseNewPos.X, ptMouseCurrentPos.X, ptFormCurrentPos.X);

                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseCurrentPos.Y + ptFormCurrentPos.Y;    //폼 이동시 y좌표
                //Debug.WriteLine("{0},{1},{2},{3}", ptFormNewPos.Y, ptMouseNewPos.Y, ptMouseCurrentPos.Y, ptFormCurrentPos.Y);

                this.Location = ptFormNewPos;
                ptFormCurrentPos = ptFormNewPos;
                ptMouseCurrentPos = ptMouseNewPos;
            }
        }
    }
}

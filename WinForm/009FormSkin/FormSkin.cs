using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009FormSkin
{
    public partial class FormSkin : Form
    {
        private bool SpeakerBarMouseDown = false;
        private bool bFormMouseDown = false;
        private bool SpeakerOn = true;

        private const int SPEKAERBAR_XPOS = 128;    //트랙바 길이
        private const int SPEKAERBAR_YPOS = 123;    //트랙바 높이
        private const int SPEKAERBAR_WIDTH = 74;    //트랙바 폭, 너비

        private string BackPath = @"C:\Users\user\Desktop\icons";
        private bool BackChange = false;

        Point ptMouseCurrentPos;        //마우스 클릭 좌표 지정
        Point ptMouseNewPos;            //이동시 마우스 좌표
        Point ptFormCurrentPos;         //폼 위치 좌표 지정
        Point ptFormNewPos;             //이동시 폼 위치 좌표
        public FormSkin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); //SetStyle:controlstyle(컨트롤의 스타일 및 동작 지정)을 true 또는 false로 설정.
            //AllPaintingInWmPaint 이 true면 깜빡임을 줄이기위한 WM_ERASEBKGND창 무시.//erage Background, 즉 배경을 지워라.
            FormDisPlay();  //form이 로드될때 FormDisPlay메서드 실행.
        }
        
        private void FormDisPlay()
        {
            this.BackgroundImage = Image.FromFile(BackPath + @"\indigo.png");
            picSpeakerTrack.Image = Image.FromFile(BackPath + @"\trackBar01.png");
            picClose.Image = Image.FromFile(BackPath + @"\닫기01.png");
            picMinimize.Image = Image.FromFile(BackPath + @"\최소화01.png");
            picPlay.Image = Image.FromFile(BackPath + @"\play05.png");
            picPause.Image = Image.FromFile(BackPath + @"\pause01.png");
            picStop.Image = Image.FromFile(BackPath + @"\stop02.png");
            picSpeaker.Image = Image.FromFile(BackPath + @"\speaker01.png");
            picFileOpen.Image = Image.FromFile(BackPath + @"\fileOpen01.png");
        }

        private void 표준ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.BackPath = @"C:\Users\user\Desktop\icons";
            BackChange = true;
            this.lblVolume.BackColor = Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));

            this.BackColor = Color.Aqua;
                // Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));

            Invalidate();   //
        }

        private void 가벼운ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackPath = @"C:\Users\user\Desktop\icons";
            BackChange = true;
            this.lblVolume.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(52)))));

            this.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(52)))));
            
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (BackChange)
            {
                FormDisPlay();
                BackChange = false;
            }
        }

        private void picSpeakerTrack_MouseDown(object sender, MouseEventArgs e)
        {
            SpeakerBarMouseDown = true;
        }

        private void picSpeakerTrack_MouseUp(object sender, MouseEventArgs e)
        {
            SpeakerBarMouseDown = false;
        }

        private void picSpeakerTrack_MouseMove(object sender, MouseEventArgs e)
        {
            if (SpeakerBarMouseDown)
            {
                if(picSpeaker.Left >= SPEKAERBAR_XPOS && picSpeakerTrack.Left<=SPEKAERBAR_YPOS + SPEKAERBAR_WIDTH)
                {
                    if (e.X > 0)
                        picSpeakerTrack.Left = picSpeakerTrack.Left + 1;
                    else
                        picSpeakerTrack.Left = picSpeakerTrack.Left - 1;
                    picSpeakerShow();
                }

                if(picSpeakerTrack.Left <= SPEKAERBAR_XPOS)
                {
                    picSpeakerTrack.Left = SPEKAERBAR_XPOS;

                    picSpeaker.Image = Image.FromFile(BackPath + @"\닫기.png");
                }
                if(picSpeakerTrack.Left >= SPEKAERBAR_XPOS + SPEKAERBAR_WIDTH)
                {
                    picSpeakerTrack.Left = SPEKAERBAR_XPOS + SPEKAERBAR_WIDTH;
                    picSpeakerShow();
                }

                this.lblVolume.Text = "Volume : " + (((picSpeakerTrack.Left - 128) * 100 / SPEKAERBAR_WIDTH)).ToString() + "%";
            }
        }

        private void picSpeakerShow()
        {
            SpeakerOn = true;
            picSpeaker.Image = Image.FromFile(BackPath + @"speaker01.png");
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                bFormMouseDown = true;
                ptMouseCurrentPos = Control.MousePosition;
                ptFormCurrentPos = this.Location;
            }
        }

        private void FormSkin_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                bFormMouseDown = false;
            }
        }

        private void FormSkin_MouseMove(object sender, MouseEventArgs e)
        {
            if(bFormMouseDown == true)
            {
                ptMouseNewPos = Control.MousePosition;
                ptFormNewPos.X = ptMouseNewPos.X - ptMouseCurrentPos.X + ptFormCurrentPos.X;

                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseCurrentPos.Y + ptFormCurrentPos.Y;

                this.Location = ptFormNewPos;
                ptFormCurrentPos = ptFormNewPos;
                ptMouseCurrentPos = ptMouseNewPos;
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

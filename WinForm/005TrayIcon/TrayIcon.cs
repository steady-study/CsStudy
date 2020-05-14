using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005TrayIcon
{
    public partial class TrayIcon : Form
    {
        public TrayIcon()
        {
            InitializeComponent();
        }

        //Boolean타입의 인자 값을 받아 폼의 Visible 속성과 nyiTray컨트롤의 Visible 속성값을 설정하는 작업
        private void VisibleChange(Boolean FormVisible, Boolean TrayIconVisible)
        {
            this.Visible = FormVisible;     //프로그램 보이기
            this.nyiTray.Visible = TrayIconVisible; //트레이아이콘 표시.
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;                //폼의 종료를 취소.
            VisibleChange(false, true);     //프로그램 감추고, 트레이아이콘은 표시
        }

        private void nyiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true, false);     //프로그램 보이고, 트레이아이콘 감춤
            
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true, true);      //프로그램도 보이고 트레이아이콘도 보이고.
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();         //Dispose : 폼에서 사용되는 관리되지 않는 리소스(크드의 논리와 무관한 데이터들. 
                                    //ex)메뉴, 비트맵, 아이콘, 커서 등등)를 해제할때 사용.
                       
            Application.Exit();     //종료.
        }
    }
}

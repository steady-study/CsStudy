using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006FontChange
{
    public partial class FontChange : Form
    {
        public FontChange()
        {
            InitializeComponent();
        }

        private void tsbtnFont_Click(object sender, EventArgs e)
        {
            if(this.fontDig.ShowDialog() == DialogResult.OK)    //fontDialog창에서 반환값이 ok이면
            {
                this.rtbText.SelectionFont = this.fontDig.Font; 
                //fontDialog(윈도우 기본[글꼴]대화상자 실행)에서 선택한 폰트를 RichBox 영역 또는 삽입 지점의 글꼴에 설정
                //RichTextBox.SelectionFont -> 현재 텍스트 선택 영역 또는 삽입 지점의 글꼴을 가져오거나 설정함.
            }
        }

        private void tsbtnColor_Click(object sender, EventArgs e)
        {
            if(this.colorDig.ShowDialog() == DialogResult.OK)
            {
                this.rtbText.SelectionColor = this.colorDig.Color;
                //colorDialog(윈도우 기본[색] 대화상자 실행)에서 선택한 글꼴을 RichBox영역 글꼴에 설정.
            }
        }
    }
}

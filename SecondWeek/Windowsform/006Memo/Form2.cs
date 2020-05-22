using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006Memo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            if(this.txtWord.Text == "")
            {
                this.btnOK.Enabled = false;     //찾기문자열창 비어있으면 다음찾기 버튼 비활성화.
            }
            else
            {
                this.btnOK.Enabled = true;      //비어있지 않으면 활성화.
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

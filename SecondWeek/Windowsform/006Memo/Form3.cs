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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.lblAbout03.Text = this.lblAbout03.Text + SystemInformation.UserName;
            this.lblAbout04.Text = this.lblAbout04.Text + SystemInformation.ComputerName;

            //SystemInformation 클래스 -> 현재 시스템 환경에 대한 정보 제공.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

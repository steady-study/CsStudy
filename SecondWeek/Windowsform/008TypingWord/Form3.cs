using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008TypingWord
{
    public partial class Form3 : Form
    {
        public int checkNum = 1;
        public string ReturnName
        {
            get { return this.txtName.Text; }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(this.rb01Img.Checked == true)
            {
                this.checkNum = 1;
            }
            else
            {
                this.checkNum = 2;
            }
            DialogResult = DialogResult.OK;
        }
    }
}

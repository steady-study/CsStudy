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
    public partial class Form3 : Form
    {
        public string SetText
        {
            set { this.Text = value; }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
            this.Opacity = Convert.ToSingle(100 / 100);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(this.Size.Width > 300 && this.Size.Height > 300)
            {
                this.Timer.Enabled = false;
            }
            else
            {
                this.Size += new Size(10, 10);
            }
        }
    }
}

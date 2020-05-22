using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace _002FormShow
{
    public partial class Form4 : Form
    {       
        private static System.Timers.Timer TimerEvent;

               
                
        public Form4()
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;

            DesktopLocation = new Point(x, y);

            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {            
            var fullScreen = Screen.PrimaryScreen.Bounds;
            this.Location = new Point((int)fullScreen.Width - 200, (int)fullScreen.Height - 60);
            
            TimerEvent = new System.Timers.Timer(2);            
            TimerEvent.Elapsed += new ElapsedEventHandler(OnPopUp);
            TimerEvent.Start();
            
        }
        
        private void OnPopUp(object sender, ElapsedEventArgs e)
        {
            if(Height < 120)
            {
                int h = Height;
                UpdateHeight(h++);

                int t = Top;
                UpdateTop(t--);
                /*
                Height++;
                Top--;
                
            }
            else
            {
                TimerEvent.Stop();
                TimerEvent.Elapsed -= new ElapsedEventHandler(OnPopUp);

                TimerEvent.Elapsed += new ElapsedEventHandler(OnPopOut);
                TimerEvent.Interval = 3000;
                TimerEvent.Start();
            }
        }

        private void OnPopOut(object sender, ElapsedEventArgs e)
        {
           
            
            while(Height > 2)
            {
                Height--;
                Top++;
            }
            
            this.Close();
        }
    }
}

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
using System.Threading;


namespace PomodorosClock
{
    public partial class frmClock : Form
    {

        int LongRec = 0;
        int ShortRec = 0;
        int Study = 0;

        int count = 3;

        int LongRecCounter = 0;
        int ShortRecCounter = 0;
        int StudyCounter = 1;

        Stopwatch time = new Stopwatch();
        
        
        public frmClock(bool con1)
        {
            InitializeComponent();

            pctbxState.BackgroundImage = Image.FromFile(@"Study.png");
            


            if (con1) { this.BackColor = Color.Pink; }
            else { this.BackColor = Color.Gray; }

            lblCronometro.Text = DateTime.MinValue.ToString("mm:ss");
            time.Start();
            Study = 1;

        }

        private void frmClock_Load(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShortPause() 
        {
            pctbxState.BackgroundImage = Image.FromFile(@"ShortRecess.png");
            time.Restart();
            Study = 0;
            ShortRec = 1;
            LongRec = 0;

            count -= 1;
            ShortRecCounter += 1;
        }
        private void LongPause()
        {
            pctbxState.BackgroundImage = Image.FromFile(@"LongRecess.png");
            time.Restart();
            Study = 0;
            ShortRec = 0;
            LongRec = 1;

            count = 3;
            LongRecCounter += 1;
        }
        private void StudyTime()
        {
            pctbxState.BackgroundImage = Image.FromFile(@"Study.png");
            time.Restart();
            Study = 1;
            ShortRec = 0;
            LongRec = 0;

            StudyCounter += 1;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (Study == 1)
            {
                TimeSpan temp = time.Elapsed;
                lblCronometro.Text = temp.ToString(@"hh\:mm\:ss");
                if (temp.TotalSeconds > 1500) 
                {
                    if (count == 0) { LongPause(); }
                    if (count != 0) { ShortPause();}
                }
            }
            if (ShortRec == 1)
            {
                TimeSpan temp = time.Elapsed;
                lblCronometro.Text = temp.ToString(@"hh\:mm\:ss");
                if (temp.TotalSeconds > 300) { StudyTime(); }
            }
            if (LongRec == 1)
            {
                TimeSpan temp = time.Elapsed;
                lblCronometro.Text = temp.ToString(@"hh\:mm\:ss");
                if (temp.TotalSeconds > 1200) { StudyTime(); }
            }

        }


    }
}

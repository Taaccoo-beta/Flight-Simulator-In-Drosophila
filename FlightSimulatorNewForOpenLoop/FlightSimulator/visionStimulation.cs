using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSimulator
{
    public partial class visionStimulation : Form
    {
        public visionStimulation()
        {
            InitializeComponent();
        }

        private Stimulations v;
        private void visionStimulation_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            v = new Stimulations(this.pictureBox1.Width, this.pictureBox1.Height, 1);
        }

        public int getDegree()
        {
            return v.getDegree();
        }

        public bool getRightOrLeft()
        {
            return v.getRightOrLeft();
        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 150;
            this.timer1.Start();
            v.setBarWidth(int.Parse(tbBarValue.Text));
            v.setSpeed(int.Parse(tbSpeedValue.Text));
        }
        private float degree=0;
        System.Diagnostics.Stopwatch sw;
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
                
            this.lblShowHeight.Text = this.pictureBox1.Height.ToString();
            this.lblShowWidth.Text = this.pictureBox1.Width.ToString();

            
            this.pictureBox1.CreateGraphics().DrawImage(v.DrawCBar(), 0, 0);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            this.label3.Text = ts.Milliseconds.ToString();

        }

        private void visionStimulation_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void visionStimulation_ResizeEnd(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            v.setRightLeft(false);

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            v.setRightLeft(true);
           
            
        }

        private void Set_Click(object sender, EventArgs e)
        {
            v.setSpeed(int.Parse(tbSpeedValue.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

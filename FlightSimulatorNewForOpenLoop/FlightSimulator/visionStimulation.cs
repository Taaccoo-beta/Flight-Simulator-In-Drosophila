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
            //v = new Stimulations(this.pictureBox1.Width, this.pictureBox1.Height, 1);
            width = this.pictureBox1.Width;
            height = this.pictureBox1.Height;
        }

        public int getDegree()
        {


            return (int)((positionNow - width / 2f) * 360 / width);
           

        }

        public bool getRightOrLeft()
        {
            return ifMoveRight;
        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            g = this.pictureBox1.CreateGraphics();

            barWidth = int.Parse(this.tbBarValue.Text);
            SpeedDegree = int.Parse(this.tbSpeedValue.Text);
            this.height = this.pictureBox1.Height;
            this.width = this.pictureBox1.Width;
            this.timer1.Interval = 50;
            this.timer1.Start();

        }
        private float degree=0;
        System.Diagnostics.Stopwatch sw;


        private int barWidth;
        private bool ifMoveRight = true;
        private int positionNow = 20;
        private int SpeedDegree = 0;
        private Graphics g;
        private int height, width;
        public int getPositionNow()
        {
            return positionNow;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sw = new System.Diagnostics.Stopwatch();
            sw.Start();
                
            this.lblShowHeight.Text = this.pictureBox1.Height.ToString();
            this.lblShowWidth.Text = this.pictureBox1.Width.ToString();
            int start = 0;
            int end = this.pictureBox1.Width;


            if (ifMoveRight)
            {
                positionNow += SpeedDegree;
                if (positionNow > end-barWidth/2)
                {
                    positionNow = start+barWidth/2;
                }
            }
            else
            {
                positionNow -= SpeedDegree;
                if (positionNow < start+barWidth/2)
                {
                    positionNow = end-barWidth/2;
                }
            }

            g.FillRectangle(new SolidBrush(Color.White), 0, 0, width, height);
            g.FillRectangle(new SolidBrush(Color.Black), positionNow - barWidth / 2, 0,  barWidth ,height );


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
            ifMoveRight = false;

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ifMoveRight = true;
            
        }

        private void Set_Click(object sender, EventArgs e)
        {
            ;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

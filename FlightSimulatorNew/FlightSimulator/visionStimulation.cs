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

        private void btnDraw_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 100;
            
            this.timer1.Start();
        }
        private float degree=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblShowHeight.Text = this.pictureBox1.Height.ToString();
            this.lblShowWidth.Text = this.pictureBox1.Width.ToString();
            
            this.pictureBox1.CreateGraphics().DrawImage(v.DrawV_Test(degree), 0, 0);
            
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
            degree -= 10;
            this.label3.Text = degree.ToString();
            if (degree < -180)
            {
                degree = 360 + degree;
            }

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            degree += 10;
            this.label3.Text = degree.ToString();
            if (degree > 180)
            {
                degree = degree - 360;
            }
        }
    }
}

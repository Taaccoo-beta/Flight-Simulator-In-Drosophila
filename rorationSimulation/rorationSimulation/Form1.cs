using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rorationSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
         
            InitializeComponent();
        }
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            Rectangle rect = new Rectangle(this.pictureBox1.Location,this.pictureBox1.Size);
            this.Invalidate(rect);

            dc1 = new DrawCircle(this.pictureBox1.Width, this.pictureBox1.Height, this.pictureBox1.Location.X, this.pictureBox1.Location.Y, this.BackColor);
            this.CreateGraphics().DrawImage(dc1.drawAera(), this.pictureBox1.Location);

            //set location
            this.locationNow = 0;

            //timer
            this.timer1.Interval = 20;
            this.timer1.Start();

            this.timer2.Interval = 20;
            this.timer2.Start();
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    Graphics dc = e.Graphics;
        //    Pen BluePen = new Pen(Color.Blue, 3);
        //    dc.DrawRectangle(BluePen, 0, 0, 50, 50);
        //    Pen RedPen = new Pen(Color.Red, 2);
        //    dc.DrawEllipse(RedPen, 0, 50, 80, 60);
        //    base.OnPaint(e);
        //}


        private Graphics g;
        private Graphics g1;
        private float widthCenter;
        private float heightCenter;

        private float locationNow;

        /// <summary>
        /// location fliter
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        private float locationFilter(float location)
        {
            if (location > 360)
            {
                return location - 360;
            }

            if (location < -360)
            {
                return location + 360;
            }

            return location;
        }

        private float getRealLocation(float location)
        {
            if (location >= 0)
            {
                return location;
            }
            else
            {
                return location + 360;
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.A:
                    this.CreateGraphics().DrawImage(dc1.rotationRightAera(10), this.pictureBox1.Location);
                    this.locationNow = locationFilter(locationNow + 10);
                    
                    break;
                case Keys.D:
                    this.CreateGraphics().DrawImage(dc1.rotationLeftAera(10), this.pictureBox1.Location);
                    this.locationNow = locationFilter(locationNow - 10);
                    break;
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        //private void button6_Click(object sender, EventArgs e)
        //{

        //    Bitmap image = new Bitmap(1000, 1000);
        //    Graphics g = Graphics.FromImage(image);


        //    //使绘图质量最高，即消除锯齿  
        //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        //    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //    g.CompositingQuality = CompositingQuality.HighQuality;
        //    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;


        //    Rectangle rect = new Rectangle((int)(widthCenter - 150), (int)(heightCenter - 150), 300, 300);
        //    g.FillPie(new SolidBrush(Color.CadetBlue), rect, 225, 90);
        //    g.FillPie(new SolidBrush(Color.FromArgb(131, 175, 155)), rect, 315, 90);
        //    g.FillPie(new SolidBrush(Color.CadetBlue), rect, 45, 90);
        //    g.FillPie(new SolidBrush(Color.FromArgb(131, 175, 155)), rect, 135, 90);

        //}

        private drawProcess dp1;
        private DrawCircle dc1;
        private void button7_Click(object sender, EventArgs e)
        {
            dc1 = new DrawCircle(this.pictureBox1.Width, this.pictureBox1.Height, this.pictureBox1.Location.X, this.pictureBox1.Location.Y, this.BackColor);
            this.CreateGraphics().DrawImage(dc1.drawAera(), this.pictureBox1.Location);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawImage(dc1.rotationRightAera(10), this.pictureBox1.Location);
            this.locationNow = locationFilter(locationNow + 10);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawImage(dc1.rotationLeftAera(10), this.pictureBox1.Location);
            this.locationNow = locationFilter(locationNow - 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dp1 = new drawProcess(600,600,this.BackColor);
            this.CreateGraphics().DrawImage(dp1.drawBackGround(),700,0);



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblShowLocation.Text = getRealLocation(locationNow).ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dp1 = new drawProcess(600, 600, this.BackColor);
            this.CreateGraphics().DrawImage(dp1.drawBackGround(), 400,10);

        }
    }
}

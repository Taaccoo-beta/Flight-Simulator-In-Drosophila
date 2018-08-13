using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;
using Game;
namespace FlightSimulator
{
    public partial class VisionFigure : Form
    {
        public VisionFigure()
        {
            InitializeComponent();
        }

        private int width;
        private int height;

       
        private void VisionFigure_Load(object sender, EventArgs e)
        {
            this.width = this.pbCanvas.Width;
            this.height = this.pbCanvas.Height;
            
        }

        public void SetRandomPoint()
        {
            
        }


       

        private void timer1_Tick(object sender, EventArgs e)
        {
            position+=4;
            
            this.pbCanvas.Invalidate();
        }


        private int VisionIndex = 10;
        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            switch (VisionIndex)
            {
                case 0:
                    DrawGrating(e.Graphics);
                    break;
                case 1:
                    break;
                default:
                    break;
            }

        }


        private int barWidth = 64;
        private int position = 0;
        private void DrawGrating(Graphics g)
        {
            int barNum = width / barWidth;
            int barIndex = 0;

            for (int i = 0; i != width; i++)
            {
                if (i<(barIndex+1)*barNum & barIndex%2==0)
                {
                    g.DrawLine(Pens.Green, (i+position)%width, 0, (i+position)%width, height);
                }
                else if (i < (barIndex + 1) * barNum & barIndex % 2 != 0)
                {
                    g.DrawLine(Pens.Black, (i+position)%width, 0, (i+position)%width, height);
                }
                if (i == (barIndex + 1) * barNum-1)
                {
                    barIndex++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisionIndex = 0;
            this.timer1.Interval = 100;
            this.timer1.Start();
        }
    }
}

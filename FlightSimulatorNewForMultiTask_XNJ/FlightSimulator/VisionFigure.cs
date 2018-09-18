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

        private int windowWidth, windowHeight;
        private void VisionFigure_Load(object sender, EventArgs e)
        {
            this.windowHeight = this.Height;
            this.windowWidth = this.Width;
            barSize18 = this.Width * 18 / 360;
            barSize36 = this.Width * 36 / 360;
            stepSize = (int)(this.Width * 3.6 / 360);
        }

        private bool changeState = true;
        public int expId=0;
        private int barSize18,barSize36;
        public int position=0;
        private int stepSize;
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            switch (expId)
            {
                case 1:
                    drawGratting(dc, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize18, 0);
                    break;
                case 2:
                    position += stepSize;
                    drawGratting(dc, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize36, position);
                    break;
                case 3:
                    position += stepSize;
                    drawGratting(dc, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize36, position);
                    break;
                case 4:
                    position += stepSize;
                    drawGratting(dc, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize36, position);
                    break;
                case 5:
                    position -= stepSize;
                    drawGratting(dc, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize36, position);
                    break;
                case 6:
                    position -= stepSize;
                    drawGratting(dc, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize36, position);
                    break;
                case 7:
                    position -= stepSize;
                    drawGratting(dc, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize36, position);
                    break;
                case 8:
                    position += stepSize;
                    changeState = !changeState;
                    drawRphi(dc, Color.FromArgb(160, Color.Black), Color.FromArgb(60, Color.Black), Color.FromArgb(120, Color.Black), barSize36,position ,changeState);
                    break;
                case 9:
                    position += stepSize;
                    changeState = !changeState;
                    drawRphi(dc, Color.FromArgb(160, Color.Black), Color.FromArgb(60, Color.Black), Color.FromArgb(120, Color.Black), barSize36, position, changeState);
                    break;
                case 10:
                    position += stepSize;
                    changeState = !changeState;
                    drawRphi(dc, Color.FromArgb(160, Color.Black), Color.FromArgb(60, Color.Black), Color.FromArgb(120, Color.Black), barSize36, position, changeState);
                    break;
                case 11:
                    position -= stepSize;
                    changeState = !changeState;
                    drawRphi(dc, Color.FromArgb(160, Color.Black), Color.FromArgb(60, Color.Black), Color.FromArgb(120, Color.Black), barSize36, position, changeState);
                    break;
                case 12:
                    position -= stepSize;
                    changeState = !changeState;
                    drawRphi(dc, Color.FromArgb(160, Color.Black), Color.FromArgb(60, Color.Black), Color.FromArgb(120, Color.Black), barSize36, position, changeState);
                    break;
                case 13:
                    position -= stepSize;
                    changeState = !changeState;
                    drawRphi(dc, Color.FromArgb(160, Color.Black), Color.FromArgb(60, Color.Black), Color.FromArgb(120, Color.Black), barSize36, position, changeState);
                    break;

                default:
                    break;
            }

            
            base.OnPaint(e);
        }

        private void clearWindow(Graphics g)
        {
            g.DrawRectangle(Pens.White, 0, 0, windowWidth, windowHeight);
        }



        private void drawGratting(Graphics g,Color whiteColor,Color blackColor, int barSize,int position)
        {
            for (int i = 0; i != windowWidth; i++)
            {
                if ((i / barSize) % 2 == 0)
                {
                    g.FillRectangle(new SolidBrush(whiteColor), (i+position)%windowWidth, 0, 1, windowHeight);

                }
                else
                {
                    g.FillRectangle(new SolidBrush(blackColor), (i+position)%windowWidth, 0, 1, windowHeight);

                }

            }
        }

        private void drawRphi(Graphics g, Color whiteColor, Color blackColor, Color changeColor, int barSize, int position, bool changeState)
        {

            for (int i = 0; i != windowWidth; i++)
            {
                if ((i / barSize) % 2 == 0)
                {
                    if (changeState)
                    {
                        g.FillRectangle(new SolidBrush(whiteColor), (i + position) % windowWidth, 0, 1, windowHeight);
                    }
                    else
                    {
                        g.FillRectangle(new SolidBrush(changeColor), (i + position) % windowWidth, 0, 1, windowHeight);
                    }
                }
                else
                {
                    g.FillRectangle(new SolidBrush(blackColor), (i + position) % windowWidth, 0, 1, windowHeight);

                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

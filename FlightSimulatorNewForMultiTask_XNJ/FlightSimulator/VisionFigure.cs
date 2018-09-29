﻿using System;
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
        private Graphics g;
        private Bitmap bm;
        private int windowWidth, windowHeight;
        private void VisionFigure_Load(object sender, EventArgs e)
        {

            //simpleOpenGlControl1.InitializeContexts();
            //bool _fullscreen = false;
            //if (_fullscreen)
            //{
            //    FormBorderStyle = FormBorderStyle.None;
            //    WindowState = FormWindowState.Maximized;
            //}
            //Gl.glMatrixMode(Gl.GL_PROJECTION);
            //Gl.glLoadIdentity();
            //Gl.glOrtho(0.0, 1.0, 0.0, 1.0, -1.0, 1.0);

            this.windowHeight = this.Height;
            this.windowWidth = this.Width;
            bm = new Bitmap(windowWidth, windowHeight);
            g = Graphics.FromImage(bm);
            barSize18 = this.Width * 18 / 360;
            barSize36 = this.Width * 36 / 360;
            stepSize = (int)(this.Width * 3.6 / 360);
            degree45 = windowWidth / 2 - windowWidth / 8;
            degreeN45 = windowWidth / 2 + windowWidth / 8;
        }
        private float degree45;
        private float degreeN45;
        private bool changeState = true;
        public int expId=0;
        private int barSize18,barSize36;
        public int position=0;
        private int stepSize;
        private int orien = -1;
        public void drawFigure()
        {
           
            switch (expId)
            {
                case 0:
                   

                    this.CreateGraphics().DrawImage(drawGratting(g, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize18, 0),0,0);
                    break;
                case 1:
                    position += stepSize;
                    this.CreateGraphics().DrawImage(drawGratting(g, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize36, position),0,0);
                    break;
                case 2:
                    position += stepSize;
                    this.CreateGraphics().DrawImage(drawGratting(g, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize36, position),0,0);
                    break;
                case 3:
                    position += stepSize;
                    this.CreateGraphics().DrawImage(drawGratting(g, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize36, position), 0, 0);
                    break;
                case 4:
                    position -= stepSize;
                    this.CreateGraphics().DrawImage(drawGratting(g, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize36, position), 0, 0);
                    break;
                case 5:
                    position -= stepSize;
                    this.CreateGraphics().DrawImage(drawGratting(g, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize36, position), 0, 0);
                    break;
                case 6:
                    position -= stepSize;
                    this.CreateGraphics().DrawImage(drawGratting(g, Color.FromArgb(60, Color.Black), Color.FromArgb(160, Color.Black), barSize36, position), 0, 0);
                    break;
                case 7:
                    position += stepSize;
                    changeState = !changeState;
                    this.CreateGraphics().DrawImage(drawRphi(g, Color.FromArgb(160, Color.Black), Color.FromArgb(60, Color.Black), Color.FromArgb(120, Color.Black), barSize36,position ,changeState), 0, 0);
                    break;
                case 8:
                    position += stepSize;
                    changeState = !changeState;
                    this.CreateGraphics().DrawImage(drawRphi(g, Color.FromArgb(160, Color.Black), Color.FromArgb(60, Color.Black), Color.FromArgb(120, Color.Black), barSize36, position, changeState), 0, 0);
                    break;
                case 9:
                    position += stepSize;
                    changeState = !changeState;
                    this.CreateGraphics().DrawImage(drawRphi(g, Color.FromArgb(160, Color.Black), Color.FromArgb(60, Color.Black), Color.FromArgb(120, Color.Black), barSize36, position, changeState), 0, 0);
                    break;
                case 10:
                    position -= stepSize;
                    changeState = !changeState;
                    this.CreateGraphics().DrawImage(drawRphi(g, Color.FromArgb(160, Color.Black), Color.FromArgb(60, Color.Black), Color.FromArgb(120, Color.Black), barSize36, position, changeState), 0, 0);
                    break;
                case 11:
                    position -= stepSize;
                    changeState = !changeState;
                    this.CreateGraphics().DrawImage(drawRphi(g, Color.FromArgb(160, Color.Black), Color.FromArgb(60, Color.Black), Color.FromArgb(120, Color.Black), barSize36, position, changeState), 0, 0);
                    break;
                case 12:
                    position -= stepSize;
                    changeState = !changeState;
                    this.CreateGraphics().DrawImage(drawRphi(g, Color.FromArgb(160, Color.Black), Color.FromArgb(60, Color.Black), Color.FromArgb(120, Color.Black), barSize36, position, changeState), 0, 0);
                    break;

                default:
                    break;
            }

            
          
        }

        private void clearWindow(Graphics g)
        {
            g.DrawRectangle(Pens.White, 0, 0, windowWidth, windowHeight);
        }



        private Bitmap drawGratting(Graphics g,Color whiteColor,Color blackColor, int barSize,int position)
        {
            g.Clear(Color.White);
            for (int i = 0; i != windowWidth; i++)
            {
                if ((i / barSize) % 2 == 0)
                {
                    g.FillRectangle(new SolidBrush(whiteColor), (i+position)%windowWidth, 0, 1, windowHeight);
                    //g.DrawLine(Pens.Wheat, (i + position) % windowWidth, 0, (i + position) % windowWidth, windowHeight);
                }
                else
                {
                   // g.FillRectangle(new SolidBrush(blackColor), (i+position)%windowWidth, 0, 1, windowHeight);

                }

            }
            return bm;
        }

        private Bitmap drawSingleBar(Graphics g, Color whiteColor,int barSize, int position)
        {
            g.Clear(Color.White);
            
            g.FillRectangle(new SolidBrush(whiteColor),position-barSize/2,0,barSize, windowHeight);
                    //g.DrawLine(Pens.Wheat, (i + position) % windowWidth, 0, (i + position) % windowWidth, windowHeight);
             
            return bm;
        }

        private Bitmap drawRphi(Graphics g, Color whiteColor, Color blackColor, Color changeColor, int barSize, int position, bool changeState)
        {

            g.Clear(Color.White);

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
            return bm;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

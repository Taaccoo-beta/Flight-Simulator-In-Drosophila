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

        private RandomPoint rp;
        private void VisionFigure_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            bool _fullscreen = false;
            if (_fullscreen)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(0.0, 1.0, 0.0, 1.0, -1.0, 1.0);
        }

        public void SetRandomPoint()
        {
            rp = new RandomPoint(this.pbCanvas.Width, this.pbCanvas.Height);
            rp.setBarSize(8);
            rp.setPointSize(12);
        }


        public Bitmap getImage(float degree)
        {
            Bitmap b = (Bitmap)rp.getBitmap(degree).Clone();
            return b;
        }

        
        
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

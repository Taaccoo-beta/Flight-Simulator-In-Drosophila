using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;

namespace BaseSimulatioinDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private Graphics g;
        private DrawObject Do1;
        private DrawObject Do2;
        private DrawObject Do3;
        private DrawObject Do4;
        private DrawObject Do6;
        private DrawObject Do5;


        private DrawPoint dp1;
        private DrawPoint dp2;
        private DrawPoint dp3;
        private DrawPoint dp4;
        private DrawPoint dp5;
        private DrawPoint dp6;



        private int i = 10;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Do1.draw();
            Do2.draw();
            Do3.draw();
            Do4.draw();
            Do5.draw();
            Do6.draw();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.pictureBox1.CreateGraphics();
            Do1 = new DrawObject(g);

            g = this.pictureBox2.CreateGraphics();
            Do2 = new DrawObject(g);

            g = this.pictureBox3.CreateGraphics();
            Do3 = new DrawObject(g);

            g = this.pictureBox4.CreateGraphics();
            Do4 = new DrawObject(g);

            g = this.pictureBox5.CreateGraphics();
            Do5 = new DrawObject(g);

            g = this.pictureBox6.CreateGraphics();
            Do6 = new DrawObject(g);
            this.timer1.Interval = 1000;
            this.timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            g = this.pictureBox1.CreateGraphics();
            dp1 = new DrawPoint(g);

            g = this.pictureBox2.CreateGraphics();
            dp2 = new DrawPoint(g);

            g = this.pictureBox3.CreateGraphics();
            dp3 = new DrawPoint(g);

            g = this.pictureBox4.CreateGraphics();
            dp4 = new DrawPoint(g);

            g = this.pictureBox5.CreateGraphics();
            dp5 = new DrawPoint(g);

            g = this.pictureBox6.CreateGraphics();
            dp6 = new DrawPoint(g);




            timer2.Interval = 1;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dp1.draw();
            dp2.draw();
            dp3.draw();
            dp4.draw();
            dp5.draw();
            dp6.draw();
        }
    }
}

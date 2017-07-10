using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            
        }

        private Graphics g;

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.pictureBox1.CreateGraphics();
            float widthCenter = this.pictureBox1.Width / 2;
            float heightCenter = this.pictureBox1.Height / 2;
            //g.Clear(Color.MediumPurple);
            
            
            //draw drosophila
            g.DrawLine(Pens.Green, widthCenter, heightCenter - 10, widthCenter, heightCenter + 10);
            g.DrawLine(Pens.Green, widthCenter, heightCenter - 10, widthCenter - 5, heightCenter - 5);
            g.DrawLine(Pens.Green, widthCenter, heightCenter - 10, widthCenter + 5, heightCenter - 5);


            //draw aera
            Rectangle rect = new Rectangle((int)(widthCenter - 50), (int)(heightCenter - 50), 100, 100);
            
            //g.DrawRectangle(Pens.Blue,rect);
            //g.DrawArc(Pens.Yellow, rect, 0,100);

            
            g.FillPie(new SolidBrush(Color.FromArgb(254,67,101)), rect, 225, 90);
            g.FillPie(new SolidBrush(Color.FromArgb(131, 175, 155)), rect, 315, 90);
            g.FillPie(new SolidBrush(Color.FromArgb(254, 67, 101)), rect, 45, 90);
            g.FillPie(new SolidBrush(Color.FromArgb(131, 175, 155)), rect, 135,90);





            //g.TranslateTransform(100,110);
            //g.Clear(this.BackColor);
            //g.RotateTransform(30);
            //g.TranslateTransform(-100,-110);

            //g.DrawLine(Pens.Red, 100, 100, 100, 120);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gs = pictureBox1.CreateGraphics();
            string strFile = @"E:\github\flight-simulator-in-drosophila\rorationSimulation\rorationSimulation\bin\Debug\1.jpg";
            Image img = Image.FromFile(strFile);
            
            gs.DrawImage(img, pictureBox1.ClientRectangle);

        }
    }
}

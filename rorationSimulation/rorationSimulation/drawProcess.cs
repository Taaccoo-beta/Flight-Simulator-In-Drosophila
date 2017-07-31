using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rorationSimulation
{
    class drawProcess
    {

        private Graphics g1;
        private Graphics g2;
        private Graphics g3;
        private float widthCenter, heightCenter;
        
        private int width, height;
        private Color bc;
        Bitmap image1;




        public drawProcess(int width, int height, Color bc)
        {
            this.widthCenter = width / 2;
            this.heightCenter = height / 2;
            this.width = width;
            this.height = height;
            

            image1 = new Bitmap(width, height);
            g1 = Graphics.FromImage(image1);
            //使绘图质量最高，即消除锯齿  
            g1.SmoothingMode = SmoothingMode.AntiAlias;
            g1.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g1.CompositingQuality = CompositingQuality.HighQuality;
            g1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;


            g2 = Graphics.FromImage(image1);
            //使绘图质量最高，即消除锯齿  
            g2.SmoothingMode = SmoothingMode.AntiAlias;
            g2.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g2.CompositingQuality = CompositingQuality.HighQuality;
            g2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;


            
        }

        public Bitmap drawBackGround()
        {

            g1.Clear(bc);
            g2.Clear(bc);

            int y = 90;
            // draw background
            Rectangle rect = new Rectangle(0,0, width, height);
            g1.FillRectangle(new SolidBrush(Color.Black), rect);


            // draw axis
            g1.DrawRectangle(Pens.Blue, new Rectangle(60,60,width-120,608));


            for(int i = 0; i != 100; i++)
            {
                g1.DrawLine(Pens.DarkBlue, 60, 60+i*10, 80, 60+i*10);
                
            }
            //width 630 间隔 18， 35一道杠，从0加到256



            return image1;
        }
    }
}

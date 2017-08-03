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

        public bool isPosition=true;
        public bool isTorque=true;


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

        public Bitmap drawBackGround(List<float> lpf1,List<float> lpf2)
        {

            g1.Clear(bc);
            g2.Clear(bc);

            int y = 90;
            // draw background
            Rectangle rect = new Rectangle(0,0, width, height);
            g1.FillRectangle(new SolidBrush(Color.Black), rect);


            // draw axis
            g1.DrawRectangle(Pens.Blue, new Rectangle(60,60,width-100,height-110));

            int intervale = (height - 100) / 18;
            for(int i = 1; i < 18; i++)
            {
                g1.DrawLine(Pens.DarkBlue, 60, 60+intervale*i, 80, 60+intervale*i);
                g1.DrawString((256 * (i - 1)).ToString(), new Font("Arial", 12), new SolidBrush(Color.Blue), 10, 50 + intervale * i);
            }
            //width 630 间隔 18， 35一道杠，从0加到256
            g1.DrawString("Yellow(Position)   Green(Torque)", new Font("Arial", 12), new SolidBrush(Color.Green), 180, 10);

            g1.DrawString(isPosition.ToString(), new Font("Arial", 12), new SolidBrush(Color.Green), 0, 10);

            if (isPosition)
            {
                for (int i = 0; i < lpf1.Count - 1; i++)
                {
                    g1.DrawLine(Pens.Yellow, 80 + i, lpf1[i] * intervale / 256 + 60 + intervale, 80 + i + 1, lpf1[i + 1] * intervale / 256 + 60 + intervale);
                }

            }

            if (isTorque)
            {
                for (int i = 0; i < lpf2.Count - 1; i++)
                {
                    g1.DrawLine(Pens.Green, 80 + i, lpf2[i] * intervale / 256 + 60 + intervale, 80 + i + 1, lpf2[i + 1] * intervale / 256 + 60 + intervale);
                }

            }

            return image1;
        }
    }
}

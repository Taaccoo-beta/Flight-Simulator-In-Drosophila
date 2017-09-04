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
        Bitmap image1,image2;

        public bool isPosition=true;
        public bool isTorque=true;

        //position number record
        int[] positionNumberRecord;
        int pnrLength;


        
        public drawProcess(int width, int height, Color bc)
        {
            this.widthCenter = width / 2;
            this.heightCenter = height / 2;
            this.width = width;
            this.height = height;

            pnrLength = (int)(width / 2 - 20)-1;
            positionNumberRecord = new int[pnrLength];

            ///test positionNumber
            //for (int i = 0; i < pnrLength; i++)
            //{
            //    positionNumberRecord[i] = 10;
            //}


            

            image1 = new Bitmap(width, height);
            g1 = Graphics.FromImage(image1);
            //使绘图质量最高，即消除锯齿  
            g1.SmoothingMode = SmoothingMode.AntiAlias;
            g1.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g1.CompositingQuality = CompositingQuality.HighQuality;
            g1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;



            //使绘图质量最高，即消除锯齿  
            image2 = new Bitmap(width, height);
            g2 = Graphics.FromImage(image2);
            g2.SmoothingMode = SmoothingMode.AntiAlias;
            g2.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g2.CompositingQuality = CompositingQuality.HighQuality;
            g2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;


            
        }


        //positionTransform
        private void positionTransform(float number)
        {

            float intervalHere = 4096 / (float)pnrLength;
           
            float trasNumber = number / intervalHere;
            
            positionNumberRecord[(int)(trasNumber)]++;
           
        }


        public Bitmap drawPosition(float torque)
        {
            g2.Clear(bc);
            int widthHere = width;
            int heightHere = height - 100;
            Rectangle rect = new Rectangle(0, 0, widthHere, heightHere);
            g2.FillRectangle(new SolidBrush(Color.DarkCyan), rect);

            //draw two borders
            g2.DrawRectangle(Pens.MidnightBlue, new Rectangle(10,5, widthHere/2-20, heightHere - 30));
            g2.DrawRectangle(Pens.MidnightBlue, new Rectangle(widthHere / 2 + 5, 5, widthHere/2-20, heightHere - 30));

            //draw axis
            Pen dashPen = new Pen(Color.DarkBlue);
            dashPen.DashStyle = DashStyle.DashDot;
            for (int i = 1; i < 4; i++)
            {
                g2.DrawLine(dashPen, (widthHere / 2 - 20) / 4 * i + 10, heightHere - 25, (widthHere / 2 - 20) / 4 * i + 10, 5);

                g2.DrawLine(dashPen, (widthHere / 2 - 20) / 4 * i + width / 2 + 10, heightHere - 25, (widthHere / 2 - 20) / 4 * i + width / 2 + 10, 5);

            }

            for (int i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                {
                    g2.DrawString("P", new Font("Arial", 12), new SolidBrush(Color.Black), 40 + (widthHere / 2 - 20) / 4 * i, heightHere - 20);
                    g2.DrawString("P", new Font("Arial", 12), new SolidBrush(Color.Black), widthHere/2+50 + (widthHere / 2 - 20) / 4 * i, heightHere - 20);

                }
                else
                {
                    g2.DrawString("N", new Font("Arial", 12), new SolidBrush(Color.Black), 40 + (widthHere / 2 - 20) / 4 * i, heightHere - 20);
                    g2.DrawString("N", new Font("Arial", 12), new SolidBrush(Color.Black), widthHere / 2 + 50 + (widthHere / 2 - 20) / 4 * i, heightHere - 20);
                }
                
            }

            positionTransform(torque);
            //draw commulative position points
            int positionDrawHeightLimit = (int)(heightHere - 30)-2;

            for (int i = 0; i < pnrLength; i++)
            {
                if (positionNumberRecord[i] > positionDrawHeightLimit)
                {
                    g2.DrawLine(Pens.Red, 11 + i, heightHere - 26, 11 + i, heightHere - 26 - positionDrawHeightLimit);
                }
                else
                {
                    g2.DrawLine(Pens.Red, 11 + i, heightHere - 26, 11 + i, heightHere - 26 - positionNumberRecord[i]);
                }
                
            }



            return image2;

        }

        public Bitmap drawSignalCurve(List<float> lpf1,List<float> lpf2)
        {

            g1.Clear(bc);
           
            int y = 90;
            // draw background
            Rectangle rect = new Rectangle(0,0, width, height);
            g1.FillRectangle(new SolidBrush(Color.DarkCyan), rect);


            //draw axis
            g1.DrawRectangle(Pens.MidnightBlue, new Rectangle(60, 60, width - 100, height - 110));

            int intervale = (height - 100) / 18;
            for (int i = 1; i < 18; i++)
            {
                g1.DrawLine(Pens.DarkBlue, 60, 60 + intervale * i, 80, 60 + intervale * i);
                g1.DrawString((256 * (i - 1)).ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), 10, 50 + intervale * i);
            }
            //width 630 间隔 18， 35一道杠，从0加到256
            g1.DrawString("Yellow(Position)   Green(Torque)", new Font("Arial", 14), new SolidBrush(Color.White), 180, 10);

            //g1.DrawString(isPosition.ToString(), new Font("Arial", 12), new SolidBrush(Color.Green), 0, 10);

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
                    g1.DrawLine(Pens.Red, 80 + i, lpf2[i] * intervale / 256 + 60 + intervale, 80 + i + 1, lpf2[i + 1] * intervale / 256 + 60 + intervale);
                }

            }

            return image1;
        }
    }
}

//============================================================================

//                                                                            

//           Author:  Pengbo-Hu

//      Last Change:  10-7-2017   

//          License:  MIT

//           GitHub:  Taaccoo-beta 

//             Mail:  Taaccoo2.0@outlook.com  
            
//      

//============================================================================
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rorationSimulation
{
    class DrawCircle
    {
        private Graphics g1;
        private Graphics g2;
        private Graphics g3;
        private float widthCenter, heightCenter;
        private Color bc;
        Bitmap image1;
       
       
   
        public DrawCircle(int width,int height,int locationWidth,int locationHeight,Color bc)
        {
            
            this.widthCenter = width/2;
            this.heightCenter = height/2;
            this.bc = bc;

            image1 = new Bitmap(width,height);
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

           
            g3 = Graphics.FromImage(image1);
            //使绘图质量最高，即消除锯齿  
            g3.SmoothingMode = SmoothingMode.AntiAlias;
            g3.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g3.CompositingQuality = CompositingQuality.HighQuality;
            g3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;


        }

        public Bitmap drawAera()
        {
            g1.Clear(bc);
            g2.Clear(bc);
            g3.Clear(bc);



            
            Rectangle rect = new Rectangle((int)(widthCenter - 150), (int)(heightCenter - 150), 300, 300);
            g1.FillPie(new SolidBrush(Color.CadetBlue), rect, 225, 90);
            g1.FillPie(new SolidBrush(Color.FromArgb(131, 175, 155)), rect, 315, 90);
            g1.FillPie(new SolidBrush(Color.CadetBlue), rect, 45, 90);
            g1.FillPie(new SolidBrush(Color.FromArgb(131, 175, 155)), rect, 135, 90);
            g1.DrawString("Aera A0", new Font("Arial", 16), new SolidBrush(Color.DarkOrange), widthCenter - 30, heightCenter - 100);


            
            
            g2.TranslateTransform(widthCenter, heightCenter);
            g2.RotateTransform(180);
            g2.TranslateTransform(-widthCenter, -heightCenter);
            g2.DrawString("Aera A1", new Font("Arial", 16), new SolidBrush(Color.DarkOrange), widthCenter - 30, heightCenter - 100);


            g3.DrawLine(Pens.Cyan, widthCenter, heightCenter - 20, widthCenter, heightCenter + 20);
            g3.DrawLine(Pens.Cyan, widthCenter, heightCenter - 20, widthCenter - 5, heightCenter - 5);
            g3.DrawLine(Pens.Cyan, widthCenter, heightCenter - 20, widthCenter + 5, heightCenter - 5);

            return image1;

        }

        /// <summary>
        /// don't use
        /// </summary>
        private void drawAfterRotation()
        {
            g1.Clear(bc);
            g2.Clear(bc);
            g3.Clear(bc);

            Rectangle rect = new Rectangle((int)(widthCenter - 150), (int)(heightCenter - 150), 300, 300);
            g1.FillPie(new SolidBrush(Color.CadetBlue), rect, 225, 90);
            g1.FillPie(new SolidBrush(Color.FromArgb(131, 175, 155)), rect, 315, 90);
            g1.FillPie(new SolidBrush(Color.CadetBlue), rect, 45, 90);
            g1.FillPie(new SolidBrush(Color.FromArgb(131, 175, 155)), rect, 135, 90);
            g1.DrawString("Aera A0", new Font("Arial", 16), new SolidBrush(Color.DarkOrange), widthCenter - 30, heightCenter - 100);

            g2.DrawString("Aera A1", new Font("Arial", 16), new SolidBrush(Color.DarkOrange), widthCenter - 30, heightCenter - 100);


            g3.DrawLine(Pens.Cyan, widthCenter, heightCenter - 20, widthCenter, heightCenter + 20);
            g3.DrawLine(Pens.Cyan, widthCenter, heightCenter - 20, widthCenter - 5, heightCenter - 5);
            g3.DrawLine(Pens.Cyan, widthCenter, heightCenter - 20, widthCenter + 5, heightCenter - 5);

        }
        public Bitmap rotationLeftAera(float angle)
        {
            g1.TranslateTransform(widthCenter, heightCenter);
            g1.RotateTransform(angle);
            g1.TranslateTransform(-widthCenter, -heightCenter);

            g2.TranslateTransform(widthCenter, heightCenter);
            g2.RotateTransform(angle);
            g2.TranslateTransform(-widthCenter, -heightCenter);

            drawAfterRotation();
            return image1;
            
        }

        public Bitmap rotationRightAera(float angle)
        {
            g1.TranslateTransform(widthCenter, heightCenter);
            g1.RotateTransform(-angle);
            g1.TranslateTransform(-widthCenter, -heightCenter);

            g2.TranslateTransform(widthCenter, heightCenter);
            g2.RotateTransform(-angle);
            g2.TranslateTransform(-widthCenter, -heightCenter);

            drawAfterRotation();
            return image1;

        }
    }
}

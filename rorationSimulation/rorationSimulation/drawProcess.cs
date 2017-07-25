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


            // draw background
            Rectangle rect = new Rectangle(0,0, width, height);
            g1.FillRectangle(new SolidBrush(Color.FromArgb(153, 204, 255)), rect);


            // draw axis
            g1.DrawRectangle(Pens.Yellow, new Rectangle(60,10,width-120,height-120));



            

            return image1;
        }
    }
}

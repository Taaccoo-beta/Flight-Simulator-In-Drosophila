using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class Stimulations
    {
        private Graphics g1;
        private Graphics g2;
        private float widthCenter, heightCenter;

        private int width, height;
        private Color bc;
        Bitmap image1, image2;
        private ushort stiNumber;
        public bool isPosition = true;
        public bool isTorque = true;

        private float blockWidth;
        private float blockHeight;


        public Stimulations(int width,int height,ushort stiNumber)
        {
            
            image1 = new Bitmap(width, height);
            g1 = Graphics.FromImage(image1);
            //使绘图质量最高，即消除锯齿  
            g1.SmoothingMode = SmoothingMode.AntiAlias;
            g1.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g1.CompositingQuality = CompositingQuality.HighQuality;
            g1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.width = width;
            this.height = height;
            this.stiNumber = stiNumber;

            blockWidth = 100f;
            blockHeight = 40f;
        }

        public void setWH(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public float DegreeToValue(float degree)
        {
            return width / 2f + width / 360f * degree;

        }


        public Bitmap DrawV_Test(float degree)
        {
            g1.Clear(Color.White);

            float position = DegreeToValue(degree);
            float x1 = position - blockWidth / 2f;
            float y1 = 1 / 3.0f * height- blockHeight / 2f;
            float x2 = x1 + width / 4f;
            float y2 = 2 / 3.0f * height - blockHeight / 2f;
            float x3 = x2 +  width / 4f;
            float y3 = y1;
            float x4 = x3 + width / 4f;
            float y4 = y2;

            Color c = Color.Black;

            if (x1 + blockWidth > width)
            {

                if (x1 > width)
                {
                    g1.FillRectangle(new SolidBrush(c), new RectangleF(x1 - width, y1, blockWidth, blockHeight));
                }
                else
                {
                    g1.FillRectangle(new SolidBrush(c), new RectangleF(x1, y1, width - x1, blockHeight));
                    g1.FillRectangle(new SolidBrush(c), new RectangleF(0, y1, blockWidth - width + x1, blockHeight));
                }
            }
            else if (0 > x1)
            {
                g1.FillRectangle(new SolidBrush(c), new RectangleF(x1, y1, blockWidth, blockHeight));
                g1.FillRectangle(new SolidBrush(c), new RectangleF(width+x1, y1, - x1, blockHeight));

            }
            else
            {
                g1.FillRectangle(new SolidBrush(c), new RectangleF(x1, y1, blockWidth, blockHeight));
            }

            if (x2 + blockWidth > width)
            {

                if (x2 > width)
                {
                    g1.FillRectangle(new SolidBrush(c), new RectangleF(x2 - width, y2, blockWidth, blockHeight));
                }
                else
                {
                    g1.FillRectangle(new SolidBrush(c), new RectangleF(x2, y2, width - x2, blockHeight));
                    g1.FillRectangle(new SolidBrush(c), new RectangleF(0, y2, blockWidth - width + x2, blockHeight));
                }
            }
            else
            {
                g1.FillRectangle(new SolidBrush(c), new RectangleF(x2, y2, blockWidth, blockHeight));
            }

            if (x3 + blockWidth > width)
            {

                if (x3 > width)
                {
                    g1.FillRectangle(new SolidBrush(c), new RectangleF(x3 - width, y3, blockWidth, blockHeight));
                }
                else
                {
                    g1.FillRectangle(new SolidBrush(c), new RectangleF(x3, y3, width - x3, blockHeight));
                    g1.FillRectangle(new SolidBrush(c), new RectangleF(0, y3, blockWidth - width + x3, blockHeight));
                }
            }
            else
            {
                g1.FillRectangle(new SolidBrush(c), new RectangleF(x3, y3, blockWidth, blockHeight));
            }

            if (x4 + blockWidth > width)
            {

                if (x4 > width)
                {
                    g1.FillRectangle(new SolidBrush(c), new RectangleF(x4 - width, y4, blockWidth, blockHeight));
                }
                else
                {
                    g1.FillRectangle(new SolidBrush(c), new RectangleF(x4, y4, width - x4, blockHeight));
                    g1.FillRectangle(new SolidBrush(c), new RectangleF(0, y4, blockWidth - width + x4, blockHeight));
                }
            }
            else
            {
                g1.FillRectangle(new SolidBrush(c), new RectangleF(x4, y4, blockWidth, blockHeight));
            }
            //RectangleF rect1 = new RectangleF(x1,y1, blockWidth, blockHeight);
            //g1.FillRectangle(new SolidBrush(Color.DarkCyan), rect1);

            //RectangleF rect2 = new RectangleF(x2, y2, blockWidth, blockHeight);
            //g1.FillRectangle(new SolidBrush(Color.DarkCyan), rect2);

            //RectangleF rect3 = new RectangleF(x3, y3, blockWidth, blockHeight);
            //g1.FillRectangle(new SolidBrush(Color.DarkCyan), rect3);

            //RectangleF rect4 = new RectangleF(x4, y4, blockWidth, blockHeight);
            //g1.FillRectangle(new SolidBrush(Color.DarkCyan), rect4);


            return image1;

        }



        public void MovingStrip()
        {
            Matrix m = new Matrix();
        }




    }
}

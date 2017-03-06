using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace BaseSimulatioinDemo
{
    class DrawPoint
    {
        private int getRandom()
        {
            Random ran = new Random();
            return  ran.Next(10, 180);
        }

        private Graphics g;
        private bool[,] isFilled = new bool[200,200];


        private Point getPoint(int x)
        {
            for(int i = 199;i>=0;i--)
            {
                if(isFilled[x,i]==false)
                {
                    return new Point(x, i);
                }

            }

            return new Point(x, 0);
        }

        public void draw()
        {
            Pen pB = new Pen(Color.Black);
            Brush bB = pB.Brush;

            int x = getRandom();
            Point p = getPoint(x);
            isFilled[p.X, p.Y] = true;
            
            g.FillEllipse(Brushes.Black, p.X,p.Y,10,10);
        }

        public DrawPoint(Graphics g)
        {
            this.g = g;
            for(int i = 0; i!=200;i++)
            {
                for(int j = 0;j!=200;j++)
                {
                    isFilled[i, j] = false;
                }
            }

        }


    }
}

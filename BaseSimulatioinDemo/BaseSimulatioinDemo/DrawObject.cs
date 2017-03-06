using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace BaseSimulatioinDemo
{
    class DrawObject
    {
        private Graphics g;
        private int x = 100;
        private int y = 100;
        private int longRadius = 80;
        private int shortRadius = 60;

        public DrawObject(Graphics g)
        {
            this.g = g;
        }
        
        public void draw()
        {
            Pen pB = new Pen(Color.Black);
            Brush bB = pB.Brush;
        
            Pen pW = new Pen(Color.White);
            Brush bW = pW.Brush;
            g.FillEllipse(bB, x-longRadius,x-longRadius, 2*longRadius, 2 * longRadius);
            g.FillEllipse(bW, x - shortRadius, x - shortRadius, 2 * shortRadius, 2 * shortRadius);

        }
    }

    
}

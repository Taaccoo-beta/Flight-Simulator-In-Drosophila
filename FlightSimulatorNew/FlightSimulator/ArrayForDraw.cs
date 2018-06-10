using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ww
{
    class ArrayForDraw
    {
        
        
        private int width, height;
        private List<int> columnBackGround;
        private List<int> columnBar;
        

        public ArrayForDraw(int width, int height)
        {
           
            this.width = width;
            this.height = height;
            columnBar = new List<int>();
            columnBackGround = new List<int>();
        }


        public void ChangeCol(int col)
        {
            if (col >= width || col < 0)
            {
                Console.WriteLine("Wrong column");
            }

        }

        public void GiveValueForRandow(int barWidth)
        {
            Random rd = new Random();
            int width = rd.Next(0, 2);
            for (int i = 0; i != width; i++)
            {
                columnBackGround.Add(rd.Next(0, 2));

            }
            for (int i = 0; i != barWidth; i++)
            {
                columnBar.Add(rd.Next(0, 2));
            }
            
        }






    }
}

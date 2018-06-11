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
        private int[,] Painting;
      
        private int seed;

        public ArrayForDraw(int width, int height,int seed)
        {
           
            this.width = width;
            this.height = height;
            this.seed = seed;
            Painting = new int[height, width];
            
           
        }

        //private int DegreeToPosition(int degree)
        //{

            
        //    return (int)(width / 2f + width / 360f * degree);

            
        //}
        //private int tempStart;
        //private int tempEnd;
        //private int degree = 0;
        //public void MoveRight()
        //{
        //    int start = DegreeToPosition(-100);
        //    int end = DegreeToPosition(100);
            
        //    degree++;
        //    if (degree > end)
        //    {
        //        degree = 0;
        //    }
            
        //    for (int i = 0; i != height; i++)
        //    {
        //        for (int j = 0 ; j != barWidth; j++)
        //        {

        //            Painting[i, j + start + degree] = 0;
                   
        //        }
        //    }
            

           

        //}

        public int[,] GiveValueForRandow()
        {
            Random rd = new Random(seed);
            
            for (int i = 0; i != height; i++)
            {
                for (int j = 0; j != width; j++)
                {
                    int value = rd.Next(0,100);
                    if (value < 40)
                    {
                        Painting[i, j] = 1;
                        
                    }
                    else
                    {
                        Painting[i, j] = 0;
                        
                    }
                }
                

            }

            return Painting;
            
        }






    }
}

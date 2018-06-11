using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ww
{
    class ArrayForDraw
    {
        
        
        private int width, height,barWidth;
        public int[,] Painting;
        public int[,] bar;
        public int[,] tempPainting;
        

        public ArrayForDraw(int width, int height)
        {
           
            this.width = width;
            this.height = height;
            this.barWidth = 30/360*width;
            Painting = new int[height, width];
            tempPainting = new int[height, width];
            bar = new int[height, 30];
            GiveValueForRandow();
        }

        private int DegreeToPosition(int degree)
        {

            
            return (int)(width / 2f + width / 360f * degree);

            
        }
        private int tempStart;
        private int tempEnd;

        public void MoveRightForDegree(int degree)
        {
            int position = DegreeToPosition(degree);
            int start = position - 15;
            int end = position + 15;
            
            for (int i = 0; i != height; i++)
            {
                for (int j = tempStart; j != tempEnd; j++)
                {
                    Painting[i, j] = tempPainting[i, j];
                }
            }
            
            for (int i = 0; i != height; i++)
            {
                for (int j = start; j != end; j++)
                {
                    Painting[i, j % (width - 1)] = bar[i, j-start];
                    
                   
                }
            }
            tempStart = start;
            tempEnd = end;

            //position = DegreeToPosition(degree + 180);


            //for (int i = 0; i != height; i++)
            //{
            //    for (int j = start; j != position; j++)
            //    {
            //        Painting[i, j % width] = bar[i, j % width];
            //    }
            //}

        }

        private void GiveValueForRandow()
        {
            Random rd = new Random(1);
            
            for (int i = 0; i != height; i++)
            {
                for (int j = 0; j != width; j++)
                {
                    int value = rd.Next(0,100);
                    if (value < 40)
                    {
                        Painting[i, j] = 1;
                        tempPainting[i, j] = 1;
                    }
                    else
                    {
                        Painting[i, j] = 0;
                        tempPainting[i, j] = 1;
                    }
                }
                

            }
            tempPainting = Painting;

            Random rdBar = new Random(2);
            for (int i = 0; i != height; i++)
            {
                for(int j = 0; j!=30;j++)
                {
                    int value = rdBar.Next(0, 100);
                    if (value < 40)
                    {
                        bar[i, j] = 1;
                    }
                    else
                    {
                        bar[i, j] = 0;
                    }

                }
            }
            
            
        }






    }
}

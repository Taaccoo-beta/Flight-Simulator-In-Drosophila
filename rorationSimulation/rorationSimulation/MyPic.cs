using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rorationSimulation
{
    class MyPic : System.Windows.Forms.PictureBox
    {
        public  MyPic()
        {
            this.DoubleBuffered = true;
            setStyles();
        }
        private void setStyles()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer | System.Windows.Forms.ControlStyles.ResizeRedraw | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }
    }
}

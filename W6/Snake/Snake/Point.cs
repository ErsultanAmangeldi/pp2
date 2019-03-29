using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    public class Point
    {  
        public Point()
        {
                
        }
        public int x;
        public int y;
        public int Filter(int v)
        {
            if (v < 0) v = 39;
            else if (v >= 40) v = 0;
            return v;
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = Filter(value);
            }

        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y =Filter(value)                                                                                                                                                                                               ;
            }

        }
        public override string ToString()
        {
            return string.Format("({0},{1})",x,y);
        }


    }
}

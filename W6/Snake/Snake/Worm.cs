using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    public class Worm:GameObject
    {   
        public Worm():base()
        {

        }
        public Worm(char sign) : base(sign)
        {
            body.Add(new Point { X = 20, Y = 20 });
            Dx = Dy = 0;
        }
        public int Dx
        {
            get;
            set;
        }
        public int Dy
        {
            get;
            set;
        }
        public void Move()
        {
            Clear();
            for(int i = body.Count - 1; i>0;i--)
            {
                body[i].X = body[i - 1].X;
                body[i].y = body[i - 1].Y;
            }
            body[0].X += Dx;
            body[0].Y += Dy;
        }

        public bool CheckIntersection(List<Point> otherBody)
        {
            bool res = false;
             foreach(Point point in otherBody)
              {
                  if(point.X== body[0].X &&
                     point.Y == body[0].Y)
                 {
                     res = true;
                 }
                 if (res == true)
                 {
                     break;
                 }
                    
            }
            return res;
        }

        public void Eat(List<Point> foodbody)
        {
            body.Add(new Point { X = foodbody[0].X, Y = foodbody[0].Y });
        }
    }



}

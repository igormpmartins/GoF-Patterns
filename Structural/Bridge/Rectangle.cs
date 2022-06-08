using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Rectangle : Shape
    {

        public Rectangle(DrawApi implementor): base(implementor)
        {

        }

        public override void Draw()
        {
            implementor.DrawLine(0,     0,  100,    0);
            implementor.DrawLine(100,   0,  100,    50);
            implementor.DrawLine(100,   50, 0,      50);
            implementor.DrawLine(0,     50, 0,      0);
        }
    }
}

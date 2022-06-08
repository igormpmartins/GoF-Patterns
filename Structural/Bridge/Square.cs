using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Square : Shape
    {

        public Square(DrawApi implementor): base(implementor)
        {

        }

        public override void Draw()
        {
            implementor.DrawLine(0,     0,      100,    0);
            implementor.DrawLine(100,   0,      100,    100);
            implementor.DrawLine(100,   100,    0,      100);
            implementor.DrawLine(0,     100,    0,      0);
        }
    }
}

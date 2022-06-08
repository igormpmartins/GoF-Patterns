using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Line : Shape
    {
        public Line(DrawApi implementor): base(implementor)
        {

        }

        public override void Draw()
        {
            implementor.DrawLine(0, 0, 100, 100);
        }
    }
}

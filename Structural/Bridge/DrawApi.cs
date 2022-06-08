using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class DrawApi
    {
        public abstract void DrawLine(int x1, int y1, int x2, int y2);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class OpenGLApi : DrawApi
    {
        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine(@$"glBegin(GL_LINES)");
            Console.WriteLine(@$"glVertex2i({x1},{y1})");
            Console.WriteLine(@$"glVertex2i({x2},{y2})");
            Console.WriteLine(@$"glEnd()");
        }
    }
}

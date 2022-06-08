using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SvgApi : DrawApi
    {
        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine($@"<line x1 = ""{x1}"" y1=""{y1}"" x2=""{x2}"" y2=""{y2}"" />");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Image : BaseImage
    {
        protected string fileName;

        public Image(string fileName)
        {
            this.fileName = fileName;
        }

        public override void Display(int x, int y, int width, int height)
        {
            Console.WriteLine($@"<img src=""{fileName}"" style=""left:{x}px; top:{y}px; width:{width}; height:{height}px;""/>");
        }
    }
}

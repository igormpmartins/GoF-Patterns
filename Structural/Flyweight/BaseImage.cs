using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public abstract class BaseImage
    {
        public abstract void Display(int x, int y, int width, int height);
    }
}

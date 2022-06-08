using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Toy
    {
        public abstract int GetPowerQuantity();
        public abstract TimeSpan GetHeatingTime();
        public abstract Color GetColor();
    }
}

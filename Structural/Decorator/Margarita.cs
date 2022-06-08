using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Margarita : PizzaElement
    {
        public override decimal GetPrice() => 8m;
    }
}

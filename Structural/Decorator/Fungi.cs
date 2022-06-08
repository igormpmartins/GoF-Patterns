using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Fungi : PizzaElement
    {
        public override decimal GetPrice() => 7m;
    }
}

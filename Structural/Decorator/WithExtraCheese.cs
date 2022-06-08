using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class WithExtraCheese : PizzaTopping
    {

        public WithExtraCheese(PizzaElement component):base(component)
        {

        }

        public override decimal GetPrice() => base.GetPrice() + 0.5m;
    }
}

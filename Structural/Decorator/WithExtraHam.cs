using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class WithExtraHam : PizzaTopping
    {
        public WithExtraHam(PizzaElement component): base(component)
        {

        }

        public override decimal GetPrice() => base.GetPrice() + 1m;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class PizzaTopping : PizzaElement
    {
        protected PizzaElement component;

        protected PizzaTopping(PizzaElement component)
        {
            this.component = component;
        }

        public override decimal GetPrice() => component.GetPrice();
    }
}

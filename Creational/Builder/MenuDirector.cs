using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MenuDirector
    {
        public void Construct(MenuBuilder builder)
        {
            builder.BuildBurgerOrSalad();
            builder.BuildFries();
            builder.BuildDessert();
            builder.BuildDrink();
            builder.BuildToy();
        }
    }
}

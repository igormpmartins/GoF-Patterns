using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BurgerMenuBuilder : MenuBuilder
    {
        private Menu menu = new Menu();

        public override void BuildBurgerOrSalad()
        {
            menu.Add("Burger");
        }

        public override void BuildDessert()
        {
            menu.Add("Desert");
        }

        public override void BuildDrink()
        {
            menu.Add("Drink");
        }

        public override void BuildFries()
        {
            menu.Add("Fries");
        }

        public override void BuildToy()
        {
            //no toy
        }

        public override Menu GetResult()
        {
            return menu;
        }
    }
}

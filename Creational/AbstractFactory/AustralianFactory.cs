using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AustralianFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Dingo();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Kangaroo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Ecosystem
    {

        private Herbivore herbivore;
        private Carnivore carnivore;

        public Ecosystem(ContinentFactory continentFactory)
        {
            herbivore = continentFactory.CreateHerbivore();
            carnivore = continentFactory.CreateCarnivore();
        }

        public void Run()
        {
            carnivore.Eat(herbivore);
        }

    }
}

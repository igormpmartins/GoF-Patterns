using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class ToyCreator
    {
        protected abstract Toy CreateToy();

        public void MakeToy()
        {
            Toy toy = CreateToy();
            int grams = toy.GetPowerQuantity();
            PreparePowder(grams);
            SelectMold(toy);
            InjectPowder(grams);

            TimeSpan heatingTime = toy.GetHeatingTime();
            HeatMold(heatingTime);
            ExtractToy();

            Color color = toy.GetColor();
            PaintToy(color);

        }

        private void PaintToy(Color color)
        {
            Console.WriteLine($"Painting...{color.Name}");
        }

        private void ExtractToy()
        {
            Console.WriteLine("Extracting toy");
        }

        private void HeatMold(TimeSpan heatingTime)
        {
            Console.WriteLine($"Heating mold...{heatingTime.ToString()}");
        }

        private void InjectPowder(int grams)
        {
            Console.WriteLine($"Injecting powder...{grams}");
        }

        private void SelectMold(Toy toy)
        {
            Console.WriteLine($"Selecting mold for {toy.GetType().Name}");
        }

        private void PreparePowder(int grams)
        {
            Console.WriteLine($"Preparing powder...{grams}");
        }
    }
}

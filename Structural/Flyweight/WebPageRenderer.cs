using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class WebPageRenderer
    {
        public void Render()
        {
            var factory = new ImageFactory();

            var image = factory.GetFlyweight("image.png");
            image.Display(0, 0, 400, 250);

            image = factory.GetFlyweight("image.png");
            image.Display(60, 420, 200, 90);
            
            image = factory.GetFlyweight("image.png");
            image.Display(65, 925, 75, 75);
        }
    }
}

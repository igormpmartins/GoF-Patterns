using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class ImageFactory
    {
        private Dictionary<string, BaseImage> flyweights = new Dictionary<string, BaseImage>();

        public BaseImage GetFlyweight(string filename)
        {
            BaseImage flyweight = null;
            Console.WriteLine();

            if (flyweights.ContainsKey(filename))
            {
                flyweight = flyweights[filename] as BaseImage;
                Console.WriteLine($"Returning cached image {filename}");
            } else
            {
                flyweight = new Image(filename);
                flyweights.Add(filename, flyweight);
                Console.WriteLine($"Instantiating new image {filename}");
            }
            return flyweight;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class CourseImage: Cloneable
    {
        public Bitmap Bitmap { get; set; }

        public void Initialize()
        {
            Bitmap = (Bitmap) Image.FromFile("laptop.png");
        }

        public override Cloneable Clone()
        {
            CourseImage clone = (CourseImage) this.MemberwiseClone();
            clone.Bitmap = (Bitmap) Bitmap.Clone();
            return clone as Cloneable;
        }

        public void Save(string filePath)
        {
            Console.WriteLine($"Writing {filePath}");
            Bitmap.Save(filePath);
        }

    }
}

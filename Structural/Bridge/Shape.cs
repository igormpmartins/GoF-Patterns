using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Shape
    {
        protected DrawApi implementor;

        public Shape(DrawApi implementor)
        {
            this.implementor = implementor;
        }

        public abstract void Draw();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class Visitor
    {
        public abstract void Visit(Book product);
        public abstract void Visit(Movie product);
        public abstract void Visit(Toy product);
        public abstract void Visit(Clothing product);

    }
}

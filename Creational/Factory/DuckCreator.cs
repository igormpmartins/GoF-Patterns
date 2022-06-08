using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class DuckCreator : ToyCreator
    {
        protected override Toy CreateToy() => new Duck();
    }
}

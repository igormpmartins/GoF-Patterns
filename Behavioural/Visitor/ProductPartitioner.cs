using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ProductPartitioner : Visitor
    {
        protected int books = 0;
        protected int movies = 0;
        protected int toys = 0;
        protected int clothing = 0;

        public int Books { get => books; }
        public int Movies { get => movies; }
        public int Toys { get => toys; }
        public int Clothing { get => clothing; }


        public override void Visit(Book product)
        {
            books++;
        }

        public override void Visit(Movie product)
        {
            movies++;
        }

        public override void Visit(Toy product)
        {
            toys++;
        }

        public override void Visit(Clothing product)
        {
            clothing++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Book : Product
    {
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

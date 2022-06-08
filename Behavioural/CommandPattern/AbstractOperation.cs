using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class AbstractOperation
    {
        public abstract void Execute();
        public abstract AbstractOperation Inverse { get; }  
    }
}

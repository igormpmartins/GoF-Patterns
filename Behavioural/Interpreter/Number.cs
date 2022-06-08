using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Number : RpnExpression
    {
        private readonly int value = 0;

        public Number(int value)
        {
            this.value = value;
        }

        public override int Interpret()
        {
            return value;
        }
    }
}

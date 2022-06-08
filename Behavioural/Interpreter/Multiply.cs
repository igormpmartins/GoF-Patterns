using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Multiply : RpnExpression
    {
        private readonly RpnExpression lhs = null;
        private readonly RpnExpression rhs = null;

        public Multiply(RpnExpression lhs, RpnExpression rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public override int Interpret()
        {
            return lhs.Interpret() * rhs.Interpret();
        }
    }
}

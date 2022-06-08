using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Add : RpnExpression
    {
        private readonly RpnExpression lhs = null;
        private readonly RpnExpression rhs = null;

        public Add(RpnExpression lhs, RpnExpression rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public override int Interpret()
        {
            return lhs.Interpret() + rhs.Interpret();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Operation : AbstractOperation
    {

        protected MathLib _mathlib = null;
        protected string _operation = null;
        protected int _argument = 0;

        public Operation(MathLib mathLib, string operation, int argument)
        {
            _mathlib = mathLib;
            _operation = operation;
            _argument = argument;
        }

        public override AbstractOperation Inverse
        {
            get
            {
                switch (_operation)
                {
                    case "+":
                        return new Operation(_mathlib, "-", _argument);
                    case "-":
                        return new Operation(_mathlib, "+", _argument);
                    case "*":
                        return new Operation(_mathlib, "/", _argument);
                    case "/":
                        return new Operation(_mathlib, "*", _argument);
                    default:
                        throw new InvalidOperationException("Invalid math operation");
                }
            }

        }

        public override void Execute()
        {
            switch (_operation)
            {
                case "+":
                    _mathlib.Add(_argument);
                    break;
                case "-":
                    _mathlib.Subtract(_argument);
                    break;
                case "*":
                    _mathlib.Multiply(_argument);
                    break;
                case "/":
                    _mathlib.Divide(_argument);
                    break;
                default:
                    throw new InvalidOperationException("Invalid math operation!");  
            }
        }
    }
}

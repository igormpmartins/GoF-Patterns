using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class MathLib
    {
        protected int _value = 0;
        public int Value { get => _value; }

        public void Add(int argument) => _value += argument;
        public void Subtract(int argument) => _value -= argument;
        public void Multiply(int argument) => _value *= argument;
        public void Divide(int argument) => _value /= argument;

    }
}

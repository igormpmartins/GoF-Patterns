using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Visitor: AbstractVisitor
    {
        public Visitor(string name)
        {
            this._name = name;  
        }

        public override void Receive(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_name} <-- {message}");
        }
    }
}

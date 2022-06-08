using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatt
{
    public class SoldOut: State
    {
        public override void InsertCoin(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The machine is sold out, call IT");
        }

        public override void EjectCoin(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The machine is sold out, call IT");
        }

        public override void PushButton(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The machine is sold out, call IT");
        }

        public override void DispenseChocolate(VendingMachine context)
        {
            //push already notifies!
        }
    }
}

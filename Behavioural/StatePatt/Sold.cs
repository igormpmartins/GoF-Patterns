using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatt
{
    public class Sold: State
    {
        public override void InsertCoin(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cannot insert coin while machine is dispensing!");
        }

        public override void EjectCoin(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cannot eject coin while machine is dispensing!");
        }

        public override void PushButton(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cannot push button while machine is dispensing!");
        }

        public override void DispenseChocolate(VendingMachine context)
        {
            context.Products--;
            if (context.Products >= 0)
                context.State = new NoCoin();
            else
                context.State = new SoldOut();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pick your M&M!");
        }

    }
}

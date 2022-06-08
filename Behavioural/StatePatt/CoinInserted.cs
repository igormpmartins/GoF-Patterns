using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatt
{
    public class CoinInserted: State
    {
        public override void InsertCoin(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You cannot insert another coin!");
        }

        public override void EjectCoin(VendingMachine context)
        {
            context.State = new NoCoin();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Coin ejected!");
        }

        public override void PushButton(VendingMachine context)
        {
            context.State = new Sold();
        }

        public override void DispenseChocolate(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Select your M&M!");
        }

    }
}

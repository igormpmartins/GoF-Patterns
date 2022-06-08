using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatt
{
    public class NoCoin : State
    {

        public override void InsertCoin(VendingMachine context)
        {
            if (context.Products > 0)
            {
                context.State = new CoinInserted();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Coin accepted");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sold out :(");
            }
        }

        public override void EjectCoin(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cannot eject, no coin inserted!");
        }



        public override void PushButton(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pushing will do nothing, no coin inserted!");
        }

        public override void DispenseChocolate(VendingMachine context)
        {
            //push já vai dar o acerta!
        }

    }
}

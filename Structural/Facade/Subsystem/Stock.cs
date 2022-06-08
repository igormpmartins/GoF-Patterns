using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystem
{
    public class Stock : Equity
    {
        public Stock(string tickerSymbol): base(tickerSymbol)
        {

        }

        public override void Buy(decimal shares)
        {
            //yep :) 
        }

        public override decimal GetPrice() => 10;

        public override void Sell(decimal shares)
        {
            throw new NotImplementedException();
        }
    }
}

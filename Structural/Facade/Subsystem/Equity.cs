using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystem
{
    public abstract class Equity
    {
        private string tickerSymbol = null;

        public Equity(string tickerSymbol)
        {
            this.tickerSymbol = tickerSymbol;
        }

        public abstract void Buy(decimal shares);
        public abstract void Sell(decimal shares);
        public abstract decimal GetPrice();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystem
{
    public class EquityFactory
    {

        private EquityFactory() { }

        private static EquityFactory instance;
        public static EquityFactory GetInstance() => instance ?? (instance = new EquityFactory());
        public Equity CreateEquity(string tickerSymbol) => new Stock(tickerSymbol);

    }
}

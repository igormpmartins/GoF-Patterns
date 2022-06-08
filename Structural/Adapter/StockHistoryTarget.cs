using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public abstract class StockHistoryTarget
    {
        public abstract DataTable GetStockPrices(string ticker);
    }
}

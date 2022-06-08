using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class StockApp
    {
        public void ShowStockHistory(string ticker)
        {
            StockHistoryTarget adapter = new StockHistoryAdapter();

            DataTable history = adapter.GetStockPrices(ticker);

            foreach (DataRow row in history.Rows)
            {
                DateTime dt = (DateTime) row[0];
                decimal price = (decimal) row[1];
                Console.WriteLine($"On {dt.ToString("MMM d yyyy")} {ticker} was {price.ToString("0.00")}");
            }

        }
    }
}

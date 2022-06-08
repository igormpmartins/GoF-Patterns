using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class StockHistoryAdapter : StockHistoryTarget
    {
        private StockHistoryDb adaptee = new StockHistoryDb();
        public override DataTable GetStockPrices(string ticker)
        {
            decimal[] history = new decimal[] {};
            switch (ticker)
            {
                case "AAPL":
                    history = adaptee.GetAAPL();
                    break;
                case "MSFT":
                    history = adaptee.GetMSFT();
                    break;
                case "GOOG":
                    history = adaptee.GetGOOG();
                    break;
                default:
                    throw new NotImplementedException();
            }

            DataTable results = new DataTable();
            results.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            results.Columns.Add(new DataColumn("Price", typeof(decimal)));

            DateTime dt = new DateTime(2015, 11, 7);

            for (int i = 0; i < 12; i++)
            {
                DataRow row = results.NewRow();
                row[0] = dt;
                row[1] = history[i];
                results.Rows.Add(row);
                dt = dt.AddMonths(-1);
            }

            return results;

        }
    }
}

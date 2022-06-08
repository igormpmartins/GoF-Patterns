using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class StockHistoryDb
    {
        public decimal[] GetAAPL()
        {
            return new decimal[] { 121.05m, 111.5m, 112.76m, 216.51m, 121.05m, 111.5m, 112.76m, 216.51m, 121.05m, 111.5m, 112.76m, 216.51m};
        }
        public decimal[] GetMSFT()
        {
            return new decimal[] { 321.05m, 411.5m, 512.76m, 216.51m, 121.05m, 111.5m, 112.76m, 216.51m, 121.05m, 111.5m, 112.76m, 216.51m};
        }
        public decimal[] GetGOOG()
        {
            return new decimal[] { 621.05m, 711.5m, 812.76m, 216.51m, 121.05m, 111.5m, 112.76m, 216.51m, 121.05m, 111.5m, 112.76m, 216.51m};
        }

    }
}

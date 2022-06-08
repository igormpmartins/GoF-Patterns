using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public abstract class CoinApi
    {
        public abstract decimal GetValueInUSD();
    }
}

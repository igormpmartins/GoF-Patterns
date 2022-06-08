using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class WithRateLimit : CoinApi
    {

        private CoinApi realSubject;
        DateTime lastCalled = DateTime.MinValue;

        public WithRateLimit(CoinApi realSubject)
        {
            this.realSubject = realSubject;
        }

        public override decimal GetValueInUSD()
        {
            if (DateTime.Now - lastCalled < TimeSpan.FromSeconds(1))
                throw new InvalidOperationException("Rate limit exceeded");

            var value = realSubject.GetValueInUSD();
            lastCalled = DateTime.Now;
            return value;
        }
    }
}

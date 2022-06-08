using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class BadClient
    {
        public void Execute()
        {
            var service =
                new WithRateLimit(new BitcoinApi());

            for (int i = 0; i < 21; i++)
            {
                try
                {
                    Console.WriteLine(service.GetValueInUSD());
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Thread.Sleep(100);
            }
        }
    }
}

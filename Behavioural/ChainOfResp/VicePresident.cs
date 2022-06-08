using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class VicePresident: POApprover
    {
        public VicePresident(POApprover sucessor)
        {
            _sucessor = sucessor;
        }

        public override void ProcessRequest(decimal price)
        {
            if (price < 25000)
            {
                Console.WriteLine($"{price} purchase approved by {this.GetType().Name}");
            }
            else if (_sucessor != null)
            {
                _sucessor.ProcessRequest(price);
            }
        }

    }
}

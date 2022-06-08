using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class CEO : POApprover
    {
        public CEO(POApprover sucessor)
        {
            _sucessor = sucessor;
        }

        public override void ProcessRequest(decimal price)
        {
            if (price < 100000)
            {
                Console.WriteLine($"{price} purchase approved by {this.GetType().Name}");
            }
            else
            {
                Console.WriteLine($"Plan executive meeting, etc. {price}");
            }
        }

    }

}

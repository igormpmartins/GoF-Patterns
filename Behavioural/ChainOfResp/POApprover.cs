using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public abstract class POApprover
    {
        protected POApprover _sucessor;
        public abstract void ProcessRequest(decimal price);
    }
}

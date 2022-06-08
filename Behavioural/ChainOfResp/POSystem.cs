using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class POSystem
    {
        protected POApprover approvalChain = null;

        public POSystem()
        {
            approvalChain = 
                new Manager(
                    new VicePresident(
                        new CEO(null)
                    )
                );
        }

        public void ProcessRequest(decimal price) => approvalChain.ProcessRequest(price);


    }
}

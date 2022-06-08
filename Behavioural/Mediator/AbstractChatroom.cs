using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class AbstractChatroom
    {
        protected List<AbstractVisitor> _activeVisitors = new List<AbstractVisitor>();

        public abstract void Send(string message, AbstractVisitor sender);

        public abstract void Register(AbstractVisitor visitor);

        public abstract void Unregister(AbstractVisitor visitor);

    }
}

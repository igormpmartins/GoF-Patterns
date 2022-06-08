using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Calculator
    {
        protected Stack<AbstractOperation> undoStack = new Stack<AbstractOperation>();

        public void Invoke(AbstractOperation operation)
        {
            operation.Execute();
            undoStack.Push(operation);
        }

        public void Undo()
        {
            var operation = undoStack.Pop();
            operation.Inverse.Execute();
        }

    }
}

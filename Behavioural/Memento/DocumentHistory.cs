using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class DocumentHistory
    {

        private List<object> _history = new List<object> { };

        private Document _document = null;

        public DocumentHistory(Document document)
        {
            _document = document;
        }

        public void Snapshot()
        {
            var memento = _document.SaveState();
            _history.Add(memento);
        }

        public void Restore(int index)
        {
            var memento = _history[index];
            _document.LoadState(memento);
        }

    }
}

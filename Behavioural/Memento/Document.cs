using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public  class Document
    {

        private sealed class DocumentState
        {
            private string _state;

            public DocumentState(string state)
            {
                _state = state;
            }

            public string State { get { return _state; } }

        }

        private string _html;

        public void Append(string text)
        {
            _html += text;
        }

        public void Italic()
        {
            _html = "<i>" + _html + "</i>";
        }        
        
        public void Bold()
        {
            _html = "<b>" + _html + "</b>";
        }        
        
        public void Underline()
        {
            _html = "<u>" + _html + "</u>";
        }

        public object SaveState()
        {
            return (new Document.DocumentState(_html));
        }

        public void LoadState(object docstate)
        {
            _html = (docstate as DocumentState).State;
        }

        public override string ToString() => _html;

    }
}

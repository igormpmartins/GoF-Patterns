using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Text : LeafNode
    {
        protected string text = null;

        public Text(string text)
        {
            this.text = text;
        }

        public override string Render() => text;

    }
}

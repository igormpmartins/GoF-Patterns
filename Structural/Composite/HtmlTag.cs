using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class HtmlTag: HtmlNode
    {
        protected string tagName = null;
        protected List<HtmlNode> elements= new List<HtmlNode>();

        protected HtmlTag(string tagName)
        {
            this.tagName = tagName;
        }

        public void AddChild(HtmlNode component) => elements.Add(component);

        public override string Render()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<{tagName}>");

            foreach (HtmlNode child in elements)
                sb.Append(child.Render());

            sb.Append($"</{tagName}>");
            return sb.ToString();
        }
    }
}

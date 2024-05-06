using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class LightElementNode : LightNode
    {
        public List<LightNode> children;

        public LightElementNode(string tagName, List<LightNode> children)
        {
            TagName = tagName;
            this.children = children;
        }
        public string TagName { get; }
        public List<LightNode> Children { get { return children; } }
        public override string InnerHtml
        {
            get
            {
                StringBuilder builder = new StringBuilder();

                foreach (var child in children)
                {
                    builder.Append(child.OuterHtml);
                }

                return builder.ToString();
            }
        }
        public override string OuterHtml
        {
            get
            {
                return $"<{TagName}>{InnerHtml}</{TagName}>";
            }
        }
        public void AddChild(LightNode child)
        {
            children.Add(child);
        }
    }
}

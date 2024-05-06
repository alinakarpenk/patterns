using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class LightElementNode : LightNode
    {
        public string _tag;
        public List<LightNode> _children;
        public List<string> _cssClasses;
        public LightElementNode(string tag, List<LightNode> children = null, List<string> cssClasses = null)
        {
            _tag = tag;
            _children = children ?? new List<LightNode>();
            _cssClasses = cssClasses ?? new List<string>();
        }
       public override string OuterHtml => $"<{_tag}{GetClassAttribute()}{(_children.Count == 0 ? "/>" : $">{InnerHtml}</{_tag}>")}";
        public override string InnerHtml => string.Join("", _children.Select(child => child.OuterHtml));

        private string GetClassAttribute()
        {
            return _cssClasses.Count > 0 ? $" class=\"{string.Join(" ", _cssClasses)}\"" : "";
        }
    }

}

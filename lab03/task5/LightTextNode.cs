using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class LightTextNode : LightNode
    {
        public string _text;
        public LightTextNode(string text)
        {
            _text = text;
        }
        public override string OuterHtml => "<p>" + _text + "</p>";
        public override string InnerHtml => _text;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
        public static class LightHtmlExtensions
        {
            public static LightElementNode Ul(this LightElementNode parent, params LightNode[] items)
            {
                var ul = new LightElementNode("ul", items.ToList());
                parent?.AddChild(ul);
                return ul;
            }

            public static LightElementNode Li(this LightElementNode parent, string text)
            {
                var li = new LightElementNode("li", new List<LightNode> { new LightTextNode(text) });
                parent?.AddChild(li);
                return li;
            }

            public static LightElementNode On(this LightElementNode element, string eventType, Action listener)
            {
                element.AddEventListener(eventType, listener);
                return element;
            }

            private static void AddChild(this LightElementNode parent, LightElementNode child)
            {
                parent?.AddChild(child);
            }
        }
    }



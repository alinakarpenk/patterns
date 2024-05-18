using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class LightElementNode : LightNode
    {
        public List<LightNode> children;
        public Dictionary<string, Action> eventListeners;

        public LightElementNode(string tagName, List<LightNode> children)
        {
            TagName = tagName;
            this.children = children;
            eventListeners = new Dictionary<string, Action>();
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

        public void AddEventListener(string eventType, Action listener)
        {
            if (eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType] += listener;
            }
            else
            {
                eventListeners[eventType] = listener;
            }
        }

        public void RemoveEventListener(string eventType, Action listener)
        {
            if (eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType] -= listener;
            }
        }

        public void TriggerEvent(string eventType)
        {
            if (eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType]?.Invoke();
            }
        }
    }
}


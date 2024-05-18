using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LightElementNode document = new LightElementNode("div", new List<LightNode>());
            LightElementNode header = new LightElementNode("h1", new List<LightNode> { new LightTextNode("Hello World") });
            header.On("click", () => Console.WriteLine("Header clicked!"));
            LightElementNode paragraph = new LightElementNode("p", new List<LightNode> { new LightTextNode("This is a paragraph.") });
            paragraph.On("mouseover", () => Console.WriteLine("Paragraph mouseover!"));
            document.AddChild(header);
            document.AddChild(paragraph);
            Console.WriteLine(document.OuterHtml);
            header.TriggerEvent("click");
            paragraph.TriggerEvent("mouseover");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LightElementNode ul = new LightElementNode("div")
            .Ul(
                new LightElementNode("li").Li("Hello World"),
                new LightElementNode("li").Li("Hello"),
                new LightElementNode("li").Li("World")
            );
            //Console.WriteLine(ul.OuterHtml);
            Console.WriteLine(ul.InnerHtml);
            Console.ReadKey();    
        }
    }
}

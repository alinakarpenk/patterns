using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using task5;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookText = File.ReadAllText("testbookhtml.txt");
            string htmlContent = HtmlConverter.ConvertToHtml(bookText);
            Console.WriteLine("HTML верстка книги:");
            Console.WriteLine(htmlContent);
            List<LightNode> nodes = HtmlConverter.ConvertHtmlToLightNodes(htmlContent);
            int treeSize = HtmlConverter.GetTreeSize(nodes);
            Console.WriteLine($"Розмір дерева: {treeSize} елементів.");
            Console.ReadKey();
        }
    }
}


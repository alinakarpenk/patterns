using System;
using System.Collections.Generic;
using task5;

namespace task6
{
    public class HtmlConverter
    {
        public static string ConvertToHtml(string bookText)
        {
            string[] lines = bookText.Split('\n');
            List<LightNode> nodes = new List<LightNode>();
            nodes.Add(new LightElementNode("h1", new List<LightNode> { new LightTextNode(lines[0]) }));
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                if (line.Length < 20)
                {
                    var textNode = new LightTextNode(line);
                    nodes.Add(new LightElementNode("h2", new List<LightNode> { textNode }));
                }
                else if (line.StartsWith(" "))
                {
                    var textNode = new LightTextNode(line);
                    nodes.Add(new LightElementNode("blockquote", new List<LightNode> { textNode }));
                }
                else
                {
                    nodes.Add(new LightTextNode(line));
                }
            }

            return nodes.ToString();
        }
        public static int GetTreeSize(List<LightNode> nodes)
        {
            int size = 0;
            foreach (var node in nodes)
            {
                size++;
                if (node is LightElementNode)
                {
                    size += GetTreeSize(((LightElementNode)node).Children);
                }
            }
            return size;
        }
        public static List<LightNode> ConvertHtmlToLightNodes(string htmlContent)
        {
            List<LightNode> nodes = new List<LightNode>();
            nodes.Add(new LightTextNode(htmlContent));
            return nodes;
        }
    }
}

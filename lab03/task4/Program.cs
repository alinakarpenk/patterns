using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Text.txt";
            var checker = new SmartTextChecker(filePath);
            var text = checker.ReadTextFile();
            if (text != null)
            {
                foreach (var line in text)
                {
                    Console.WriteLine(string.Join("", line));
                }
            }
            string restrictedPattern = @"D:\\Private\\.*";
            var locker = new SmartTextReaderLocker(filePath, restrictedPattern);
            var restrictedText = locker.ReadTextFile();
            if (restrictedText != null)
            {
                foreach (var line in restrictedText)
                {
                    Console.WriteLine(string.Join("", line));
                }
            }
            Console.ReadKey();
        }
    }
}

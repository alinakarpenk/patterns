using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class SmartTextChecker : SmartTextReader
    {
        public SmartTextChecker(string filePath) : base(filePath) { }

        public new string[][] ReadTextFile()
        {
            Console.WriteLine($"Opening file: {filePath}");
            var result = base.ReadTextFile();
            if (result != null)
            {
                Console.WriteLine($"Read {result.Length} lines and {result.Sum(arr => arr.Length)} characters.");
            }
            Console.WriteLine($"Closing file: {filePath}");
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task4
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private readonly Regex restrictedFilePattern;
        public SmartTextReaderLocker(string filePath, string restrictedFilePattern) : base(filePath)
        {
            this.restrictedFilePattern = new Regex(restrictedFilePattern);
        }
        public new string[][] ReadTextFile()
        {
            if (restrictedFilePattern.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            return base.ReadTextFile();
        }
    }
}

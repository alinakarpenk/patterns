using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace task4
{
    public class SmartTextReader
    {
        public string filePath;

        public SmartTextReader(string filePath)
        {
            this.filePath = filePath;
        }
        public string[][] ReadTextFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                string[][] result = new string[lines.Length][];

                for (int i = 0; i < lines.Length; i++)
                {
                    result[i] = lines[i].ToCharArray().Select(c => c.ToString()).ToArray();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return null;
            }
        }
    }
}


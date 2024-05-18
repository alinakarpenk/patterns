using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    public class FileSysLoad : IImageLoad
    {
        public void Load(string href)
        {
            if (File.Exists(href))
            {
                Console.WriteLine($"Loading image from file system: {href}");
                byte[] imageBytes = File.ReadAllBytes(href);
                Console.WriteLine($"Image loaded: {href}");            }
            else
            {
                Console.WriteLine($"Image not found in file system: {href}");
            }
        }
    }
}
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Enclosure
    {
        public string Type { get; set; }
        public int Size { get; set; }
        public Enclosure(string type, int size)
        {
            Type = type;
            Size = size;
        }
    }
}

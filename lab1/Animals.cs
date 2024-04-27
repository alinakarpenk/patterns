using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Animals
    {
        public string Species { get; set; }
        public string Subspecies { get; set; }
        public int Age { get; set; }

        public Animals(string species, string subspecies, int age)
        {
            Species = species;
            Subspecies = subspecies;
            Age = age;
        }
    }
}

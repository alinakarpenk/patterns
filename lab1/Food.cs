using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Food
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public Food(string name, string type, double price)
        {
            Name = name;
            Type = type;
            Price = price;
        }
        public void Eat()
        {
            Console.WriteLine($"The animals are eating {Name}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public Employee(string name, int age, string department)
        {
            Name = name;
            Age = age;
            Department = department;
        }
        public void FeedAnimals(List<Animals> animals, Food food)
        {
            Console.WriteLine($"{Name} is feeding the animals with {food.Name}.");
            foreach (var animal in animals)
            {
                Console.WriteLine($"Feeding {animal.Species}");
            }
        }
    }
}

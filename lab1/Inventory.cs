using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Inventory
    {
        public void AnimalInventory(List<Animals> animals)
        {
            Console.WriteLine("Animal Inventory:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"Species: {animal.Species}, Subspecies: {animal.Subspecies}, Age: {animal.Age}");
            }
        }

        public void EmployeeCount(List<Employee> zookeepers)
        {
            Console.WriteLine($"Number of Zookeepers: {zookeepers.Count}");
        }
    }
}

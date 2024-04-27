using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals lion = new Animals("Lion", "African Lion", 5);
            Animals camel = new Animals("Camel", "Two-humpled camel", 3);
            Animals elephant = new Animals("Elephant", "African Elephant", 10);
            var animals = new List<Animals> { lion, camel, elephant };
            Enclosure lionEnclosure = new Enclosure("Savanna", 100);
            Enclosure camelEnclosure = new Enclosure("Asia", 150);
            Enclosure elephantEnclosure = new Enclosure("Savanna", 200);
            Food meat = new Food("Meat", "Protein", 11.00);
            Food grains = new Food("Grain", "Vitamin", 09.00);
            Food fruits = new Food("Fruits", "Vitamin", 10.00);
            Employee employee1 = new Employee("Artem", 23, "Lions Department");
            Employee employee2 = new Employee("Lena", 19, "Camels Department");
            Employee employee3 = new Employee("Ivan", 25, "Elephant Department");
            var employeers = new List<Employee> { employee1, employee2, employee3 };
            Inventory zooInventory = new Inventory();
            zooInventory.AnimalInventory(animals);
            zooInventory.EmployeeCount(employeers);
            employee2.FeedAnimals(new List<Animals> {lion},meat);
            employee1.FeedAnimals(new List<Animals> {elephant}, fruits);
            employee3.FeedAnimals(new List<Animals> {camel}, grains);
            Console.WriteLine($"Lion enclosure: Type {lionEnclosure.Type}, Size {lionEnclosure.Size}");
            Console.WriteLine($"Camel enclosure: Type {camelEnclosure.Type}, Size {camelEnclosure.Size}");
            Console.WriteLine($"Elephant enclosure: Type {elephantEnclosure.Type}, Size {elephantEnclosure.Size}");
              
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Enemy
    {
        public double Height { get; }
        public string Build { get; }
        public string Hair { get; }
        public string Eye { get; }
        public List<string> Inventory { get; }

        public Enemy(double height, string build, string hair, string eye, List<string> inventory)
        {
            Height = height;
            Build = build;
            Hair = hair;
            Eye = eye;
            Inventory = inventory;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Enemy:");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Build: {Build}");
            Console.WriteLine($"Hair Color: {Hair}");
            Console.WriteLine($"Eye Color: {Eye}");
            Console.WriteLine("Inventory:");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}

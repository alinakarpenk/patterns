using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Hero
    {
        public double Height { get; }
        public string Stature { get; }
        public string Hair { get; }
        public string Eye { get; }
        public List<string> Inventory { get; }

        public Hero(double height, string build, string hairColor, string eyeColor,List<string> inventory)
        {
            Height = height;
            Stature = build;
            Hair = hairColor;
            Eye = eyeColor;
            Inventory = inventory;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Hero:");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Build: {Stature}");
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

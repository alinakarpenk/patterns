using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Virus:ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; }
        public Virus(double weight, int age, string name, string type)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = new List<Virus>();
        }
        public Virus()
        {
            Children = new List<Virus>();
        }
        public void AddChild(Virus child)
        {
            Children.Add(child);
        }
        public object Clone()
        {
            Virus clone = new Virus(Weight, Age, Name, Type);
            foreach (var child in Children)
            {
                clone.AddChild((Virus)child.Clone());
            }
            return clone;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Weight: {Weight}, Age: {Age}");
            if (Children.Count > 0)
            {
                Console.WriteLine("Children:");
                foreach (var child in Children)
                {
                    Console.WriteLine($"  - Name: {child.Name}, Type: {child.Type}, Weight: {child.Weight}, Age: {child.Age}");
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Virus grandparent = new Virus(10.5, 5, "Grandparent", "Influenza");
            Virus parent1 = new Virus(8.2, 3, "Parent1", "Coronavirus");
            Virus parent2 = new Virus(9.7, 4, "Parent2", "Ebola");
            Virus child1 = new Virus(7.1, 2, "Child1", "Ebola");
            Virus child2 = new Virus(6.3, 1, "Child2", "Ebola");
            parent1.AddChild(child1);
            parent2.AddChild(child2);
            grandparent.AddChild(parent1);
            grandparent.AddChild(parent2);
            Virus clonedGrandparent = (Virus)grandparent.Clone();

            Console.WriteLine("Cloned Virus:");
            clonedGrandparent.DisplayInfo();

            Console.ReadLine();
        }
    }
}

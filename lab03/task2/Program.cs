using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using task2.Items;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero warrior = new Hero("Warrior");
            while (true)
            {
                Console.WriteLine("Enter item type (Weapon / Armor / Artifact) or exit:");
                string itemType = Console.ReadLine();
                if (itemType.ToLower() == "exit")
                    break;
                Console.WriteLine("Enter item description:");
                string itemDescription = Console.ReadLine();
                IItem newItem = null;
                switch (itemType.ToLower())
                {
                    case "weapon":
                        newItem = new Weapon { Description = itemDescription };
                        break;
                    case "armor":
                        newItem = new Armor { Description = itemDescription };
                        break;
                    case "artifact":
                        newItem = new Artifact { Description = itemDescription };
                        break;
                    default:
                        Console.WriteLine("Invalid item type.");
                        continue;
                }
                warrior.Equip(newItem);
            }
            warrior.ShowInventory();
            Console.ReadKey();
        }
    }
}


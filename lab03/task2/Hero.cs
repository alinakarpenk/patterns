using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Items;

namespace task2
{
    public class Hero
    {
        public string Name { get; set; }
        private readonly List<IItem> _inventory;

        public Hero(string name)
        {
            Name = name;
            _inventory = new List<IItem>();
        }
        public void Equip(IItem item)
        {
            _inventory.Add(item);
        }

        public void ShowInventory()
        {
            Console.WriteLine($"Inventory of {Name}:");
            foreach (var item in _inventory)
            {
                Console.WriteLine($"{item.Description}");
            }
        }

        private string GetItemType(IItem item)
        {
            if (item is Weapon)
            {
                return "Weapon";
            }
            else if (item is Armor)
            {
                return "Armor";
            }
            else if (item is Artifact)
            {
                return "Artifact";
            }
            return item.GetType().Name;
        }

    }

}


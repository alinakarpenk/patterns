using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EnemyBuilder:IBuilder
    {
        private double Height { get; set; }
        private string Stature { get; set; }
        private string Hair { get; set; }
        private string Eye { get; set; }
        private List<string> Inventory { get; set; }

        public EnemyBuilder()
        {
            Inventory = new List<string>();
        }
        public IBuilder SetHeight(double height)
        {
            Height = height;
            return this;
        }
        public IBuilder SetStature(string build)
        {
            Stature = build;
            return this;
        }
        public IBuilder SetHair(string hairColor)
        {
            Hair = hairColor;
            return this;
        }
        public IBuilder SetEye(string eyeColor)
        {
            Eye = eyeColor;
            return this;
        }
        public IBuilder SetInventory(List<string> inventory)
        {
            Inventory = inventory;
            return this;
        }
        public Enemy Build()
        {
            return new Enemy(Height, Stature, Hair, Eye, Inventory);
        }

    }
}

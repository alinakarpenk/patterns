using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Builder
{
    public class HeroBuilder : IBuilder
    {
        private double Height { get; set; }
        private string Stature { get; set; }
        private string Hair { get; set; }
        private string Eye { get; set; }
        private List<string> Inventory { get; set; }

        public HeroBuilder()
        {
            Inventory = new List<string>();
        }

        public IBuilder SetHeight(double height)
        {
            Height = height;
            return this;
        }

        public IBuilder SetStature(string stature)
        {
            Stature = stature;
            return this;
        }

        public IBuilder SetHair(string hair)
        {
            Hair = hair;
            return this;
        }

        public IBuilder SetEye(string eye)
        {
            Eye = eye;
            return this;
        }

        public IBuilder SetInventory(List<string> inventory)
        {
            Inventory = inventory;
            return this;
        }

        // Оновлений метод Build
        public Hero Build()
        {
            return new Hero(Height, Stature, Hair, Eye, Inventory);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Character
    {
        private IBuilder builder;

        public Character(IBuilder builder)
        {
            this.builder = builder;
        }
        public void CreateCharacter(double height, string stature, string hair, string eye, List<string> inventory)
        {
            builder.SetHeight(height);
            builder.SetStature(stature);
            builder.SetHair(hair);
            builder.SetEye(eye);
            builder.SetInventory(inventory);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        IBuilder SetHeight(double height);
        IBuilder SetStature(string build);
        IBuilder SetHair(string hairColor);
        IBuilder SetEye(string eyeColor);
        IBuilder SetInventory(List<string> inventory);
    }
}

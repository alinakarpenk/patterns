using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AFactory.Device;

namespace AFactory.Products
{
    public class Smartphone : AFactory.Device.Device
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"EBook: {Brand} {Model}, Price: {Price}");
        }
    }
}


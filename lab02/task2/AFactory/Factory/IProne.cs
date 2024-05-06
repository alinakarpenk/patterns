using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFactory.Device;
using AFactory.Products;

namespace AFactory.Factory
{
    public class IProne : FactoryDevice
    {
        public decimal Price { get; set; }
        public override AFactory.Device.Device CreateDevice(string model,decimal price)
        {
            if (model == "EBook")
            {
                return new EBook { Brand = "Balaxy", Model = model, Price = price };
            }
            else if (model == "Smartphone")
            {
                return new Smartphone { Brand = "Balaxy", Model = model, Price = price };
            }
            else if (model == "Netbook")
            {
                return new Netbook { Brand = "Balaxy", Model = model, Price = price };
            }
            else
            {
                throw new Exception($"Model '{model}' is not found");
            }
        }
    }
}

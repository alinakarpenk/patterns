using AFactory.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFactory.Factory;
using AFactory.Products;

namespace AFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryDevice balaxy = new Balaxy();
            AFactory.Device.Device device1 = balaxy.CreateDevice("EBook", 1000);
            device1.DisplayInfo();

            FactoryDevice kiaomi = new Kiaomi();
            AFactory.Device.Device device2 = kiaomi.CreateDevice("Smartphone", 200);
            device2.DisplayInfo();

            FactoryDevice iprone = new IProne();
            AFactory.Device.Device device3 = iprone.CreateDevice("Netbook", 15000);
            device3.DisplayInfo();

            Console.ReadKey();
        }
    }
}

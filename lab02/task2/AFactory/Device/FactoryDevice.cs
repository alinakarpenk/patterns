using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory.Device
{
    public abstract class FactoryDevice
    {
        public abstract Device CreateDevice(string model, decimal price);
    }
}

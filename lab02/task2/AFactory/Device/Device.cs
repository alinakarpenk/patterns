using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory.Device
{

        public abstract class Device
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public decimal Price { get; set; }
        public abstract void DisplayInfo();
        }
    
}

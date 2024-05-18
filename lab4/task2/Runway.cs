using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        private Aircraft _currentAircraft;
        public Aircraft CurrentAircraft
        {
            get { return _currentAircraft; }
            private set { _currentAircraft = value; }
        }
        public bool IsFree => _currentAircraft == null;
        public void Occupy(Aircraft aircraft)
        {
            _currentAircraft = aircraft;
            HighLightRed();
        }
        public void Vacate()
        {
            _currentAircraft = null;
            HighLightGreen();
        }
        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }
        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }
    }

}


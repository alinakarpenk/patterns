using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class CommandCentre
    {
        public List<Runway> _runways = new List<Runway>();
        public List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
            foreach (var aircraft in aircrafts)
            {
                aircraft.SetCommandCentre(this);
            }
        }

        public void RequestToLand(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is requesting to land.");
            Runway freeRunway = _runways.Find(r => r.IsFree);

            if (freeRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is landing on runway {freeRunway.Id}.");
                freeRunway.Occupy(aircraft);
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} could not land, no runways are free.");
            }
        }

        public void RequestToTakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is requesting to take off.");
            Runway occupiedRunway = _runways.Find(r => r.CurrentAircraft == aircraft);

            if (occupiedRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {occupiedRunway.Id}.");
                occupiedRunway.Vacate();
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
            }
        }
    }
}

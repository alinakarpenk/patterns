using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Runway[] runways = { new Runway(), new Runway() };
            Aircraft[] aircrafts = { new Aircraft("Airbus A320"), new Aircraft("Boeing 737") };

            CommandCentre commandCentre = new CommandCentre(runways, aircrafts);

            aircrafts[0].RequestToLand(); 
            aircrafts[1].RequestToLand(); 

            aircrafts[0].RequestToTakeOff(); 
            aircrafts[1].RequestToTakeOff(); 
            Console.ReadKey();
        }
    }
}

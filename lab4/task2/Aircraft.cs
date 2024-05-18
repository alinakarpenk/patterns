using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }
        public CommandCentre _commandCentre;

        public Aircraft(string name)
        {
            this.Name = name;
        }

        public void SetCommandCentre(CommandCentre commandCentre)
        {
            _commandCentre = commandCentre;
        }

        public void RequestToLand()
        {
            _commandCentre.RequestToLand(this);
        }

        public void RequestToTakeOff()
        {
            _commandCentre.RequestToTakeOff(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Proxy
{
    internal class AircraftProxy : IAircraft
    {
        private Aircraft realAircraft = new Aircraft();

        public void RequestTakeoff()
        {
            Console.WriteLine("Proxy checks weather conditions.");
            realAircraft.RequestTakeoff();
        }
    }
}

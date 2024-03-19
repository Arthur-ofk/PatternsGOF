using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF.FlightMode
{
    public class EmergencyFlightProgram : IFlightMode
    {
        public void ExecuteFlight()
        {
            Console.WriteLine("WOOOOOOOOOOOOOOOOOOO");
        }

        public Type GetFlightType()
        {
           return typeof(EmergencyFlightProgram);
        }
    }
}

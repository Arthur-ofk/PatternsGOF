using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF.FlightMode
{
    public class NormalFlightProgram : IFlightMode
    {
        public void ExecuteFlight()
        {
            Console.WriteLine("wooooooooooooooo");
        }

        public Type GetFlightType()
        {
           return typeof(NormalFlightProgram);
        }
    }
}

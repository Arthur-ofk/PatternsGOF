using AirportGOF.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF.Factory
{
    public class AircraftFactory
    {
        public Aircraft CreatePassengerAircraft()
        {
            return new Aircraft { Type = "Passenger" };
        }

        public Aircraft CreateCargoAircraft()
        {
            return new Aircraft { Type = "Cargo" };
        }
    }
}

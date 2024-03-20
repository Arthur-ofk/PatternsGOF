using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Visitor
{
    public class AircraftStatusVisitor : IVisitor
    {
        public void VisitAirplane(Airplane airplane)
        {
            Console.WriteLine("Checking airplane status...");
        }

        public void VisitHelicopter(Helicopter helicopter)
        {
            Console.WriteLine("Checking helicopter status...");
        }
    }
}

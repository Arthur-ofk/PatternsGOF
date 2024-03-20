using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Decorator
{
    internal class LuxuryAircraft: AircraftDecorator
    {
        public LuxuryAircraft(IAircraft aircraft) : base(aircraft)
        {
        }

        public override void DisplayFeatures()
        {
            base.DisplayFeatures();
            Console.WriteLine("Luxury features added.");
        }
    }
}

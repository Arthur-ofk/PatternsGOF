using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Facade
{
    internal class AirportFacade
    {
        private readonly Aircraft aircraft;
        private readonly Runway runway;

        public AirportFacade()
        {
            aircraft = new Aircraft();
            runway = new Runway();
        }

        public void PrepareForTakeoff()
        {
            aircraft.CheckFuel();
            runway.CheckClearance();
            aircraft.StartEngine();
            aircraft.TakeOff();
        }
    }
}

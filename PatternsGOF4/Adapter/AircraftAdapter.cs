using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Adapter
{
   public  class AircraftAdapter
    {
        private NewAircraft newAircraft;

        public AircraftAdapter()
        {
            newAircraft = new NewAircraft();
        }

        public void TakeOff()
        {
            newAircraft.LiftOff();
        }
    }
}

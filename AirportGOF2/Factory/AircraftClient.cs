using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF2.Factory
{
    public class AirportClient
    {
        private IAircraftFactory factory;

        public AirportClient(IAircraftFactory factory)
        {
            this.factory = factory;
        }

        public void Run()
        {
            Aircraft aircraft = factory.CreateAircraft();
           

            
        }
    }
}

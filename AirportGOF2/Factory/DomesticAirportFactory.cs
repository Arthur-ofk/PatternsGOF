﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF2.Factory
{
    public class DomesticAirportFactory : IAircraftFactory
    {
        public Aircraft CreateAircraft()
        {
            return new Helicopter();
        }

       
    }
}

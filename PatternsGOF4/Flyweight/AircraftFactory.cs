using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Flyweight
{
    internal class AircraftFactory
    {
        private Dictionary<string, Aircraft> aircrafts = new Dictionary<string, Aircraft>();

        public Aircraft GetSharedAircraft(string type)
        {
            if (!aircrafts.ContainsKey(type))
            {
                aircrafts[type] = new Aircraft(type);
            }
            return aircrafts[type];
        }
    }
}

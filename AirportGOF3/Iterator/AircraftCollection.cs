using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Iterator
{
    public class AircraftCollection :ICustomIterator<string>
    {
        private string[] aircrafts;
        private int index;

        public AircraftCollection()
        {
            aircrafts = new string[] { "Airplane", "Helicopter", "Drone" };
            index = 0;
        }

        public bool HasNext()
        {
            return index < aircrafts.Length;
        }

        public string Next()
        {
            if (HasNext())
            {
                return aircrafts[index++];
            }
            return null;
        }
    }
}

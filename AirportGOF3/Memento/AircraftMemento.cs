using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Memento
{
    public class AircraftMemento
    {
        public string State { get; private set; }

        public AircraftMemento(string state)
        {
            State = state;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Memento
{
    public class Aircraft
    {
        private string state;

        public void SetState(string state)
        {
            this.state = state;
        }

        public AircraftMemento SaveState()
        {
            return new AircraftMemento(state);
        }

        public void RestoreState(AircraftMemento memento)
        {
            state = memento.State;
        }
        public string GetState()
        {
            return state;
        }
    }
}

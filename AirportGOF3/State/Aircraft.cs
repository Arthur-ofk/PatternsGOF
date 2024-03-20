using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.State
{
    public class Aircraft
    {
        private IState state;

        public Aircraft()
        {
            state = new GroundedState();
        }

        public void SetState(IState newState)
        {
            state = newState;
        }

        public void PerformAction()
        {
            state.HandleState();
        }
    }
}

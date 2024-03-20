using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.State
{
    internal class FlyingState : IState
    {
        public void HandleState(Aircraft context)
        {
            Console.WriteLine("Aircraft is flying.");
            context.SetState(new GroundedState());
        }
    }
}

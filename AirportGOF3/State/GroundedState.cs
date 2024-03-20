using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.State
{
    public class GroundedState : IState
    {
        public void HandleState(Aircraft context)
        {
            Console.WriteLine("Aircraft is grounded.");
            context.SetState(new FlyingState());
        }
    }
}

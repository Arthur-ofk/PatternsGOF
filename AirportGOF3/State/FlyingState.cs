using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.State
{
    internal class FlyingState : IState
    {
        public void HandleState()
        {
            Console.WriteLine("Aircraft is flying.");
        }
    }
}

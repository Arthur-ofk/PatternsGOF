using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Proxy
{
    internal class Aircraft : IAircraft
    {
        public void RequestTakeoff()
        {
            Console.WriteLine("Aircraft is requesting takeoff clearance.");
        }
    }
}

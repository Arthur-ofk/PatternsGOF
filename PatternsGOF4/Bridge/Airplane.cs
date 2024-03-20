using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Bridge
{
    internal class Airplane : IAircraft
    {
        public void Land(IRunway runway)
        {
            Console.Write("Airplane is ");
            runway.LandOn();
        }
    }
}

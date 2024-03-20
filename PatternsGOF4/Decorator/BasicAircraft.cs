using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Decorator
{
    internal class BasicAircraft : IAircraft
    {
        public void DisplayFeatures()
        {
            Console.WriteLine("Basic aircraft features.");
        }
    }
}

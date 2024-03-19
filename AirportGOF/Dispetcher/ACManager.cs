using AirportGOF.Dispetcher.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF.Dispetcher
{
    public class ACManager : IObserver
    {
        public void Update()
        {
            Console.WriteLine( "flight mode changed");
        }
    }
}

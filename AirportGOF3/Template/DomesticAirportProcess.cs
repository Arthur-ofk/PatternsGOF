using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Template
{
    public class DomesticAirportProcess : AirportProcess
    {
        protected override void OpenAirport()
        {
            Console.WriteLine("Domestic airport is opening.");
        }

        protected override void PerformChecks()
        {
            Console.WriteLine("Performing security and safety checks.");
        }

        protected override void CloseAirport()
        {
            Console.WriteLine("Domestic airport is closing.");
        }
    }
}

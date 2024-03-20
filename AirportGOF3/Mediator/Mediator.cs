using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Mediator
{
    public class Mediator : IMediator
    {
        public void SendMessage(string message, Aircraft aircraft)
        {
            Console.WriteLine($"Message from control tower: {message} for {aircraft.GetType().Name}");
        }
    }
}

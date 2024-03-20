using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Mediator
{
    public interface IMediator
    {
        void SendMessage(string message, Aircraft aircraft);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Mediator
{
    public class Plane :Aircraft
    {
        public Plane(IMediator mediator) : base(mediator)
        {
        }

        public override void Send(string message)
        {
            mediator.SendMessage(message, this);
        }
    }
}

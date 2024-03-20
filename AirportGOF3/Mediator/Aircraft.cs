using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Mediator
{
    public abstract class Aircraft
    {
        protected IMediator mediator;

        public Aircraft(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Send(string message);
    }
}

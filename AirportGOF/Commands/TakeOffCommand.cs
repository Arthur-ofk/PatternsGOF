using AirportGOF.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF.Commands
{
    public  class TakeOffCommand
    {
       
            private Aircraft aircraft;

            public TakeOffCommand(Aircraft aircraft)
            {
                this.aircraft = aircraft;
            }

            public void Execute()
            {
                aircraft.TakeOff();
            }
        
    }
}

using AirportGOF.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF.Commands
{
    public class LandCommand
    {
        private Aircraft aircraft;

        public LandCommand(Aircraft aircraft)
        {
            this.aircraft = aircraft;
        }

        public void Execute()
        {
            aircraft.Land();
        }
    }
}

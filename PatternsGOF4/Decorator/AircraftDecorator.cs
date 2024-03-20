using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Decorator
{
    internal abstract  class AircraftDecorator : IAircraft
    {
        protected IAircraft aircraft;

        public AircraftDecorator(IAircraft aircraft)
        {
            this.aircraft = aircraft;
        }

        public virtual void DisplayFeatures()
        {
            aircraft.DisplayFeatures();
        }
    }
}

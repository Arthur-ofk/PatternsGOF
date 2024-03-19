using AirportGOF.Dispetcher;
using AirportGOF.Factory;
using AirportGOF.FlightMode;
using AirportGOF.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF.Builder
{
    public  class ACBuilder
    {
        private AircraftFactory _aircraftFactory = new AircraftFactory();
        private Aircraft aircraft;
        FlightStatus status;
        public ACBuilder(string type , FlightStatus status) 
        {
            if (type.Equals("Passenger"))
            {
                aircraft = _aircraftFactory.CreatePassengerAircraft();
                
            }
            else
            {
                aircraft = _aircraftFactory.CreatePassengerAircraft();     
            }
            this.status = status;
        }
        public ACBuilder SetEngine(string engine)
        {
            aircraft.Engine = engine;
            ;

            return this;
        }
         
        public ACBuilder SetWings(string wings)
        {
            aircraft.Wings = wings;
            return this;
        }

        public ACBuilder SetSeats(string seats)
        {
            aircraft.Seats = seats;
            return this;
        }

        public ACBuilder  SetFlightMode(IFlightMode mode )
        {
            status.Notify();
            aircraft.FlightMode = mode;
            return this;
        }
        public Aircraft Build()
        {
            return aircraft;
        }

    }
}

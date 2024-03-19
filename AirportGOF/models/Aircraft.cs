using AirportGOF.Dispetcher;
using AirportGOF.FlightMode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF.models
{
    public    class Aircraft 
    {
        
        public string Type { get; set; }
        public string Engine { get; set; }
        public string Wings { get; set; }
        public string Seats { get; set; }
       
        public IFlightMode FlightMode { get; set; }
       
        public  void TakeOff()
        {
            Console.WriteLine( "TO THE SKY");
           
        }
        public void Land()
        {
            Console.WriteLine("pls don`t crush(optionaly)");
           
        }
    }
}

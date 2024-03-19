

using AirportGOF.Dispetcher.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF.Dispetcher
{
    public class FlightStatus : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string status;

        public string Status
        {
            get { return status; }
            set
            {
                status = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}

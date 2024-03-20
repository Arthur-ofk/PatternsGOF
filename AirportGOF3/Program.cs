using AirportGOF3.ChainP;
using AirportGOF3.Iterator;

namespace AirportGOF3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                
                case 4:
                    // Chain of Responsibility
                    var handler1 = new SpecificHandler1();
                    var handler2 = new SpecificHandler2();
                    handler1.SetSuccessor(handler2);
                    handler1.HandleRequest(15);
                    break;
                case 5:
                    // Iterator
                    var aircraftCollection = new AircraftCollection();
                    while (aircraftCollection.HasNext())
                    {
                        Console.WriteLine(aircraftCollection.Next());
                    }
                    break;
                case 6:
                    // Mediator
                    var mediator = new Mediator.Mediator();
                    var airplane = new Mediator.Plane(mediator);
                    airplane.Send("Ready for takeoff.");
                    break;
                case 7:
                    // Memento
                    var aircraft = new Memento.Aircraft();
                    aircraft.SetState("On ground");
                    var memento = aircraft.SaveState();
                    aircraft.SetState("In flight");
                    aircraft.RestoreState(memento);
                    Console.WriteLine(aircraft.GetState()); // Output: On ground
                    break;
                case 8:
                    // State
                    var aircraftContext = new State.Aircraft();
                    aircraftContext.Request();
                    aircraftContext.Request();
                    break;
                case 9:
                    // Template Method
                    var airportProcess = new Template.DomesticAirportProcess();
                    airportProcess.ExecuteProcess();
                    break;
                case 10:
                    // Visitor
                    var visitor = new Visitor.AircraftStatusVisitor();
                    var airplaneVisitable = new Visitor.Airplane();
                    var helicopterVisitable = new Visitor.Helicopter();
                    airplaneVisitable.Accept(visitor);
                    helicopterVisitable.Accept(visitor);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        }
    }
}

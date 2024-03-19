
using AirportGOF.Builder;
using AirportGOF.Commands;
using AirportGOF.Dispetcher;
using AirportGOF.FlightMode;
using AirportGOF.models;
using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
      

        bool exit = false;
        Aircraft aircraft = null;
        ACBuilder aCBuilder = null;
        TakeOffCommand takeOff=null;
        LandCommand land = null;
        FlightStatus status = new FlightStatus();
        ACManager manager = new ACManager();
        status.Attach(manager);
        string type;

        while (!exit)
        {
            Console.WriteLine("Welcome to the Aircraft Console Menu!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Create Aircraft");
            Console.WriteLine("2 Attach some components to plane");
            Console.WriteLine("3 Set flight mode to plane");
            Console.WriteLine("4 BUILD");
            Console.WriteLine("5 control pannel");
            Console.WriteLine(" abandon creation");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("what type of plane do yo want? \n 1 Passenger\n 2 Cargo");
                    int choise = int.Parse(Console.ReadLine());
                    if (choise == 1)
                    {
                       type = "Passenger";
                        Console.WriteLine("your type will be Passenger");

                    }
                    else
                    {
                        type = "Cargo";
                        Console.WriteLine("your type will be Cargo");
                    }
                    aCBuilder = new  ACBuilder(type, status);
                    break;
                case "2":
                    Console.WriteLine( "1 Add engine \n 2 Add wings \n 3 Add seats \n4 exit");
                    
                    bool exitAddComp = false;
                    while (!exitAddComp)
                    {
                        int choiseComp = int.Parse(Console.ReadLine());
                        switch (choiseComp)
                        {
                           
                            case 1:
                                aCBuilder.SetEngine(Console.ReadLine());
                                Console.WriteLine("engine added");
                                break;
                            case 2: 
                                aCBuilder.SetWings(Console.ReadLine());
                                Console.WriteLine("wings added(good choise)");
                                break;
                            case 3: aCBuilder.SetSeats(Console.ReadLine());
                                Console.WriteLine("seats added(hope it s not cargo plane)");
                                break;
                            case 4: exitAddComp = true;
                                break;
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine( " fly normal or we have an emergency?\n 1/2");
                    int choiseMode = int.Parse(Console.ReadLine());
                    if (choiseMode ==1 )

                    {
                        NormalFlightProgram NFP = new NormalFlightProgram();
                        aCBuilder.SetFlightMode(NFP);
                        Console.WriteLine("so everything allright");
                    }
                    else
                    {
                        EmergencyFlightProgram EMP = new EmergencyFlightProgram();
                        aCBuilder.SetFlightMode(EMP);
                        Console.WriteLine("HURRY UP");
                    }
                    break;
                case "4" : 
                     aircraft = aCBuilder.Build();
                    Console.WriteLine("plane has been built");
                    break;
                case "5" : 
                    exit = true; break;
                case "6" :
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }

            if (aircraft != null)
            {
                Console.WriteLine("Select an action:");
                Console.WriteLine("1. Take off");
                Console.WriteLine("2. Land");
                Console.WriteLine("3 change flight mode");
                Console.WriteLine(" 4 listen to engine sound");
                bool panexit =false;
                while (!panexit) 
                {
                    Console.WriteLine("Select an action:");
                    Console.WriteLine("1. Take off");
                    Console.WriteLine("2. Land");
                    Console.WriteLine("3 change flight mode");
                    Console.WriteLine(" 4 listen to engine sound");
                    string actionpan = Console.ReadLine();
                    //pannel
                    switch (actionpan)
                    {
                        case "1":
                            if (takeOff == null)
                            {
                                takeOff = new TakeOffCommand(aircraft);
                            }
                            takeOff.Execute();
                            aircraft.FlightMode.ExecuteFlight();
                            break;
                        case "2":
                            if (land == null)
                            {
                                land = new LandCommand(aircraft);
                            }
                            land.Execute();
                            break;
                        case "3":

                            if (aircraft.FlightMode.GetFlightType() == typeof(NormalFlightProgram))
                            {

                                aCBuilder.SetFlightMode(new EmergencyFlightProgram());

                                aCBuilder.Build();
                            }
                            else
                            {
                                aCBuilder.SetFlightMode(new NormalFlightProgram());
                                aCBuilder.Build();
                            }
                            break;
                        case "4":
                            aircraft.FlightMode.ExecuteFlight();
                            break;
                        default:
                            Console.WriteLine("Invalid action. Please choose again.");

                            break;
                    }
                }
               
                
            }
        }
    }
}
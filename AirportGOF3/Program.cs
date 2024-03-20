using AirportGOF3.ChainP;

namespace AirportGOF3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 0:
                    var specificHandler1 = new SpecificHandler1();
                    var specificHandler2 = new SpecificHandler2();
                    specificHandler1.SetSuccessor(specificHandler2);
                    specificHandler1.HandleRequest(15);
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.ChainP
{
    public class SpecificHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{request} handled by ConcreteHandler2");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}

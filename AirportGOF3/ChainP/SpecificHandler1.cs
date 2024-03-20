using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.ChainP
{
    public class SpecificHandler1 : Handler
    {
        Handler succecor2 = new SpecificHandler2();
        

        public override void HandleRequest(int request)
        {
            
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{request} handled by ConcreteHandler1");
            }
            else 
            {
               
                successor.HandleRequest(request);
            }
        }
    }
}

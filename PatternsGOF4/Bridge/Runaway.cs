using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Bridge
{
    public class ConcreteRunway : IRunway
    {
        public void LandOn()
        {
            Console.WriteLine("Landing on concrete runway.");
        }
    }
}

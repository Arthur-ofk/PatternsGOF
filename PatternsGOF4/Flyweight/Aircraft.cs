using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Flyweight
{
    internal class Aircraft
    {
        private string type;

        public Aircraft(string type)
        {
            this.type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Aircraft type: " + type);
        }
    }
}

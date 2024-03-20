using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Composite
{
    public class Terminal : IComponent
    {
        private readonly string name;

        public Terminal(string name)
        {
            this.name = name;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Terminal: " + name);
        }
    }
}

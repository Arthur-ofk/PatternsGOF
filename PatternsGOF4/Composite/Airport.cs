using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGOF4.Composite
{
    internal class Airport :IComponent
    {
        private readonly List<IComponent> components = new List<IComponent>();
        private readonly string name;

        public Airport(string name)
        {
            this.name = name;
        }

        public void Add(IComponent component)
        {
            components.Add(component);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Airport: " + name);
            foreach (var component in components)
            {
                component.DisplayDetails();
            }
        }
    }
}

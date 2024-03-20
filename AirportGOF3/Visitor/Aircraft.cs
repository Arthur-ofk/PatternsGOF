using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Visitor
{
    public  abstract class Aircraft
    {
        public abstract void Accept(IVisitor visitor);
    }
}

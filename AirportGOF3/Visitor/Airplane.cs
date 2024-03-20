using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Visitor
{
    public class Airplane : Aircraft
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitAirplane(this);
        }
    }
}

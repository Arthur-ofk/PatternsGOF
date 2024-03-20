using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Visitor
{
    public interface IVisitor
    {
        void VisitAirplane(Airplane airplane);
        void VisitHelicopter(Helicopter helicopter);
    }
}

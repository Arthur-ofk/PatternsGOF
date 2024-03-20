using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.State
{
    public interface IState
    {
        void HandleState(Aircraft context);
        
    }
}

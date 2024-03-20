using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Template
{
    public class AirportTemplate
    {
        public void ExecuteProcess()
        {
            OpenAirport();
            PerformChecks();
            CloseAirport();
        }

        protected abstract void OpenAirport();
        protected abstract void PerformChecks();
        protected abstract void CloseAirport();
    }
}

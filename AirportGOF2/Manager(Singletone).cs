using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF2
{
    public  class Manager_Singletone_
    {
        private static Manager_Singletone_ instance;

       
        private Manager_Singletone_()
        {
           
        }

        
        public static Manager_Singletone_ GetInstance()
        {
            if (instance == null)
            {
                instance = new Manager_Singletone_();
            }
            return instance;
        }

    }
}

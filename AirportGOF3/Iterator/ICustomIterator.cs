using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGOF3.Iterator
{
    public interface ICustomIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
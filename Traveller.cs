using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure_Pattern
{
    class Traveller
    {
        public void Travel(ITransport transport)
        {
            transport.Get_Price();
            transport.Get_Time();
        }
    }
}

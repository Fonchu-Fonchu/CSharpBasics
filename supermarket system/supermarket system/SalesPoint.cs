using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket_system
{
    internal class SalesPoint : Store
    {
        String ID;
        public SalesPoint(String id)
        {
            this.ID = id;   
        }
    }
}

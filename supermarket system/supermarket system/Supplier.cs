using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket_system
{
     internal class Supplier : Person
    {
        internal int id;
        internal Supplier(int id)
        {
            this.id = id;
        }
    }
}

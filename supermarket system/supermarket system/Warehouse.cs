using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket_system
{
    internal class Warehouse : Store
    {
        internal String ID;
        public Warehouse(String id)
        {
            this.ID = id;
        }
    }
}

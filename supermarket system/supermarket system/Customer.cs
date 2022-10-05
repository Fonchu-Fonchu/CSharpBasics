using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket_system
{
    internal class Customer : Person
    {
        int id;
        public Customer(int ID)
        {
            this.id = ID;
        }
    }
}

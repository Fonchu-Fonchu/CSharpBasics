using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket_system
{
    internal class Cashier : Employee
    {
        String salePoint;
        int id;

        public Cashier(String pointOfSale, int ID)
        {
            this.salePoint = pointOfSale;
            this.id = ID;
        }
    }
}

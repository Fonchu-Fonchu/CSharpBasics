using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket_system
{
    class Product
    {
        public int prod_id;
        public String product_name;
        public String product_description;
        public String product_type;
        public double product_price;
        public String expiryDate;
        public String prodDate;
        internal Product(int id, String name, String description, String type, double price, String ExpDate, String prodDate)
         {
             this.product_description = description;
             this.product_name = name;
             this.prod_id = id;
             this.product_type = type;
             this.product_price = price;
             this.expiryDate = ExpDate;
             this.prodDate = prodDate; 
         }
        
        public float getTotalPrice(String name, int quantity)
        {
            float totalPrice = (float)(product_price * quantity);
            if (quantity >= 10)
            {
                float discount = (2 / 100) * totalPrice;
                totalPrice = totalPrice - discount;
            }
            return totalPrice;
        }

        
    }
}

using supermarket_system;
using System;

class Market
{
    static void Main()
    {
        //Product bread = new Product();
        Supplier supplier = new Supplier(1);
        supplier.Address = "hello";
        supplier.Contact = "heheu";
        supplier.id = 1;
        supplier.Name = "tave";

        Console.WriteLine(supplier.id);
    }
}
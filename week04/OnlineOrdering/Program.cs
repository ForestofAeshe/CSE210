using System;
using OrderProgram;

class Program
{
    static void Main(string[] args)
    {   
        Address myAddress = new Address("123 Street Name","City X","UT", "USA");
        Customer myCustomer = new Customer("Aero", "Vector",myAddress);
        Order myOrder = new Order(myCustomer);



        myOrder.AddProduct(new Product("Rhino Prime", "rhino",5,1));
        myOrder.AddProduct(new Product("Flamethrower","Blueflame",100,2));
        myOrder.AddProduct(new Product("Fuel Tank", "ammo1", (float) 0.5, 200));

        myOrder.PrintPackingList();
        myOrder.PrintShippingLabel();
    }
}
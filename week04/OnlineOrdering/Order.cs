using System;

namespace OrderProgram
{
    class Order
    {
        private List<Product> _product;
        private Customer _customer;
        private float _orderTotal;
        private float _shippingCost;

            public Order(Customer customer)
        {
            _product = new List<Product>();
            _customer = customer;
            _orderTotal = 0;
            _shippingCost = ShippingCost();
        }

        private float ShippingCost()
        
        {
            if (_customer.IsUSA())
            {
                return 5;
            }
            else
            {
                return 35;
            }
        }

        public void AddProduct(Product product)
        {
            _product.Add(product);
            _orderTotal += product.GetTotalPrice();
        }

        public void PrintPackingList()
        {
            Console.WriteLine($"Product ID | Product Name | Product Quantity | Product Price | Product Total Price");
            for (int i = 0; i < _product.Count; i++)
            {
                //print {product ID} | {3000x} | {product quantity} | {product Price} | {totalPrice}
                Console.WriteLine($"{_product[i].GetID()} | {_product[i].GetName()} | {_product[i].GetQuantity()} | {_product[i].GetPrice()} | {_product[i].GetTotalPrice()}");
            }
            Console.WriteLine("\n--------------------------");
            Console.WriteLine($"Shipping Cost: {_shippingCost}\n Grand Total: {_orderTotal+_shippingCost}");
            Console.WriteLine("\n--------------------------");
        }
        public void PrintShippingLabel()
        {
            Console.WriteLine("Address");
            Console.WriteLine($"{_customer.GetFullName()}\n {_customer.GetStreet()},\n {_customer.GetCity()}, {_customer.GetState()}, {_customer.GetCountry()}");
        }

    }
}
using System;

namespace OrderProgram
{
    public class Product
    {
        private string _productName;
        private string _productID;
        private float _productPrice;
        private float _productQuantity;

        public Product(string productName, string productID, float productPrice, float productQuantity)
        {
            _productName = productName;
            _productID = productID;
            _productPrice = productPrice;
            _productQuantity = productQuantity;
        }
        public float GetTotalPrice()
        {
            return _productPrice*_productQuantity;
        }

        public string GetID()
        {
            return _productID;
        }

        public float GetPrice()
        {
            return _productPrice;
        }

        public float GetQuantity()
        {
            return _productQuantity;
        }

        public string GetName()
        {
            return _productName;
        }
    }
}
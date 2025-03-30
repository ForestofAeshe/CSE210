using System;

namespace OrderProgram
{
    class Customer
    {
        private string _fname;
        private string _lname;
        private string _fullname;
        private Address _custAddress;

        public Customer(string fname, string lname, Address custAddress)
        {
            _fname = fname;
            _lname = lname;
            _fullname = $"{fname} {lname}";
            _custAddress = custAddress;
        }

        public string GetFullName()
        {
            return _fullname;
        }

        public bool IsUSA()
        {
            return _custAddress.IsUSA();
        }
        public string GetStreet()
        {
            return _custAddress.GetStreet();
        }
        public string GetCity()
        {
            return _custAddress.GetCity();
        }
        public string GetState()
        {
            return _custAddress.GetState();
        }
        public string GetCountry()
        {
            return _custAddress.GetCountry();
        }
        
    }
}
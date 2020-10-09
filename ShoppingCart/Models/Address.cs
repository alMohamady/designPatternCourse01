using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string AddressDetails { get; set; }
        public string PinCode { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}

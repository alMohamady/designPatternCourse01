using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Interfaces
{
    public interface IAddress
    {
        Address GetAddressDetails(int userID);
    }
}

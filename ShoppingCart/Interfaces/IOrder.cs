using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Interfaces
{
    public interface IOrder
    {
        int PlaceOrderDetails(int cartID, int shippingAddressID);
    }
}

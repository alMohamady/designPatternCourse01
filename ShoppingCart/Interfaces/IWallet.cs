using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Interfaces
{
    public interface IWallet
    {
        double GetUserBalance(int userID);
    }
}

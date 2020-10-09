
using ShoppingCartFacade;
using singleton.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace singleton
{
    class Program
    {


        static void Main(string[] args)
        {

            IUserOrder userOrder = new UserOrder();
            Console.WriteLine("Facade : Start");
            Console.WriteLine("************************************");
            int cartID = userOrder.AddToCart(10, 1);
            int userID = 1234;
            Console.WriteLine("************************************");
            int orderID = userOrder.PlaceOrder(cartID, userID);
            Console.WriteLine("************************************");
            Console.WriteLine("Facade : End CartID = {0}, OrderID = {1}",
                cartID, orderID);
            Console.ReadLine();


            Console.ReadKey(true);
        }
    }
}

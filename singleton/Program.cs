
using singleton.Bridge;
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

            Payment order = new CardPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();

            order._IPaymentSystem = new IDBIPaymentSystem();
            order.MakePayment();

            order = new NetBankingPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();


            Console.ReadKey(true);
        }
    }
}

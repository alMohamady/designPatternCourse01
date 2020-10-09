
using singleton.Decorator;
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

            ICar car = new Suzuki();
            CarDecorator decorator = new OfferPrice(car);
            Console.WriteLine(string.Format("Make :{0}  Price:{1} " +
                "DiscountPrice : {2}"
                , decorator.Make, decorator.GetPrice().ToString(),
                decorator.GetDiscountedPrice().ToString()));
            Console.ReadLine();


            Console.ReadKey(true);
        }
    }
}

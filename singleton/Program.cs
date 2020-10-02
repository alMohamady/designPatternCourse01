using singleton.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using singleton.Builder;
using singleton.Prototype;

namespace singleton
{
    class Program
    {



        static void Main(string[] args)
        {

            Person emp1 = new Person()
            {
                Id = Guid.NewGuid(),
                Name = "Ahmed",
                Age = 35,
                AddressDetails = new Adress()
                {
                    DoorNumber = 10,
                    StreetNumber = 20,
                    Zipcode = 90025,
                    Country = "US"
                }
            };

            Console.WriteLine(emp1.ToString());

            Person emp2 = emp1.DeepCopy();

            emp2.Name = "Mohmed";
            emp2.Age = 50;
            emp2.AddressDetails.StreetNumber = 21;
            emp2.AddressDetails.DoorNumber = 11;
            
            Console.WriteLine(emp2.ToString());

            Console.WriteLine("Modified Details of Ahmed");
            emp1.AddressDetails.DoorNumber = 30;
            emp1.AddressDetails.StreetNumber = 40;

            emp1.Age = 40;
            Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp2.ToString());
            Console.ReadLine();

            Console.ReadKey(true);
        }



    }
}

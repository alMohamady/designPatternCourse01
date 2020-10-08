using singleton.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using singleton.Builder;
using singleton.Prototype;
using singleton.Composite;

namespace singleton
{
    class Program
    {



        static void Main(string[] args)
        {


            IEmployee John = new Employee("John", "IT");
            IEmployee Mike = new Employee("Mike", "IT");
            IEmployee Jason = new Employee("Jason", "HR");
            IEmployee Eric = new Employee("Eric", "HR");
            IEmployee Henry = new Employee("Henry", "HR");

            IEmployee Ahmed = new Manager("Ahmed", "IT")
            { SubOrdinates = { John, Mike } };

            IEmployee Mohamed = new Manager("Mohamed", "HR")
            { SubOrdinates = { Jason, Eric, Henry } };

            IEmployee Bob = new Manager("Bob", "Head")
            { SubOrdinates = { Ahmed, Mohamed } };

            Ahmed.GetDetails(1);
            Bob.GetDetails(1);

            Console.ReadLine();


            Console.ReadKey(true);
        }



    }
}

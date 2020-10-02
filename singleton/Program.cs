using singleton.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using singleton.Builder;
using singleton.Prototype;
using singleton.Adapter;

namespace singleton
{
    class Program
    {



        static void Main(string[] args)
        {


            IEmployee emp = new EmployeeAdapter();
            string value = emp.GetAllEmployees();

            Console.WriteLine(value);  

            Console.ReadKey(true);
        }



    }
}

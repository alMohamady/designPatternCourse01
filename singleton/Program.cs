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

            Person p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1977-01-01");
            p1.Name = "Ahmed Mohamady";
            p1.idInfo = new IdInfo(666);

            Person p2 = p1.ShallowCopy();
            Person p3 = p1.DeepCopy();
            Person p4 = p1;

            Console.WriteLine("Original values of p1, p2, p3, p4:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);
            Console.WriteLine("   p4 instance values:");
            DisplayValues(p4);

            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Mohamed Salah";
            p1.idInfo.IdNumber = 7878;

            Console.WriteLine("\nValues of p1, p2, p4 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);
            Console.WriteLine("   p4 instance values");
            DisplayValues(p4);

            Console.ReadKey(true);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name, p.Age, p.BirthDate);
            Console.WriteLine("      ID#: {0:d}", p.idInfo.IdNumber);
        }


    }
}

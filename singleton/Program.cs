using singleton.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace singleton
{
    class Program
    {
        class Client
        {
            public static void ClientCode(AbstractClass abstractClass)
            {

                abstractClass.TemplateMethod();
            }
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());

            Console.ReadKey(true);
        }
    }
}

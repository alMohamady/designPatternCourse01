using singleton.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using singleton.Builder;
using singleton.Prototype;
using singleton.Composite;
using singleton.Proxy;

namespace singleton
{
    class Program
    {

        public class Client
        {
            public void ClientCode(ISubject subject)
            {
                // ...

                subject.Request();

                // ...
            }
        }

        static void Main(string[] args)
        {

            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            Subject realSubject = new Subject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            TheProxy proxy = new TheProxy(realSubject);
            client.ClientCode(proxy);


            Console.ReadKey(true);
        }



    }
}

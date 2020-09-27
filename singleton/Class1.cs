using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    sealed class Class1
    {
        private static int counter;
        private static readonly Lazy<Class1> instance = new Lazy<Class1>(() => new Class1());

        private Class1()
        {
            counter += 1;
            Console.WriteLine(" Instance Number  " + counter.ToString());
        }

        public static Class1 getInstance()
        {
            return instance.Value;
        }

        public void print(string msg)
        {
            Console.WriteLine(msg);
        }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Proxy
{

    public interface ISubject
    {
        void Request();
    }

    class Subject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }

    class TheProxy : ISubject
    {
        private Subject _realSubject;

        public TheProxy(Subject realSubject)
        {
            this._realSubject = realSubject;
        }

        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realSubject = new Subject();
                this._realSubject.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }


}

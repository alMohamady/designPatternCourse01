using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Factory
{
    interface ITireLareg
    {
        void drowLaregTire();
    }

    class TireLareg : ITireLareg
    {
        public void drowLaregTire()
        {
            Console.WriteLine("The Lareg Tire");
        }
    }

}

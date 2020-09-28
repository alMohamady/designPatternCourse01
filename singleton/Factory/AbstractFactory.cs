using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Factory
{
    interface AbstractFactory
    {
        void drowTire(string tire);

        Car getYourCar(string type);
    }
}

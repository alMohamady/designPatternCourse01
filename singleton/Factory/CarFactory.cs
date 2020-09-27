using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Factory
{
    class CarFactory
    {

        public Car getYourCar(string type)
        {
            switch (type)
            {
                case "S":
                    return new SedanCar();
                case "U":
                    return new SUVCar();
                default:
                    return new TruckCar();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Factory
{
     class TruckCar : Car 
    {
        public TruckCar()
        {
            carName = "Truck";
            modelNumber = 2019;
        }

    }
}

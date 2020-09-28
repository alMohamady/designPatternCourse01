using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Factory
{
    interface ITireXLareg
    {
        void drowTireXLareg();
    }

    class TireXLareg : ITireXLareg
    {
        public void drowTireXLareg()
        {
            Console.WriteLine("Drow X-Lareg Tire");
        }
    }
}

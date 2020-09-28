using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Factory
{
    interface ITireSmall
    {
        void drowSamllTire();
    }

    class TireSmall : ITireSmall
    {
        public void drowSamllTire()
        {
            Console.WriteLine("Drow Samll Tire");
        }
    }
}

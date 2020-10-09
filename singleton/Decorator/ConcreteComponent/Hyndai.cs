using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Decorator
{
    class Hyndai : ICar
    {
        public string Make
        {
            get { return "Sedan"; }
        }
        public double GetPrice()
        {
            return 1000000;
        }
    }
}

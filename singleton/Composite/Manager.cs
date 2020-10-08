using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Composite
{
    class Manager : IEmployee
    {

        public List<IEmployee> SubOrdinates;

        public Manager(string name, string dept)
        {
            this.Name = name;
            this.Department = dept;
            SubOrdinates = new List<IEmployee>();
        }

        public string Name { get; set; }
        public string Department { get; set; }


        public void GetDetails(int indentation)
        {
            Console.WriteLine(string.Format("{2}- Name:{0}, " +
                    "Dept:{1} - Manager(Composite)",
                    this.Name.ToString(),
                    this.Department,
                     new String('-', indentation)));
            
            
            foreach (IEmployee component in SubOrdinates)
            {
                component.GetDetails(indentation + 1);
            }
        }
    }
}

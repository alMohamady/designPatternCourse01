using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Prototype
{
    class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo idInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        { 
           Person person = (Person)this.MemberwiseClone();
           person.idInfo = new IdInfo(this.idInfo.IdNumber);
            person.Name = String.Copy(Name);
            return person;
        }

    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }
}

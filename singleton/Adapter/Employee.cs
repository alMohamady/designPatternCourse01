using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace singleton.Adapter
{
    [Serializable]
    public class Employee
    {
        Employee() { }

        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        
        [XmlAttribute]
        public int ID { get; set; }
        
        [XmlAttribute]
        public string Name { get; set; }
    }

    public class EmployeeManager
    {
        public List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
            this.employees.Add(new Employee(1, "Ahmed"));
            this.employees.Add(new Employee(2, "Mohamed"));
            this.employees.Add(new Employee(3, "Salah"));
        }

        public virtual string GetAllEmployees()
        {
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(employees.GetType());


            var settings = new XmlWriterSettings(); 
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, employees, emptyNamepsaces);
                return stream.ToString();
            }
        }
    }

    public interface IEmployee
    { 
       string GetAllEmployees();
    }

}

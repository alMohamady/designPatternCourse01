using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace singleton.Adapter
{
    public class EmployeeAdapter :EmployeeManager, IEmployee
    {
        public override string GetAllEmployees()
        {
            string returnXml = base.GetAllEmployees();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(returnXml);
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }
}

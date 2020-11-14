using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Visitor
{
    public class Client
    {
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}

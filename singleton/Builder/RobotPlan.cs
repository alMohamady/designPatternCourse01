using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Builder
{
    interface IRobotPlan
    {
        void setRobotHead(String Head);
        void setRobotArmes(String Armes);
        void setRobotLegs(String Legs);
        void setRobotBody(String Body);
    }
}

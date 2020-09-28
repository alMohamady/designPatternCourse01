using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Builder
{
    interface IRobotBuilder
    {
        void buildRobotHead();
        void buildRobotArmes();
        void buildRobotLegs();
        void buildRobotBody();
        Robot getRobot(); 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Builder
{
    class RobotBulderOld : IRobotBuilder
    {

        public RobotBulderOld()
        {
            robot = new Robot(); 
        }

        private Robot robot;

        public void buildRobotArmes()
        {
            robot.setRobotArmes("The Arms");
        }

        public void buildRobotBody()
        {
            robot.setRobotBody("the Body");
        }

        public void buildRobotHead()
        {
            robot.setRobotHead("the Head");
        }

        public void buildRobotLegs()
        {
            robot.setRobotLegs("the Legs");
        }

        public Robot getRobot()
        {
            return robot;
        }
    }
}

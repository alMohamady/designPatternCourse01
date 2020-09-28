using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Builder
{
    class RobotBuilder
    {
        private IRobotBuilder robotBuilder;

        public RobotBuilder(IRobotBuilder _robotBuilder)
        {
            this.robotBuilder = _robotBuilder;
        }

        public Robot getRobot() {
            return robotBuilder.getRobot();
        }

        public void makeRobot()
        {
            robotBuilder.buildRobotArmes();
            robotBuilder.buildRobotBody();
            robotBuilder.buildRobotHead();
            robotBuilder.buildRobotLegs();
        }
    }
}

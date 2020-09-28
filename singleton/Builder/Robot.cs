using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.Builder
{
    class Robot : IRobotPlan
    {
        private string RobotArmes;
        private string RobotBody;
        private string RobotHead;
        private string RobotLegs;

        public void setRobotArmes(string Armes)
        {
            RobotArmes = Armes;
        }

        public void setRobotBody(string Body)
        {
            RobotBody = Body;
        }

        public void setRobotHead(string Head)
        {
            RobotHead = Head;
        }

        public void setRobotLegs(string Legs)
        {
            RobotLegs = Legs;
        }

        public string getRobotArmes()
        {
            return RobotArmes;
        }

        public string getRobotBody()
        {
            return RobotBody ;
        }

        public string getRobotHead()
        {
            return RobotHead;
        }

        public string getRobotLegs()
        {
            return RobotLegs;
        }
    }
}

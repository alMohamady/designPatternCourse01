using singleton.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using singleton.Builder;


namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            IRobotBuilder robotBuilderOld = new RobotBulderOld();
            
            RobotBuilder robotBuilder = new RobotBuilder(robotBuilderOld);
            robotBuilder.makeRobot();

            Robot robot = robotBuilder.getRobot();

            Console.WriteLine("  Robot Head " + robot.getRobotHead());
            Console.ReadKey(true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        //Member Variables(HAS)
        public List<Robot> roboticFleet;
        public Robot robot1 = new Robot("Zappatron", 100, 100, 10);
        public Robot robot2 = new Robot("TheOhmster", 100, 100, 10);
        public Robot robot3 = new Robot("Gigawhat", 100, 100, 10);

        //Constructor(SPAWNER)
        public Fleet()
        {
            roboticFleet = new List<Robot>();
            roboticFleet.Add(robot1);
            roboticFleet.Add(robot2);
            roboticFleet.Add(robot3);
        }

        //Member Methods(CAN DO)
        


        //Need to store all robots here
    }
}

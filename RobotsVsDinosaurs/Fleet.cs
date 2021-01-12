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

        //Constructor(SPAWNER)
        public Fleet()
        {
            Robot robot1 = new Robot("Zappatron", 100, 100, 30);
            Robot robot2 = new Robot("TheOhmster", 100, 100, 25);
            Robot robot3 = new Robot("Gigawhat", 100, 100, 50);
            roboticFleet = new List<Robot>();
            roboticFleet.Add(robot1);
            roboticFleet.Add(robot2);
            roboticFleet.Add(robot3);
        }

        //Member Methods(CAN DO)
        


        //Need to store all robots here
    }
}

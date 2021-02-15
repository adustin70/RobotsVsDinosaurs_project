using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet : Army
    {
        //Member Variables(HAS)
        

        //Constructor(SPAWNER)
        public Fleet()
        {
            fighters = new List<Fighter>();
            Robot robot1 = new Robot("Zappatron", 50, "The Zapper");
            Robot robot2 = new Robot("TheOhmster", 25, "Ohmageanator");
            Robot robot3 = new Robot("Gigawhat", 15, "Plastic club:(");
            fighters.Add(robot1);
            fighters.Add(robot2);
            fighters.Add(robot3);
        }

        //Member Methods(CAN DO)
        


        //Need to store all robots here
    }
}

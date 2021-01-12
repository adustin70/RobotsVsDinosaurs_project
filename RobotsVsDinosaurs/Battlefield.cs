using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        //Member Variables(HAS)
        public Fleet fleet;
        public Herd herd;

        //Constructor(SPAWNER)
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }

        //Member Methods(CAN DO)
        public void StartBattle()
        {
            
        }



        //Need to give robots and dinos ability to attack one and other
        //Need robots to lose power/energy after each attack
        //Need robots and dinos to lose health points after being attacked
        //Battle needs to end after all robots or dinos are defeated
        
    }
}

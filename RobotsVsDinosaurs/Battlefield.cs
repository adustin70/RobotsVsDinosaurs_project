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
            while (fleet.roboticFleet[0].robotHealth > 0 && herd.dinosaurHerd[0].dinoHealth > 0)
            {                
                    fleet.roboticFleet[0].Attack(herd.dinosaurHerd[0]);
                    Console.WriteLine($"{fleet.roboticFleet[0].robotName}  attacks {herd.dinosaurHerd[0].dinoType}");
                    Console.WriteLine($"{herd.dinosaurHerd[0].dinoType} health drops to {herd.dinosaurHerd[0].dinoHealth}\n");

                if (fleet.roboticFleet[0].robotHealth == 0 || herd.dinosaurHerd[0].dinoHealth == 0)
                {
                    Console.WriteLine($"{fleet.roboticFleet[0].robotName} Wins!\n");
                    break;
                }
                    herd.dinosaurHerd[0].Attack(fleet.roboticFleet[0]);
                    Console.WriteLine($"{herd.dinosaurHerd[0].dinoType} attacks {fleet.roboticFleet[0].robotName}");
                    Console.WriteLine($"{fleet.roboticFleet[0].robotName} health drops to {fleet.roboticFleet[0].robotHealth}\n");                
            }


            while (fleet.roboticFleet[1].robotHealth > 0 && herd.dinosaurHerd[1].dinoHealth > 0)
            {                
                    fleet.roboticFleet[1].Attack(herd.dinosaurHerd[1]);
                    Console.WriteLine($"{fleet.roboticFleet[1].robotName}  attacks {herd.dinosaurHerd[1].dinoType}");
                    Console.WriteLine($"{herd.dinosaurHerd[1].dinoType} health drops to {herd.dinosaurHerd[1].dinoHealth}\n");

                if (fleet.roboticFleet[1].robotHealth == 0 || herd.dinosaurHerd[1].dinoHealth == 0)
                {
                    Console.WriteLine($"{fleet.roboticFleet[1].robotName} Wins!\n");
                    break;
                }

                herd.dinosaurHerd[1].Attack(fleet.roboticFleet[1]);
                    Console.WriteLine($"{herd.dinosaurHerd[1].dinoType} attacks {fleet.roboticFleet[1].robotName}");
                    Console.WriteLine($"{fleet.roboticFleet[1].robotName} health drops to {fleet.roboticFleet[1].robotHealth}\n");                
            }


            while (fleet.roboticFleet[2].robotHealth > 0 && herd.dinosaurHerd[2].dinoHealth > 0)
            {                
                    fleet.roboticFleet[2].Attack(herd.dinosaurHerd[2]);
                    Console.WriteLine($"{fleet.roboticFleet[2].robotName}  attacks {herd.dinosaurHerd[2].dinoType}");
                    Console.WriteLine($"{herd.dinosaurHerd[2].dinoType} health drops to {herd.dinosaurHerd[2].dinoHealth}\n");

                if (fleet.roboticFleet[2].robotHealth == 0 || herd.dinosaurHerd[2].dinoHealth == 0)
                {
                    Console.WriteLine($"{fleet.roboticFleet[2].robotName} Wins!\n");
                    break;
                }

                herd.dinosaurHerd[2].Attack(fleet.roboticFleet[2]);
                    Console.WriteLine($"{herd.dinosaurHerd[2].dinoType} attacks {fleet.roboticFleet[2].robotName}");
                    Console.WriteLine($"{fleet.roboticFleet[2].robotName} health drops to {fleet.roboticFleet[2].robotHealth}\n");                
            }

            Console.WriteLine($"The winners are {fleet.roboticFleet[0].robotName}, {fleet.roboticFleet[1].robotName} and {fleet.roboticFleet[2].robotName}");
        }



        //Need to give robots and dinos ability to attack one and other
        //Need robots to lose power/energy after each attack
        //Need robots and dinos to lose health points after being attacked
        //Battle needs to end after all robots or dinos are defeated
        
    }
}

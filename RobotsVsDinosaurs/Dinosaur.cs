using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur : Fighter
    {
        //Member Variables(HAS)
        public int dinoEnergy;
        public int dinoAttackPower;


        //Constructor(SPAWNER)

        public Dinosaur(string dinoType, int dinoAttackPower)
        {
            this.name = dinoType;
            health = 100;
            dinoEnergy = 100;
            this.dinoAttackPower = dinoAttackPower;            
        }


        //Member Methods(CAN DO)
        public override void Attack(Fighter robot)
        {
            robot.health = robot.health - dinoAttackPower;
            dinoEnergy = dinoEnergy - 10;
            if (robot.health < 0)
            {
                robot.health = 0;
            }
            Console.WriteLine($"{name} attacked {robot.name} for {dinoAttackPower} damage. Robot's health is now {robot.health}\n");
        }

        



        //Give dinos a type, health, energy, and attack power
        //Want at least one dino to be able to choose it's attack type from an array of attacks before battle
    }
}

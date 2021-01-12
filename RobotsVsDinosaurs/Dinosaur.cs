using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        //Member Variables(HAS)
        public string dinoType;        
        public int dinoHealth;
        public int dinoEnergy;
        public int dinoAttackPower;
        //Add after base program is working
        /*public string dinoAttackType;*/



        //Constructor(SPAWNER)

        public Dinosaur(string dinoType, int dinoHealth, int dinoEnergy, int dinoAttackPower)
        {
            this.dinoType = dinoType;
            this.dinoHealth = dinoHealth;
            this.dinoEnergy = dinoEnergy;
            this.dinoAttackPower = dinoAttackPower;            
        }


        //Member Methods(CAN DO)
        public int Attack(Robot robot)
        {
            robot.robotHealth = robot.robotHealth - dinoAttackPower;
            return robot.robotHealth;
        }

        



        //Give dinos a type, health, energy, and attack power
        //Want at least one dino to be able to choose it's attack type from an array of attacks before battle
    }
}

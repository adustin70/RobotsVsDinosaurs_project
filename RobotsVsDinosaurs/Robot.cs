using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        //Member Variables(HAS)
        public string robotName;     
        public int robotHealth;
        public int robotPowerLevel;
        public int robotAttackPower;
        public Weapon weapon;



        //Constructor(SPAWNER)
        public Robot(string robotName, int robotHealth, int robotPowerLevel, int robotAttackPower)
        {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            this.robotAttackPower = robotAttackPower;
        }


        //Member Methods(CAN DO)
        //make a method.  "When it's called, it will do this"
        public int RobotAttack(Dinosaur dinoType)
        {
            dinoType.dinoHealth = dinoType.dinoHealth - robotAttackPower;
            return dinoType.dinoHealth;
        }

        

        //Give robots names, health, power lvl and a weapon(or list of weapons) with attack power
        //Want at least one robot to be able to choose its weapon from list before battle
    }
}

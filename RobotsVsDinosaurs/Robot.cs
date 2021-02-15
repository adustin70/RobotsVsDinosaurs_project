using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot : Fighter
    {
        //Member Variables(HAS)
        public int robotPowerLevel;
        public Weapon weapon;



        //Constructor(SPAWNER)
        public Robot(string robotName, int robotAttackPower, string weaponType)
        { 
            name = robotName;
            health = 100;
            this.weapon = new Weapon(weaponType, robotAttackPower);
        }


        //Member Methods(CAN DO)
        //make a method.  "When it's called, it will do this"
        public override void Attack(Fighter dino)
        {   
            dino.health = dino.health - weapon.attackPower;
            robotPowerLevel = robotPowerLevel - 10;
            if (dino.health < 0)
            {
                dino.health = 0;
            }
            Console.WriteLine($"{name} has attacked {dino.name} with a {weapon.type} for {weapon.attackPower} damage. Dino's health is now {dino.health}\n");
        }

        

        //Give robots names, health, power lvl and a weapon(or list of weapons) with attack power
        //Want at least one robot to be able to choose its weapon from list before battle
    }
}

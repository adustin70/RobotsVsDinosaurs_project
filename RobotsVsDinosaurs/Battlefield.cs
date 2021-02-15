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

        public void StartingMessage()
        {
            Console.WriteLine("Welcome to Robots Vs Dinosaurs!!!");
        }

        public void Rules()
        {
            Console.WriteLine("Choose your fighters then fight to the death!!!");
        }

        public int ChooseFighter(string verb, string fighterType, Army army)
        {
            Console.WriteLine($"Choose {fighterType} who will {verb}:");
            for (int i = 0; i < army.fighters.Count; i++)
            {
                Console.WriteLine($"Press {i} for {army.fighters[i].name}");
            }
            string userInput = Console.ReadLine();
            int chosenFighter = Int32.Parse(userInput);
            return chosenFighter;
        }

        public void SingleAttack(int attack, int defend, Army attacker, Army defender)
        {
            attacker.fighters[attack].Attack(defender.fighters[defend]);
            if (defender.fighters[defend].health <= 0)
            {
                Console.WriteLine(defender.fighters[defend].name + "Was killed");
                defender.fighters.RemoveAt(defend);
            }
        }

        public void DisplayWinner()
        {
            if (fleet.fighters.Count > 0)
            {
                Console.WriteLine("The Robots conquer all!");
            }
            else
            {
                Console.WriteLine("Dinosaurs destroyed tin men!");
            }
        }

        public void StartBattle()
        {
            StartingMessage();
            Rules();

            while (fleet.fighters.Count > 0 && herd.fighters.Count > 0)
            {
                int robotAttakcer = ChooseFighter("attack", "robot", fleet);
                int dinoDefender = ChooseFighter("defend", "dino", herd);
                SingleAttack(robotAttakcer, dinoDefender, fleet, herd);

                if (herd.fighters.Count > 0)
                {
                    int dinoAttacker = ChooseFighter("attack", "dino", herd);
                    int robotDefender = ChooseFighter("defend", "robot", fleet);
                    SingleAttack(dinoAttacker, robotDefender, herd, fleet);
                }
            }

            DisplayWinner();
            Console.ReadLine();
        }



        //Need to give robots and dinos ability to attack one and other
        //Need robots to lose power/energy after each attack
        //Need robots and dinos to lose health points after being attacked
        //Battle needs to end after all robots or dinos are defeated
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd : Army
    {
        //Member Variables(HAS)


        ////Constructor(SPAWNER)
        public Herd()
        {
            fighters = new List<Fighter>();
            Dinosaur dinosaur1 = new Dinosaur("Dogzilla", 50);
            Dinosaur dinosaur2 = new Dinosaur("MegaCat", 20);
            Dinosaur dinosaur3 = new Dinosaur("SinisterSnips", 15);
            fighters.Add(dinosaur1);
            fighters.Add(dinosaur2);
            fighters.Add(dinosaur3);
        }


        //Member Methods(CAN DO)
        



        //Need to store all dinos here
    }
}

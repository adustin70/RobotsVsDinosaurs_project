using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        //Member Variables(HAS)
        public List<Dinosaur> dinosaurHerd;
        
        


        ////Constructor(SPAWNER)
        public Herd()
        {
            Dinosaur dinosaur1 = new Dinosaur("Dogzilla", 100, 100, 25);
            Dinosaur dinosaur2 = new Dinosaur("MegaCat", 100, 100, 25);
            Dinosaur dinosaur3 = new Dinosaur("SinisterSnips", 100, 100, 25);
            dinosaurHerd = new List<Dinosaur>();
            dinosaurHerd.Add(dinosaur1);
            dinosaurHerd.Add(dinosaur2);
            dinosaurHerd.Add(dinosaur3);
        }


        //Member Methods(CAN DO)
        



        //Need to store all dinos here
    }
}

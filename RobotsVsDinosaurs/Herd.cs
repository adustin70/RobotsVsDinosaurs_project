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
        List<Dinosaur> dinosaurHerd;
        public Dinosaur dinosaur1 = new Dinosaur("Dogzilla", 100, 100, 10);
        public Dinosaur dinosaur2 = new Dinosaur("MegaCat", 100, 100, 10);
        public Dinosaur dinosaur3 = new Dinosaur("SinisterSnips", 100, 100, 10);
        
        


        ////Constructor(SPAWNER)
        public Herd(Dinosaur dinosaur)
        {
            dinosaurHerd = new List<Dinosaur>();
            dinosaurHerd.Add(dinosaur1);
            dinosaurHerd.Add(dinosaur2);
            dinosaurHerd.Add(dinosaur3);
        }


        //Member Methods(CAN DO)
        



        //Need to store all dinos here
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public abstract class Fighter
    {
        //Member Variables(HAS)
        public string name;
        public int health;

        //Constructor(SPAWNER)

        //Member Methods(CAN DO)
        public abstract void Attack(Fighter fighter);

    }
}

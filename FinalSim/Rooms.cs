using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{

    public abstract class Rooms
    {
        public abstract void Enter(Sim sim, Item item, Backpack backpack);
    }
}
   
    



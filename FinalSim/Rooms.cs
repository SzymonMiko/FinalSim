using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
     abstract class Rooms
    {
        public abstract void enter();
    }
    public class Kitchen : Rooms
    {

        public override void enter(Sim sim)
        {

        int newenergy ;
            newenergy = sim.GetEnergy;
            sim.SetEnergy = newenergy;
    }
    } 
    }



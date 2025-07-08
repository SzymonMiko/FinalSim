using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
    internal abstract class Rooms
    {
        public abstract void enter();
    }
    public class Kitchen : Rooms
    {

        public override void enter()
        {
              Sim sim = new Sim("drew", 90);
        int newenergy = sim.energy -= 1; 
            sim.energy = newenergy;
    }
    } 
    }



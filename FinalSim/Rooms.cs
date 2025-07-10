using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
    public abstract class Rooms 
    {
        public abstract void Enter(Sim sim); 
    }
    public class Kitchen : Rooms
    {
        public override void Enter(Sim sim)
        {
            int newEnergy = (int)(sim.GetEnergy() - 1);
            sim.SetEnergy(newEnergy);
        }
    }
    }



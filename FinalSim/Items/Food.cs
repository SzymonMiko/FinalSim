using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim.Items
{
    class Food : Item, IValuable
    {
        public Food() : base("Food") { }
        public int Value => 5;
        public override void Increase(Sim sim)
        {

            sim.Hunger = sim.Hunger + 20;


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
    class NewsPaper : Item, IValuable
    {
        public NewsPaper() : base("NewsPaper") { }
        public int Value => 5;
        public override void Increase(Sim sim)
        {

            sim.Hapiness = (sim.Hapiness + 20);
        }
    }
}

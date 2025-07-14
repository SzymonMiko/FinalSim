using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim.Items
{
    class EnergyDrink : Item, IValuable
    {
        public EnergyDrink() : base("Energydrink") { }
        public int Value => 2;
        public override void Increase(Sim sim)
        {

            sim.Energy = sim.Energy + 2;
            int newhp = sim.Hp - 10;
            sim.Hp = newhp;
        }

        internal override void Remove(Item item)
        {
            throw new NotImplementedException();
        }
    }
}

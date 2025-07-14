using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim.Items
{
    public abstract class Item
    {
        public string Name { get; }
        public Item(string name) => Name = name;
    public abstract void Increase(Sim sim);

        internal abstract void Remove(Item item);
    }

    interface IValuable
    {
        int Value { get; }
    }
    
}
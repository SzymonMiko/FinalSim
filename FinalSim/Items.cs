using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
    internal abstract class Items
    {
        string Name;
        int Price;
        public abstract void Use();
    }
    internal class Food : Items 
    {

    
    }
}

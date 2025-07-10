using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
    public abstract class Item
    {
        public string Name { get; }
        public Item(string name) => Name = name;
    }

    interface IValuable
    {
        int Value { get; }
    }

    class Food : Item, IValuable
    {
        public Food() : base("Food") { }
        public int Value => 5;
        public void Increasehunger(Sim sim)
        {
            int newHunger = (int)(sim.GetHunger() + 20);
            sim.SetHunger(newHunger);

        }
    }
    class NewsPaper : Item, IValuable
    {
        public NewsPaper() : base("NewsPaper") { }
        public int Value => 5;
        public void Increasehapiness(Sim sim)
        {
            int newHapiness = (int)(sim.GetHapiness() + 20);
            sim.SetHapiness(newHapiness);
        }
    }
    class EnergyDrink : Item, IValuable
    {
        public EnergyDrink() : base("Energydrink") { }
        public int Value => 2;
        public void IncreaseEnergy (Sim sim)
        {
            int newEnergy = (int)(sim.GetEnergy() + 2);
            sim.SetEnergy(newEnergy);
            int newHP = (int)(sim.GetHp() + 20);
            sim.SetHp(newHP);
        }
    }

}
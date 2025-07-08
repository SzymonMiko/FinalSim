using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
    internal class Sim
    {
        string Name;
        int hp = 100;
        int hapiness = 100;
        int hunger = 100;
        int money;
        public int energy = 10;

        public Sim(string v1, int v2)
        {
        }

        public Sim(string Name, int hp, int hapiness, int hunger, int money, int energy)
        {
            this.Name = Name;
            this.hp = hp;
            this.hapiness = hapiness;
            this.hunger = hunger;
            this.money = money;
            this.energy = energy;
        }

        public void SuddenSleep()
        {
            if (energy >= 0)
            {
                Console.WriteLine("U Fall Asleep and get brought to your bed it costs u 5 money");
                money -= 5;
                energy = 6;
            }

        }
        public void sleep()
        {
            if (Sim)
            {
            }
        }
    }
}

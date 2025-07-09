using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
     class Sim
    {
        protected string Name;
        protected int hp = 100;
        protected int hapiness = 100;
        protected int hunger = 100;
        protected int money ;
        protected int energy ;

        public Sim(string Name, int hp, int hapiness, int hunger, int money, int energy)
        {
            this.Name = Name;
            this.hp = hp;
            this.hapiness = hapiness;
            this.hunger = hunger;
            this.money = money;
            this.energy = energy;
        }
        public int GetEnergy() => energy;
        public int SetEnergy(int newEnergy) => energy = Math.Clamp(newEnergy, 0, 100);
        public int GetHapiness() => hapiness;
        public int SetHapiness(int newhapiness) => hapiness = Math.Clamp(newhapiness, 0, 100);
        public int GetHunger() => hunger;
        public int SetHunger(int newhunger) => hunger = Math.Clamp(newhunger, 0, 100);
        public int GetMoney() => money;
        public int SetMoney(int newmoney) => money = Math.Clamp(newmoney, 0, 9999); 
        public int GetHp() => hp;
        public int SetHp(int newhp) => hp = Math.Clamp(newhp, 0, 100);

        public void SuddenSleep()
        {
            if (energy <= 0)
            {
                Console.WriteLine("U Fall Asleep and get brought to your bed it costs u 5 money.");
                money -= 5;
                energy = 6;
            }

        }
        public void entertainself()
        {
            if (money <= 0) {
                Console.WriteLine("U entertain yourself with less than safe but free methods");
                    hapiness += 15;
                hp -= 15;
            }
            else if (money > 0) {
                Console.WriteLine("u go out and have fun");
                money -= 15;
                
            }
        }


    }
}

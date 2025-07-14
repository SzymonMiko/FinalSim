using FinalSim.Items;
using FinalSim.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
    public class Sim
    {
        protected string name;
        protected int hp = 100;
        protected int hapiness = 100;
        protected int hunger = 100;
        protected int money = 100;
        protected int energy = 8;

        public Sim(string Name)
        {
            this.name = Name;

        }
        public string Name { get => name; set => name = value; }

        public int Energy { get => energy; set => energy = Math.Clamp(value, 0, 100); }
        public int Hapiness { get => hapiness; set => hapiness = Math.Clamp(value, 0, 100); }
        public int Hunger { get => hunger; set => hunger = Math.Clamp(value, 0, 100); }
        public int Money { get => money; set => money = Math.Clamp(value, 0, 100); }
        public int Hp { get => hp; set => hp = Math.Clamp(value, 0, 100); }


        public void SuddenSleep(LivingRoom livingroom)
        {
            if (energy <= 0)
            {
                Console.WriteLine("U Fall Asleep and get brought to your bed it costs u 5 money.");
                money -= 5;
                energy = 7;
                livingroom.Enter(this, null, null);

            }
        }
        public void GoToSleep() {
        energy += 8;

        }
        public void Entertainself()
        {
            if (money <= 0)
            {
                Console.WriteLine("U entertain yourself with less than safe but free methods");
                hapiness += 15;
                hp -= 15;
            }
            else if (money > 0)
            {
                Console.WriteLine("u go out and have fun");
                hapiness += 15;
                money -= 15;

            }
        }
        public void ShowStatus()
        {
            Console.WriteLine($"Name: {name} \n, HP: {hp}\n, Happiness: {hapiness}\n, Hunger: {hunger}\n, Money: {money}\n, Energy: {energy}\n");
        }
        public void UseItem(Item item, Sim sim)
        {
            if (item is IValuable valuableitem)
            {
                if (item is Food food)
                {
                    food.Increase(sim);
                }
                else if (item is NewsPaper newspaper)
                {
                    newspaper.Increase(sim);
                }
                else if (item is EnergyDrink energydrink)
                {
                    energydrink.Increase(sim);
                }
                item.Remove(item);
                Console.WriteLine($"Used {item.Name}. Value: {valuableitem.Value}");
            }
            else
            {
                Console.WriteLine($"{item.Name} cannot be used.");
            }

        }



    }
}


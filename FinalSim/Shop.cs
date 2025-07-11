using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
    class Shop : Rooms
    {
        public override void Enter(Sim sim, Item item, Backpack backpack)
        {
            int newenergy = (sim.Energy - 1);
            sim.Energy = newenergy;


            bool shopping = true;

            while (shopping)
            {
                sim.ShowStatus();
                Console.WriteLine("Buy something: 1 - Food (5 money), 2 - Newspaper (5 money), 3 - EnergyDrink (10 money)");
                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                Food food = new Food();
                NewsPaper newspaper = new NewsPaper();

                if (choice == 1 && sim.Money >= food.Value)
                {
                    food = new Food();
                    int newmoney = (sim.Money - food.Value);
                    sim.Money = newmoney;
                    food.Increase((Sim)sim);
                    Console.WriteLine($"You bought: {food.Name}. Hunger: {((Sim)sim).Hunger}");
                    backpack.AddItem(food);
                    backpack.ShowItems();
                }
                else if (choice == 2 && sim.Money >= newspaper.Value)
                {
                    newspaper = new NewsPaper();
                    int newmoney = (sim.Money - newspaper.Value);
                    sim.Money = newmoney;
                    newspaper.Increase((Sim)sim);
                    Console.WriteLine($"You bought: {newspaper.Name}. Hapiness: {((Sim)sim).Hapiness}");
                    backpack.AddItem(newspaper);
                    backpack.ShowItems();
                }
                else if (choice == 3 && sim.Money >= 2)
                {
                    EnergyDrink energydrink = new EnergyDrink();
                    int newmoney = (sim.Money - energydrink.Value);
                    sim.Money = newmoney;
                    energydrink.Increase((Sim)sim);
                    Console.WriteLine($"You bought: {energydrink.Name}. Energy: {((Sim)sim).Energy}");
                    backpack.AddItem(energydrink);
                    backpack.ShowItems();
                }
                else
                {
                    Console.WriteLine("Lacking funds or invalid item.");
                }

                Console.Write("Buy anything else? 1 = YES / any = NO: ");
                shopping = Console.ReadLine() == "1";
            }

        
        }
    }
}

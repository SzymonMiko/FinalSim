using FinalSim.Items;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim.Rooms
{
    class Shop : Rooms
    {
        public override void Enter(Sim sim, Item item, Backpack backpack)
        {
            int newenergy = sim.Energy - 1;
            
            bool shopping = true;

            while (shopping)
            {
                sim.ShowStatus();
                Console.WriteLine("Buy something: 1 - Food (5 money), 2 - Newspaper (5 money), 3 - EnergyDrink (10 money)");
                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());
                sim.ShowStatus();
                item = choice switch
                {
                    1 => new Food(),
                    2 => new NewsPaper(),
                    3 => new EnergyDrink(),
                };
           
                if (choice == 1 && sim.Money >= item.Value)
                {
                    sim.Money -= item.Value;
                    food.Increase(sim);
                    Console.WriteLine($"You bought: {food.Name}. Hunger: {sim.Hunger}");
                    backpack.AddItem(food);
                    backpack.ShowItems();
                }
                else if (choice == 2 && sim.Money >= newspaper.Value)
                {

                    sim.Money -= item.Value;
                    newspaper.Increase(sim);
                    Console.WriteLine($"You bought: {newspaper.Name}. Hapiness: {sim.Hapiness}");
                    backpack.AddItem(newspaper);
                    backpack.ShowItems();
                }
                else if (choice == 3 && sim.Money >= 2)
                {

                    sim.Money -= item.Value;
                    energydrink.Increase(sim);
                    Console.WriteLine($"You bought: {energydrink.Name}. Energy: {sim.Energy}");
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

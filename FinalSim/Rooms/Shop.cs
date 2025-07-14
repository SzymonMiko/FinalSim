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
                    _ => null
                };

                if (item != null && item is IValuable valuableItem)
                {
                    switch (item)
                    {
                        case Food f:backpack.AddItem(f); sim.Money -= valuableItem.Value; break;
                        case NewsPaper n: backpack.AddItem(n); sim.Money -= valuableItem.Value; break;
                        case EnergyDrink e: backpack.AddItem(e); sim.Money -= valuableItem.Value; break;
                    }
                }

                Console.Write("Buy anything else? 1 = YES / any = NO: ");
                shopping = Console.ReadLine() == "1";
            }
        }
    }
}

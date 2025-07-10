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
        public override void enter(Sim sim, Item item, Backpack backpack)
        {

            bool shopping = true;

            while (shopping)
            {
                Console.WriteLine($"Your money: {sim.GetMoney}");
                Console.WriteLine("Buy something: 1 - Food (5 rubies), 2 - Newspaper (5 rubies)");
                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                Food Food = new Food();
                NewsPaper Newspaper = new NewsPaper();

                if (choice == 1 && sim.GetMoney() >= Food.Value)
                {
                    Food = new Food();
                    int newMoney = (int)(sim.GetMoney() - Food.Value);
                    sim.SetMoney(newMoney);
                    Food.Increasehunger((Sim)sim);
                    Console.WriteLine($"You bought: {Food.Name}. Hunger: {((Sim)sim).GetHunger()}");
                    backpack.AddItem(Food);
                }
                else if (choice == 2 && sim.GetMoney() >= Newspaper.Value)
                {
                    Newspaper = new NewsPaper();
                    int newMoney = (int)(sim.GetMoney() - Newspaper.Value);
                    sim.SetMoney(newMoney);
                    Newspaper.Increasehapiness((Sim)sim);
                    Console.WriteLine($"You bought: {Newspaper.Name}. Hapiness: {((Sim)sim).GetHapiness()}");
                    backpack.AddItem(Newspaper);
                }
                else if (choice == 3 && sim.GetMoney() >= 2)
                {
                    EnergyDrink energyDrink = new EnergyDrink();
                    int newMoney = (int)(sim.GetMoney() - energyDrink.Value);
                    sim.SetMoney(newMoney);
                    energyDrink.IncreaseEnergy((Sim)sim);
                    Console.WriteLine($"You bought: {energyDrink.Name}. Energy: {((Sim)sim).GetEnergy()}");
                    backpack.AddItem(energyDrink);
                }
                else
                {
                    Console.WriteLine("Lacking funds or invalid item.");
                }

                Console.Write("Buy anything else? 1 = YES / any = NO: ");
                shopping = Console.ReadLine() == "1";
            }

        ((Sim)sim).EncounterCompleted();
        }
    }
}

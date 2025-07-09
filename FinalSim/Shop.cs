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
        public override void enter(Sim sim , Item item)
        {
            
            bool shopping = true;

            while (shopping)
            {
                Console.WriteLine($"Your money: {money}");
                Console.WriteLine("Buy something: 1 - Food (2 rubies), 2 - Newspaper (2 rubies)");
                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                Food Food = new Food();
                NewsPaper Newspaper = new NewsPaper();

                if (choice == 1 && money >= Food.Value)
                {
                    money -= Food.Value;
                    Food.IncreaseBaseDamage((Sim)player, 10.0);
                    Console.WriteLine($"You bought: {Food.Name}. Hunger: {((Sim)player).GetHunger()}");
                }
                else if (choice == 2 && money >= Newspaper.Value)
                {
                    money -= Newspaper.Value;
                    Newspaper.Increasehapiness((Sim)player, 10.0);
                    Console.WriteLine($"You bought: {Newspaper.Name}. Hapiness: {((Sim)player).GetHapiness()}");
                }
                else
                {
                    Console.WriteLine("Lacking funds or invalid item.");
                }

                Console.Write("Buy anything else? 1 = YES / any = NO: ");
                shopping = Console.ReadLine() == "1";
            }

        ((Sim)player).EncounterCompleted();
        }
    }

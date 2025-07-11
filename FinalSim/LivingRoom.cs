using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
    public class LivingRoom : Rooms
    {
        public override void Enter(Sim sim, Item item, Backpack backpack)
        {
            int newenergy = (sim.Energy - 1);
            sim.Energy = newenergy;
            Console.WriteLine("You entered the living room.");
            Console.WriteLine("You can relax here to increase your happiness.");
            Console.WriteLine("1. Relax");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                sim.Entertainself();
                sim.ShowStatus();
            }
        }
    }

}

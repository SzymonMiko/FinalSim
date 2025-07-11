using FinalSim.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim.Rooms
{
    public class Kitchen : Rooms
    {
        public override void Enter(Sim sim, Item item, Backpack backpack)
        {
            int newenergy = sim.Energy - 1;
            sim.Equals(newenergy);

            Console.WriteLine("You entered the kitchen.");
            Console.WriteLine("You lost energy your energy is" + sim.Energy);
            Console.WriteLine("You can cook food here to double food effectivenes or just eat food.");
            Console.WriteLine("1. Cook food");
            Console.WriteLine("2. Eat food");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            { }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
   
    public abstract class Rooms
    {
        public abstract void Enter(Sim sim, Item item, Backpack backpack);
    }
    public class Kitchen : Rooms
    {
        public override void Enter(Sim sim, Item item, Backpack backpack)
        {
            int newEnergy = (sim.GetEnergy() - 1);
            sim.SetEnergy(newEnergy);

            Console.WriteLine("You entered the kitchen.");
            Console.WriteLine("You lost energy your energy is" + sim.GetEnergy);
            Console.WriteLine("You can cook food here to double food effectivenes or just eat food.");
            Console.WriteLine("1. Cook food");
            Console.WriteLine("2. Eat food");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            
        }
    }

 }



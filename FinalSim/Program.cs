using FinalSim.Items;
using FinalSim.Rooms;
using System;
using System.Security.Cryptography.X509Certificates;

namespace FinalSim
{
    class Program
    {

        private static Item item;

        
        static void Main(string[] args)
        {
             
            int dayCounter = 0;
            Console.WriteLine("Welcome to FinalSim!");
            Console.WriteLine("Please write your name");
            string name = Console.ReadLine();
            Sim sim = new Sim(name);
            Backpack backpack = new Backpack();
            Console.WriteLine($"Welcome {sim.Name} to the FinalSim!");
            sim.ShowStatus();
            Console.WriteLine("1. Go to the shop");
            Console.WriteLine("2. Enter your room");
            Console.WriteLine("3  Enter kitchen");
            Console.WriteLine("4  Go to Work");
            Console.WriteLine("5. Exit the game");
            bool running = true;
            while (running)
            {
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Shop shop = new Shop();
                        shop.Enter(sim , item, backpack);
                        backpack.ShowItems();
                        break;
                    case "2": 
                        LivingRoom livingRoom = new LivingRoom();
                        livingRoom.Enter(sim, item, backpack);
                        break;
                    case "3":
                        running = false;
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            Console.WriteLine("Thank you for playing FinalSim!");
        }
    }
}

using System;

namespace FinalSim
{
    class Program
    {
        private static Item item;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FinalSim!");
            Console.WriteLine("Please write your name");
            string name = Console.ReadLine();
            Sim sim = new Sim(name);
            Backpack backpack = new Backpack();
            Console.WriteLine($"Welcome {sim.GetName} to the FinalSim!");
            Console.WriteLine("You can do the following:");
            Console.WriteLine("1. Go to the shop");
            Console.WriteLine("2. Enter your room");
            Console.WriteLine("3. Exit the game");
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
                        break;
                    case "2":
                        // Implement room logic here
                        Console.WriteLine("You entered your room.");
                        break;
                    case "3":
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

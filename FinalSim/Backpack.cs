using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSim
{
    public class Backpack
    {
        public List<Item> items { get; private set; } = new List<Item>();
        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"Added {item.Name} to backpack.");
        }
        public void ShowItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Your backpack is empty.");
            }
            else
            {
                Console.WriteLine("Items in your backpack:");
                foreach (var item in items)
                {
                    Console.WriteLine($"- {item.Name}");
                }
            }
        }
        public void UseItem(Item item, Sim sim)
        {
            if (item is IValuable valuableitem)
            {
                if (item is Food food)
                {
                    food.Increase(sim);
                    items.Remove(food);
                }
                else if (item is NewsPaper newspaper)
                {
                    newspaper.Increase(sim);
                    items.Remove(newspaper);
                }
                else if (item is EnergyDrink energydrink)
                {
                    energydrink.Increase(sim);
                    items.Remove(energydrink);
                }
                Console.WriteLine($"Used {item.Name}. Value: {valuableitem.Value}");
            }
            else
            {
                Console.WriteLine($"{item.Name} cannot be used.");
            }
        }
    }
}
    
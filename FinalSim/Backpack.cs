using FinalSim.Items;
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
        
        }
       
       

        }
    

    
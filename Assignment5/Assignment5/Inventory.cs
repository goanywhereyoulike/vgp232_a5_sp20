using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Inventory
    {
        int Slots;
        public List<Item> items;

        public Inventory(int slots)
        {
            Slots = slots;
            items = new List<Item>(slots);
        }

        public void Add(Item item)
        {
            if (items.Count < Slots)
            {
                items.Add(item);
            }
            else
            {
                Console.WriteLine("The list is full");
            }
            // TODO: add implementation.
            //throw new NotImplementedException();
        }

        public void Remove(Item item)
        {
            if (items.Count > 0)
            {
                if (items.Remove(item) == false)
                {
                    Console.WriteLine("Wrong item to remove");
                }
            }
            else
            {
                Console.WriteLine("Nothing to remove");
            }
            
            // TODO: add implementation.
            //throw new NotImplementedException();
        }

        public void ShowInventory()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("Name: " + items[i].Name + ", Modifier: " + items[i].Modifier
                    + ", IType: " + items[i].IType);
            }

            // TODO: add implementation.
            //throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Inventory
    {
        int slots;
        List<Item> items;

        public Inventory(int slots)
        {
            items = new List<Item>(slots);
        }

        public void Add(Item item)
        {
            items.Add(item);
            // TODO: add implementation.
            //throw new NotImplementedException();
        }

        public void Remove(Item item)
        {
            items.Remove(item);
            // TODO: add implementation.
            //throw new NotImplementedException();
        }

        public void ShowInventory()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("Name: "+items[i].Name+ ", Modifier: "+ items[i].Modifier
                    + ", IType: "+ items[i].IType);
            }
            
            // TODO: add implementation.
            //throw new NotImplementedException();
        }
    }
}

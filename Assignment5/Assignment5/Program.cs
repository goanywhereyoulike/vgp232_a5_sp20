﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

            Inventory inventory = new Inventory(3);
            Item item1 = new Item("grass",10, ItemType.consumable);
            Item item2 = new Item("flower", 15, ItemType.key);
            Item item3 = new Item("tree", 20, ItemType.equipment);
            inventory.Add(item1);
            inventory.Add(item2);
            inventory.Add(item3);
            inventory.Remove(item1);
            inventory.Remove(item2);
            inventory.ShowInventory();
            // TODO: initialize the inventory
            // Add a few items
            // Remove a few items
            // show the inventory.

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Assignment5
{
    [TestFixture]
    public class UnitTests
    {
        private Character character;
        private Inventory inventory;
        private Item item1;
        private Item item2;
        private Item item3;

        [SetUp]
        public void SetUp()
        {
            character = new Character("Bob", RaceCatagory.Elf, 100);
            inventory = new Inventory(3);
            item1 = new Item("grass", 10, ItemType.consumable);
            item2 = new Item("flower", 15, ItemType.key);
            item3 = new Item("tree", 20, ItemType.equipment);
        }
        //setup

        [Test]
        public void CheckCharacterTakeDamage()
        {
            character.TakeDamage(20);
            Assert.AreEqual(character.HealthPoints, 80);
        }


        [Test]
        public void CheckCharacterRestoreHealth()
        {
            character.HealthPoints = 100;
            character.RestoreHealth(20);
            Assert.AreEqual(character.HealthPoints, 120);
        }

        [Test]
        public void CheckInventoryAdd()
        {
            inventory.Add(item1);
            inventory.Add(item2);
            Assert.AreEqual(inventory.items[0].Name, "grass");
            Assert.AreEqual(inventory.items[0].Modifier, 10);
            Assert.AreEqual(inventory.items[0].IType, ItemType.consumable);
            Assert.AreEqual(inventory.items[1].Name, "flower");
            Assert.AreEqual(inventory.items[1].Modifier, 15);
            Assert.AreEqual(inventory.items[1].IType, ItemType.key);
        }

        [Test]
        public void CheckInventoryRemove()
        {
            inventory.Add(item1);
            inventory.Add(item2);
            inventory.Remove(item1);
            Assert.AreEqual(inventory.items.Count(), 1);
            Assert.AreEqual(inventory.items[0].Name, "flower");
            Assert.AreEqual(inventory.items[0].Modifier, 15);
            Assert.AreEqual(inventory.items[0].IType, ItemType.key);



        }

    }


}

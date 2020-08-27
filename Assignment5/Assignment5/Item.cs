using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public enum ItemType { consumable, key, equipment }

    public class Item
    {
        public string Name { get; set; }
        public int Modifier { get; set; }
        public ItemType IType { get; set; }

        public Item(string name, int modifier, ItemType type)
        {
            Name = name;
            Modifier = modifier;
            IType = type;
        }
    }
}

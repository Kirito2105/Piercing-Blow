using System.Collections.Generic;
using System.Linq;

namespace PiercingBlow.Commons.Model.Enum.Player.Inventory
{
    public class PlayerInventory
    {
        public PlayerEquep Equep = new PlayerEquep();
        public List<Item> Items = new List<Item>();

        public List<Item> GetItemsFromSlot(int slot)
        {
            return Items.Where(x => x._slot == slot).ToList();
        }

        public List<Item> GetItemsOnType(int type)
        {
            if (type == 1)
            {
                return Items.Where(x => x._slot >= 1 && x._slot < 6).ToList();
            }
            else if (type == 2)
            {
                return Items.Where(x => x._slot >= 6 && x._slot < 11).ToList();
            }
            return null;
        }
    }
}

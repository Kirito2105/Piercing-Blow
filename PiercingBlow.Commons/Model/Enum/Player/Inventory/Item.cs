namespace PiercingBlow.Commons.Model.Enum.Player.Inventory
{
    public class Item
    {
        public int _id { get; set; }

        public int _slot { get; set; }

        public Item(int id, int slot)
        {
            _id = id;
            _slot = slot;
        }
    }
}

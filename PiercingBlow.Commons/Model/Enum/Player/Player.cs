using PiercingBlow.Commons.Model.Enum.Player.Inventory;

namespace PiercingBlow.Commons.Model.Enum.Player
{
    public class Player
    {
        private Room _room;

        public int Id { get; set; }

        public string Name { get; set; }

        public byte ColorName { get; set; }

        public string ClanName { get; set; }

        public int Points { get; set; }

        public int Cash { get; set; }

        public int Rank { get; set; }

        public int Exp { get; set; }

        public int Match { get; set; }

        public int Win { get; set; }

        public int Lose { get; set; }

        public int Draw { get; set; }

        public int Kill { get; set; }

        public int Headshot { get; set; }

        public int Death { get; set; }

        public int Assist { get; set; }

        public int CountChara { get; set; }
        public PlayerInventory Inventory { get; set; }

        public Room getRoom()
        {
            return _room;
        }

        public void setRoom(Room r)
        {
            _room = r;
        }
    }
}

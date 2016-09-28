using PiercingBlow.Commons.Model.Enum.Player;
using PiercingBlow.Game.Model.Room;

namespace PiercingBlow.Game.Model.Rooms
{
    public class RoomSlot
    {
        private int id;
        private int allKills, oneTimeKills;
        private int lastKillMessage, killMessage;
        private int allDeath;
        private int botScore;
        private Player player;

        private int allExp;
        private int allGP;

        public int lastKillState;
        public bool repeatLastState;

        private SlotState state = SlotState.Empty;
    }
}

using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Model.Room;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_BATTLE_STARTBATTLE_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_BATTLE_STARTBATTLE_ACK());
            Client.SendPacket(new PROTOCOL_BATTLE_MISSION_ROUND_PRE_START_ACK());
            Client.SendPacket(new PROTOCOL_BATTLE_MISSION_ROUND_START_ACK());
            Client.SendPacket(new PROTOCOL_ROOM_GET_SLOTINFO_ACK(SlotState.PreBattle, Client.Player));
            Client.SendPacket(new PROTOCOL_BATTLE_CHANGE_DIFFICULTY_LEVEL_ACK());
        }
    }
}

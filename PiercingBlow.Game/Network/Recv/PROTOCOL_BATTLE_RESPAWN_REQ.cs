using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Model.Room;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_BATTLE_RESPAWN_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_ROOM_GET_SLOTINFO_ACK(SlotState.Battle, Client.Player));
            Client.SendPacket(new PROTOCOL_BATTLE_RESPAWN_ACK(Client.Character));
        }
    }
}

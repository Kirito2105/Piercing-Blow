using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Model.Room;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_BATTLE_PRESTARTBATTLE_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_BATTLE_PRESTARTBATTLE_ACK());
            Client.SendPacket(new PROTOCOL_BATTLE_SLOTSTATE_PRE_ACK());
            Client.SendPacket(new PROTOCOL_ROOM_GET_SLOTINFO_ACK(SlotState.PreStart, Client.Player));
        }
    }
}

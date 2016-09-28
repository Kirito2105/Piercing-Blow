using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Model.Room;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_BATTLE_READYBATTLE_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_BATTLE_START_GAME_ACK(Client.Character));
            Client.SendPacket(new PROTOCOL_ROOM_GET_SLOTINFO_ACK(SlotState.Load, Client.Player));
        }
    }
}

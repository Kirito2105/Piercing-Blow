using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_BATTLE_RESPAWN_FOR_AI_REQ : ClientPacket
    {
        private int slot;
        public override void ReadImpl()
        {
            slot = ReadInt();
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_BATTLE_RESPAWN_FOR_AI_ACK(slot));
        }
    }
}

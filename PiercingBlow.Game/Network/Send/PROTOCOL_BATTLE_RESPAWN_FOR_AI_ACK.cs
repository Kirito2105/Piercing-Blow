using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_BATTLE_RESPAWN_FOR_AI_ACK : ServerPacket
    {
        private int _slot;
        public PROTOCOL_BATTLE_RESPAWN_FOR_AI_ACK(int slot)
        {
            _slot = slot;
        }
        public override void WriteImpl()
        {
            WriteD(_slot);
        }
    }
}

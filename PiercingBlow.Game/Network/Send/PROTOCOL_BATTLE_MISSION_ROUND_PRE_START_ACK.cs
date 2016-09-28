using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_BATTLE_MISSION_ROUND_PRE_START_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteB(new byte[] {
                0x02, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00
            });
        }
    }
}

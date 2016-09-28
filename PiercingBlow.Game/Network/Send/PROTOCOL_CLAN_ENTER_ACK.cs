using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    public class PROTOCOL_CLAN_ENTER_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteB(new byte[] {
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x69, 0x01, 0x00, 0x00, 0x0F, 0x19, 0x00, 0x03, 0x6B, 0x49, 0xBA
            });
        }
    }
}

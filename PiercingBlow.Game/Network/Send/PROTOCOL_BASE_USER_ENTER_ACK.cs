using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_BASE_USER_ENTER_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteB(new byte[] {
                0x00, 0x4C, 0x7B, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00
            });
        }
    }
}

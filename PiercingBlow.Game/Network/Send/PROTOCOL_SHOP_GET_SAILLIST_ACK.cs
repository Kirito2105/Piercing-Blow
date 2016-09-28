using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_SHOP_GET_SAILLIST_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteB(new byte[]
{
    0x00, 0xf5, 0x8d, 0xcc, 0x5f
        });
        }
    }
}

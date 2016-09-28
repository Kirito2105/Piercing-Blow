using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_SHOP_ENTER_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteD(0);
        }
    }
}

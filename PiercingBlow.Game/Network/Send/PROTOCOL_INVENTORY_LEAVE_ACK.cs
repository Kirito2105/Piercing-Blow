using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_INVENTORY_LEAVE_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteD(0);
        }
    }
}

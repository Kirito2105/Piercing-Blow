using PiercingBlow.Commons.Network;

namespace PiercingBlow.Game.Network.Send
{
    class PROTOCOL_BASE_LOGOUT_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteH(0);
        }
    }
}

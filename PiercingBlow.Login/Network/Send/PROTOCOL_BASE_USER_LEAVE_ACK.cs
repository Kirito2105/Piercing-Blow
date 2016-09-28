///
/// Create by Kirito
///

using PiercingBlow.Commons.Network;

namespace PiercingBlow.Login.Network.Send
{
    class PROTOCOL_BASE_USER_LEAVE_ACK : ServerPacket
    {
        public override void WriteImpl()
        {
            WriteH(0);
            WriteD(0);
        }
    }
}

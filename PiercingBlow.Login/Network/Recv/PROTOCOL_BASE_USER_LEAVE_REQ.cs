///
/// Create by Kirito
///

using PiercingBlow.Commons.Network;
using PiercingBlow.Login.Network.Send;

namespace PiercingBlow.Login.Network.Recv
{
    class PROTOCOL_BASE_USER_LEAVE_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_BASE_USER_LEAVE_ACK());
        }
    }
}

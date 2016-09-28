///
/// Create by Kirito
///

using PiercingBlow.Commons.Network;
using PiercingBlow.Login.Network.Send;

namespace PiercingBlow.Login.Network.Recv
{
    class PROTOCOL_AUTH_GET_POINT_CASH_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_AUTH_GET_POINT_CASH_ACK(Client.Player));
        }
    }
}

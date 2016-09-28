///
/// Create by Kirito
///

using PiercingBlow.Commons.Network;
using PiercingBlow.Login.Network.Send;

namespace PiercingBlow.Login.Network.Recv
{
    class PROTOCOL_BASE_GET_USER_INFO_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_BASE_GET_USER_INFO_ACK(Client.Player));
            Client.SendPacket(new PROTOCOL_BASE_GET_CHARA_INFO_ACK(Client.Character, Client.Player));
        }
    }
}

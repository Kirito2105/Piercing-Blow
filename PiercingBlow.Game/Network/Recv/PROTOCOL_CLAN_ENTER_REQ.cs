using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_CLAN_ENTER_REQ : ClientPacket
    {
        public override void ReadImpl()
        {
        }

        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_CLAN_ENTER_ACK());
        }
    }
}

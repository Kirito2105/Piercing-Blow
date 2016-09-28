using PiercingBlow.Commons.Network;
using PiercingBlow.Game.Network.Send;

namespace PiercingBlow.Game.Network.Recv
{
    class PROTOCOL_CLAN_LIST_REQ : ClientPacket
    {
        int Count_Clan = 14;
        public override void ReadImpl()
        {
            Count_Clan = ReadInt();
        }
        public override void RunImpl()
        {
            Client.SendPacket(new PROTOCOL_CLAN_LIST_ACK(Count_Clan));
        }
    }
}
